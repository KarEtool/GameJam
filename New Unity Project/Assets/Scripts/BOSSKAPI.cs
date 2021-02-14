using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BOSSKAPI : MonoBehaviour
{
    public GameObject bosstextBu;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            bosstextBu.SetActive(true);
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    { 
        if ((other.tag == "Player") && Input.GetKeyDown("f")) 
        {
            SceneManager.LoadScene(3);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            bosstextBu.SetActive(false);
        }
    }
}
