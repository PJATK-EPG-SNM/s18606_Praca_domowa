using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skrypt2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a;
        int b;

        float c = 20;
        float d = 15;


        a = 2;
        b = 6;

        bool logiczna = true;
        bool inna = false;

        string bum = "Programuje w C#";
        string bam = "EPG#";

        Debug.Log("a: " + a + "logiczna: " + logiczna + "b: " + b + "c:" +c + "d:" +d + "inna:" + inna + "bum:" + bum + "bam:" +bam);

        {
            Debug.Log(a);
            Debug.Log(b);
            Debug.Log(c);
            Debug.Log(d);


        }

        
    }
}
