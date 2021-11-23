using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Health : MonoBehaviour

{

    public int Health;
    public float DamageCooldown;
    public GameObject deathEffect;
    public GameObject hitEffect;
    private GameObject StatusText;
    public GameObject HealthUI;

    private string CollisionTag;

    void Start()
    {
        CollisionTag = "Enemy";

    }
    private void OnCollisionEnter2D(Collision2D collisionObject)
    {

        if (collisionObject.gameObject.CompareTag(CollisionTag))
        {
            Health -= 1;
            CollisionTag = "Banana";
            Debug.Log("Player Health is now" + Health);
            GameObject hitEffects = Instantiate(hitEffect, this.transform.position, this.transform.rotation);
            hitEffects.transform.SetParent(this.transform);
            Destroy(hitEffects, 3);
            Transform child = HealthUI.transform.GetChild(Health);
            child.gameObject.SetActive(false);
            StartCoroutine(NoDamageWaiter());
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
        StatusText = GameObject.FindGameObjectWithTag("Status");
        StatusText.GetComponent<Status>().Text_Changing(3);

    }
     IEnumerator NoDamageWaiter()
    {
        yield return new WaitForSeconds(2);
        CollisionTag = "Enemy";
        yield return null;
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