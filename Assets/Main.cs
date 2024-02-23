using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    Enemy enemy;
    void Start()
    {
        enemy = new Enemy("A");
        Player player = new Player("B");
    }

    void Update()
    {
        Debug.Log("Nombre: " + enemy.name + "; Vida: " + enemy.HealthPoints);
    }
}
