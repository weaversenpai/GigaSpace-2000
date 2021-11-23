using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player_Status : MonoBehaviour
{

    public int health = 5;

    public GameObject dmgScreenEffect;

    public GameObject deathEffect;

    public void TakeDamage(int damage)

    {
        health -= damage;

        var color = dmgScreenEffect.GetComponent<Image>().color;
        color.a = 0.7f;

        dmgScreenEffect.GetComponent<Image>().color = color;

        if (health <= 0)
        {
            Die();
        }

        void Die()
        {
            GameObject deathEffects = Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(deathEffects, 3);

        }
    }

    private void Update()
    {
        if (dmgScreenEffect.GetComponent<Image>().color.a > 0)
        {
            var color = dmgScreenEffect.GetComponent<Image>().color;
            color.a -= 0.01f;
            dmgScreenEffect.GetComponent<Image>().color = color;
        }
    }
}