using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int health = 1004;
        float poisonDamage = 125.5f;

        poisonDamage = health - 125.5f;

        Debug.Log(health);
        Debug.Log(poisonDamage);

        poisonDamage = poisonDamage - 125.5f;
        Debug.Log(poisonDamage);

        poisonDamage = poisonDamage - 125.5f;
        Debug.Log(poisonDamage);

        poisonDamage = poisonDamage - 125.5f;
        Debug.Log(poisonDamage);

        poisonDamage = poisonDamage - 125.5f;
        Debug.Log(poisonDamage);

        poisonDamage = poisonDamage - 125.5f;
        Debug.Log(poisonDamage);

        poisonDamage = poisonDamage - 125.5f;
        Debug.Log(poisonDamage);

        poisonDamage = poisonDamage - 125.5f;
        Debug.Log(poisonDamage);

        Debug.Log("Player has been unalived!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
