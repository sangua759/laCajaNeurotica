using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverB : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject modificador;

    public GameObject puntoA;
    public GameObject puntoB;

    public general m;
    void Start()
    {
        
    }

    // ACA LO IMPORTANTE ES EL EJE x <
    void Update()
    {

        ///////////////////// posicion -----------------------------

        if (modificador.transform.position.x <= transform.position.x)
        {
            transform.position = Vector3.MoveTowards(new Vector3(modificador.transform.position.x,transform.position.y,transform.position.z),new Vector3(transform.position.x,transform.position.y,transform.position.z), 0f);
        }

        ///////////////////// tamaño -----------------------------

        float dist = Vector3.Distance(puntoA.transform.position, puntoB.transform.position);

        transform.localScale = new Vector3 (dist*1.04f,transform.localScale.y,transform.localScale.z);

        transform.position = new Vector3 (transform.position.x, transform.position.y, dist/2 + puntoA.transform.position.z);        
    }
}
