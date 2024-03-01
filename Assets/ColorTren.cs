using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorTren : MonoBehaviour
{

    [SerializeField]

    GameObject[] gameObj;
    public bool FindByTag;
    public string ChosenTag;
    public Color DesiredColor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        colorChange();
    }

    private void colorChange()
    {
        if (FindByTag == true)
        {
            gameObj = GameObject.FindGameObjectsWithTag(ChosenTag);
            for (int i = 0; i < gameObj.Length; i++)
            {
                gameObj[i].GetComponent<MeshRenderer>().material.color = DesiredColor;
            }
        }
    }
}

