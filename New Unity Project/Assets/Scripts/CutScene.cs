using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject cutCamera;
    public GameObject player;
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
        yield return new WaitForSeconds(6f);
        mainCamera.enabled = true;
        playerScript.enabled = true;
        player.transform.localPosition = new Vector3(49.31305f, 9.3f, -43.63971f);
        cutCamera.SetActive(false);
    }
}


