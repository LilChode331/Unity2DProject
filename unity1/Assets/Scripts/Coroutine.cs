using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    [SerializeField] private GameObject Box;
    [SerializeField] private int timer;

    private void Start() 
    {
        StartCoroutine(HideObject());
    }

    IEnumerator HideObject()
    {
        yield return new WaitForSeconds(3);
        Box.SetActive(false);
    }
}
