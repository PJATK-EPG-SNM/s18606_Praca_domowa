using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HokusPokusCzaryMary : MonoBehaviour
{
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
     void OnCollisionEnter2D(Collision2D cos)
    {
        if (cos.gameObject.name.Equals("Ziemniaczek"))
        {
            Invoke("znikajac", 0.2f);
            Destroy(gameObject, 1.5f);

        }
    }
    void Ziemniaczek()
    {
        rb.isKinematic = false;

    }
     
}


