using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kapigiris : MonoBehaviour
{
    public GameObject ui;
    public GameObject objectTP;
    public Transform tpLocation;
    private void Start()
    {
        ui.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        ui.SetActive(true);
        if((other.gameObject.tag=="Player")&&Input.GetKeyDown(KeyCode.F))
        {
            print("başarılı bir şekilde ışınlandın bro");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        ui.SetActive(false);
    }
}
