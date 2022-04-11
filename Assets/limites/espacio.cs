using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espacio : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject puntoA;
    public GameObject puntoB;

    
    public GameObject puntoC;
    public GameObject puntoD;


    void Start()
    {
        float inicio = -transform.position.z;
    }

    // ACA LO IMPORTANTE ES EL EJE Z <
    void Update()
    {

        ///////////////////// tamaño -----------------------------

        float dist = Vector3.Distance(puntoA.transform.position, puntoC.transform.position);
        float dist2 = Vector3.Distance(puntoB.transform.position, puntoD.transform.position);

        transform.localScale = new Vector3 (dist2,transform.localScale.y, dist);

        transform.position = new Vector3 (dist2/2 + puntoB.transform.position.x, transform.position.y, dist/2 + puntoA.transform.position.z);

        ///////////////////// posicion -----------------------------



        ///////////////////// Volver -----------------------------    

  

    }
}
