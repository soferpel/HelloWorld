using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class material : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<MeshRenderer>().material.color = Color.blue;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
