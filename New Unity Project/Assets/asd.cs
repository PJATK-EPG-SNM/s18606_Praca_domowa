using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asd : MonoBehaviour
{

  
    
void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ziemniaczek")
        {
            StartCoroutine(TimeToWait());
        }
    }
    IEnumerator TimeToWait()
    {
        yield return new WaitForSeconds(.4f);
        Destroy(gameObject);

    }
}

