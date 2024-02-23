using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Character
{
 
    public string name;
    private int healthPoints = 1;


    public Character(string name)
    {
        this.name = name;
        //OnKilled += killed;
        Debug.Log("Hola, soy " + name);
    }
    
    ~Character()
    {
        Debug.Log("Destroyed.");
    }

    public int HealthPoints { get => healthPoints; set => healthPoints = value; }

}