using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        cutCamera.SetActive(true);
        yield return new WaitForSeconds(2.2f);
        SceneManager.LoadScene(2);
        mainCamera.enabled = true;
        cutCamera.SetActive(false);
    }
}


