﻿using UnityEngine;
using System.Collections;

namespace CompleteProject
{
    public class EnemyMovement : MonoBehaviour
    {
        Transform player;               // Reference to the player's position.
        UnityEngine.AI.NavMeshAgent nav;               // Reference to the nav mesh agent.
        CompleteProject.EnemyHealth enemyHealth;

        void Awake ()
        {
            player = GameObject.FindGameObjectWithTag ("Player").transform;
            nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
            enemyHealth = GetComponent<CompleteProject.EnemyHealth>();
        }


        void Update ()
        {
            // If the enemy and the player have health left...
            if(enemyHealth.currentHealth > 0 && Global.Avatar.HP > 0)
            {
                // ... set the destination of the nav mesh agent to the player.
                nav.SetDestination (player.position);
            }
            // Otherwise...
            else
            {
                // ... disable the nav mesh agent.
                nav.enabled = false;
            }
        }
    }
}