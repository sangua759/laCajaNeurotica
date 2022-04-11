using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dios : MonoBehaviour
{

    ///////////// puntos de creacion
    ////////////// PUNTOS
    public GameObject[] puntos = new GameObject[8];
    public List<GameObject> puntosUsados;

    ///////////// objetos creables
    public GameObject[] objetos;
    // public Stack<GameObject> movil2 = new Stack<GameObject>();
    public List<GameObject> movil = new List<GameObject>(); 
    
    
    byte fin = 1;


    // public Stack<string> numbers = new Stack<string>();
    // public string[] merca;

    
    public static class compartido
    {
        public static byte limite = 0;
        public static float tiempo = 0;
        public static float tiempoMaestro = 0;

    }

    void agrObjetos(GameObject[] array, List<GameObject> lista)
    {
        foreach( GameObject objeto in array )
        {
            lista.Add(objeto);   
        }
    }

    private int contar(List<GameObject>  lista){

        int total = 0;

        foreach( GameObject objeto in lista )
        {
            total += 1;
        }

        return (total);
    }

    void instanciar(){

    ////// ARRANCAR VARIABLES   
        //puntos
        int valorPosicion = contar(puntosUsados)-1;
        //objetos
        int nObjeto = contar(movil)-1;


        if (valorPosicion == -1)
        {
            agrObjetos(puntos, puntosUsados);
            valorPosicion = Random.Range(0, contar(movil));
        }
         if (nObjeto == -1)
        {
            agrObjetos(objetos, movil);
            nObjeto = Random.Range(0, contar(movil));
        }

        nObjeto = Random.Range(0, contar(movil));

        Debug.Log(nObjeto);


    ////// INSTANCIAR OBJETOS
        Instantiate(movil[nObjeto],puntos[valorPosicion].transform.position,puntos[valorPosicion].transform.rotation);
        
    ////// BORRAR SOBRANTES

        movil.Remove(movil[nObjeto]);
        puntosUsados.Remove(puntosUsados[valorPosicion]);


    }

    void Start()
    {
        agrObjetos(objetos, movil);
        agrObjetos(puntos, puntosUsados);
    }

    void Update()
    {
        compartido.tiempo += Time.deltaTime;

        if (compartido.tiempo >= fin && compartido.limite < 5)
        {
            compartido.tiempo = 0;
            instanciar();
            compartido.limite += 1;
        }

        if (compartido.tiempoMaestro < 6);
        {
            compartido.tiempoMaestro += Time.deltaTime;
        }
    }   
}
