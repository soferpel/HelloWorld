using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CuboMovimiento : MonoBehaviour
{
    float smooth = 5.0f;
    float tiltAngle = 60.0f;

    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        CreateCube();
    }

    private void CreateCube()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.SetParent(this.transform);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            position();
        }

        Movement3D();
        Scale();
        Rotation();

    }

    private void Rotation()
    {
        transform.rotation *= Quaternion.Euler(0 * speed, 1 * speed, 0 * speed);
    }

    private void Scale()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            this.transform.localScale += Vector3.right;

        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            this.transform.localScale += Vector3.left;

        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            this.transform.localScale += Vector3.up;

        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            this.transform.localScale += Vector3.down;

        }
    }

    private void Movement3D()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.transform.position += Vector3.up * speed;

        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.transform.position += Vector3.down * speed;

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.left * speed;

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.position += Vector3.right * speed;

        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            this.transform.position += Vector3.back * speed;

        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            this.transform.position += Vector3.forward * speed;

        }
    }

    private void position()
    {
        Debug.Log("Posicion x " + this.transform.position.x);
        Debug.Log("Posicion y " + this.transform.position.y);
        Debug.Log("Posicion z " + this.transform.position.z);
    }


}
