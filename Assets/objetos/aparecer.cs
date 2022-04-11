using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aparecer : MonoBehaviour
{

    GameObject este;
    public MeshRenderer maya;
    Collider colision;

    bool entrando = false;
    bool adentro = false;
    bool saliendo = false;

    

    float transformacion = 1f;
    // Start is called before the first frame update
    void Start()
    {
        maya = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!entrando && !saliendo && dios.compartido.tiempoMaestro == 5)
        {
            Destroy(gameObject);
        }

        if (entrando && maya.material.GetFloat ("_Cutoff") >= 0)
        {
            transformacion = transformacion - 0.005f;
            // Debug.Log(transformacion);
            maya.material.SetFloat ("_Cutoff", transformacion);
        } 
        else if (saliendo && maya.material.GetFloat ("_Cutoff") < 1)
        {
            transformacion = transformacion + 0.01f;
            // Debug.Log(transformacion);
            maya.material.SetFloat ("_Cutoff", transformacion);
        }
        else if (saliendo && maya.material.GetFloat ("_Cutoff") >= 1)
        {
            dios.compartido.limite -= 1;
            dios.compartido.tiempo = 0;
            Destroy(gameObject);
        }
        
        
    }

    private void OnTriggerEnter(Collider espacio) {  
        
        if (espacio.tag == "espacio" && !saliendo){
            entrando = true;
            Debug.Log("adentro");
        }
        // else if (espacio.tag == "espacio" && maya.material.GetFloat ("_Cutoff") == 0) 
        // {
        //     entrando = false;
        //     saliendo = true;
        //     Debug.Log("saliendo");
        // }

    }

    private void OnTriggerExit(Collider espacio) {

        if (espacio.tag == "espacio"){
            entrando = false;
            saliendo = true;
            Debug.Log("afuera");
        }

    }

}
