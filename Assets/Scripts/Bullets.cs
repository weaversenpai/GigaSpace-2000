using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{

   public GameObject hitEffect;
   public GameObject PlayerObject;


void OnCollisionEnter2D(Collision2D collision)
   {
       Debug.Log(collision.gameObject.tag);

       //Create SFX for hitting a target, then destroy ourselves
        GameObject Bullet = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(Bullet, 5f);
        Destroy(this.gameObject);

        //Determine whether we hit the enemy or not
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //Call on the TakeDamage function to deduct 1 point of health from the enemy
            collision.gameObject.GetComponent<Enemy_Health>().TakeDamage(1);
        }

   }

}