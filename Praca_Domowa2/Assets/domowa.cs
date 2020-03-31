using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class domowa : MonoBehaviour
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

        //wyświtlamy
        Debug.Log("a: " + a + "logiczna: " + logiczna + "b: " + b + "c: " + c + "d: " + d + "inna: " + inna + "bum: " + bum + "bam: " + bam);

        //czemu nie 2 razy
        {
            Debug.Log(a);
            Debug.Log(b);
            Debug.Log(c);
            Debug.Log(d);


            //kopiujwklei tak nie
        }
        if (a != b)
        {
            Debug.Log("tak");
        }
        else
        {
            Debug.Log("Nie");
        }

        if (a < b)
        {
            Debug.Log("tak");
        }
        else
        {
            Debug.Log("Nie");
        }


        if (a <= b)
        {
            Debug.Log("tak");
        }
        else
        {
            Debug.Log("Nie");
        }


        if (a == b)
        {
            Debug.Log("tak");
        }
        else
        {
            Debug.Log("Nie");
        }


        if (a >= b)
        {
            Debug.Log("tak");
        }
        else
        {
            Debug.Log("Nie");
        }

        if (a > b)
        {
            Debug.Log("tak");
        }
        else
        {
            Debug.Log("Nie");
        }
        
        //różne napisy

        if (bum != bam)
        {
            Debug.Log("Rózne");
        }


        //oba
        Debug.Log((logiczna = true) && (inna = true));

        Debug.Log((logiczna = false) && (inna = true));

        Debug.Log((logiczna = true) && (inna = false));

        Debug.Log((logiczna = false) && (inna = false));


        //kreski

        Debug.Log((logiczna = true) || (inna = true));

        Debug.Log((logiczna = false) || (inna = true)) ;

        Debug.Log((logiczna = true) || (inna = false)) ;

        Debug.Log((logiczna = false) || (inna = false)) ;
        
    }
}

