using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosLogger : MonoBehaviour
{
    [SerializeField]
    private GameObject otherGameObject;
    public Vector3 posAnterior;
    // Start is called before the first frame update
    void Start()
    {
        otherGameObject = GameObject.Find("cubo");
    }

    // Update is called once per frame
    void Update()
    {
        //        if (otherGameObject.transform.position != otherGameObject)
        //        {
        //          Debug.Log("El objeto está en ", otherGameObject.transform.position);
        //          posAnterior = otherGameObject.transform.position;
        //        }

        if (otherGameObject.transform.position != posAnterior)
        {
            Debug.Log("El objeto está en " + otherGameObject.transform.position);
            posAnterior = otherGameObject.transform.position;
        }
    }
}
