using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skrypt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a;
        a = 10;
        int b = 20;
        {
            Debug.Log(a);
        }

        {
            int c = 20;
        }
        float fa = 1.5f;
        fa = 20.0f;
        bool logiczna = true; //false
        string str = "napis";

        Debug.Log("fa: " + fa + "logiczna: " + logiczna + "str: " + str);

        Debug.Log(a / b);
        Debug.Log(a / fa);
        Debug.Log(Mathf.Sqrt(2));

        Debug.Log(a == b);
        Debug.Log(a != b);
        Debug.Log(a > b);
        Debug.Log(a >= b);

        if (a != b)
        {
            Debug.Log("tak");
        }
        else if (a < b)
        {
            Debug.Log("a<b");
        }
        else {
            Debug.Log("rozne");
        }

       
        {

        }

      
        Koniunkcja(a, b);
        Alternatywa();
    }

   

    public void Koniunkcja( int a, int b) {

        Debug.Log((a != b) && (a > 0));

        if ((a != b) && (a > 0)) {
        }

    }

    public void Alternatywa()
    {
        int hp = 2, time = 1;
        bool amulet = true;

        if ((hp <= 0) || time <= 0)
        {
            if (!amulet) { }
            else { }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
