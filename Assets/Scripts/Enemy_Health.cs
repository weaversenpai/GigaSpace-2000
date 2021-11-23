using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour
{
    //Set our HP
    public int health = 3;

    private GameObject Score;
    //AudioSource gethitSound;
    //Set SFX to be played on our death
    public GameObject deathEffect;
    void Start()
    {
        //gethitSound = GetComponent<AudioSource>();
    }


    //Function called externally to deal damage to us
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log(health);
        //gethitSound.Play();

        if (health <= 0)
        {
            Die();
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    
    //Play death SFX and destroy ourselves
    public void Die()
    {

        GameObject deathEffects = Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(deathEffects, 3);
        Destroy(gameObject);
        
        Score=GameObject.FindGameObjectWithTag("Score");
        Score.GetComponent<TMPro.Examples.Score_UI>().AddScore(1);

    }
       
}
