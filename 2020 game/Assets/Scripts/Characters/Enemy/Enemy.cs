﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float maxHealth = 100f;
    public float health;

    public EnemyMovement controller;
    public Animator animator;

    void Start()
    {
        health = maxHealth;
        controller = gameObject.GetComponent<EnemyMovement>();
        animator = gameObject.GetComponent<Animator>();
    }

    public void takeDamage(float damage)
    {
        health -= damage;
        controller.status = 1;

        animator.SetTrigger("Hurt");

        if (health <= 0f)
        {
            die();
        }        
    }

    public void die()
    {
        // play death animation
        Debug.Log("You killed something");
        Destroy(gameObject);
    }

}
