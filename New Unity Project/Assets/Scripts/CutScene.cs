using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject cutCamera;

    public PlayerController playerScript;

    void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine(cutscene());
    }

    IEnumerator cutscene()
    {
        mainCamera.enabled = false;
        playerScript.enabled = false;
        cutCamera.SetActive(true);
        yield return new WaitForSeconds(3.6f);
        mainCamera.enabled = true;
        playerScript.enabled = true;
        cutCamera.SetActive(false);
        Destroy(gameObject);
    }
}


