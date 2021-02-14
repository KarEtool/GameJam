using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMe : MonoBehaviour
{
    public GameObject deleteThisCamera;

    private void Start()
    {
        StartCoroutine(deleteThis());
    }
    IEnumerator deleteThis()
    {
        yield return new WaitForSeconds(5f);
        Destroy(deleteThisCamera);
    }
}
