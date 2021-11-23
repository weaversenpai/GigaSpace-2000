using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Health : MonoBehaviour

{

    public int Health;
    public float DamageCooldown;
    public float TimePassed = 0.0f;
    public GameObject deathEffect;
    public GameObject hitEffect;
    
    public GameObject HealthUI;

    void Start()
    {


    }
    private void OnTriggerEnter2D(Collider2D collisionObject)
    {
        TimePassed += Time.deltaTime * 30f;
        Debug.Log("Trigger was entered, time is " + TimePassed);
        if (collisionObject.gameObject.CompareTag("Enemy") && TimePassed > DamageCooldown)
        {
            Health -= 1;
            Debug.Log("Player Health is now" + Health);
            GameObject hitEffects = Instantiate(hitEffect, this.transform.position, this.transform.rotation);
            hitEffects.transform.SetParent(this.transform);
            Destroy(hitEffects, 3);
            TimePassed = 0;
            Transform child = HealthUI.transform.GetChild(Health);
            child.gameObject.SetActive(false);
        }

    }

    void Update()
    {

        if (Health < 1)
        {
            Die();
        } 
    }
    
    
    public void Die()
    {
        GameObject deathEffects = Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(deathEffects, 3);
        Destroy(gameObject);

    }
  }

  /*      
        if (Health > numOfHearts)
        {
            Health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < Health)
            {
                hearts[i].sprite = fullHeart;
            }

            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }

            else
            {
                hearts[i].enabled = false;
            }
        }
    }*/