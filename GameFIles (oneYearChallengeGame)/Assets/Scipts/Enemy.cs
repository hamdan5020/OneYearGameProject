using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed; // the speed of this enemy
    [SerializeField] int damage; // the damage this enemy inflects on player
    [SerializeField] int health; // the health of this enemy
    [SerializeField] int scoreVal; // the score the player gets upon killing this enemy

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DamageEnemy(int damage)
    {
        health -= damage;
    }




}
