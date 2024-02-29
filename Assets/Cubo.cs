using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    private Transform transformacion;

    // Start is called before the first frame update
    void Start()
    {
        transformacion = this.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        LogPosition();
    }

    private void LogPosition()
    {
        Debug.LogFormat("LA TRANSOFRMACION DEL OBJ ES DE (0)", transformacion.localPosition.x);
        Debug.LogFormat("LA TRANSOFRMACION DEL OBJ ES DE (0)", transformacion.localPosition.y);
        Debug.LogFormat("LA TRANSOFRMACION DEL OBJ ES DE (0)", transformacion.localPosition.z);
    }
}
