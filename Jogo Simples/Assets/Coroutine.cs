using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    
    void Start()
    {
        Material pMaterial = GetComponent<Renderer>().material;
        StartCoroutine(ChangeColor(pMaterial));
    }

    
    IEnumerator ChangeColor(Material mat)
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(1.0f);
            mat.color = Color.HSVToRGB(Random.Range(0, 1.0f), 1, 1);
        } 
    }
}
