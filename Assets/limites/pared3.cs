using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pared3 : MonoBehaviour
{

    public GameObject XX;
    public GameObject ZZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(new Vector3(XX.transform.position.x,transform.position.y,ZZ.transform.position.z),new Vector3(transform.position.x,transform.position.y,transform.position.z), 0f);
    }
}
