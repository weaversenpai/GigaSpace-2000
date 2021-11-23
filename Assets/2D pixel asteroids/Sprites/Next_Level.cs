using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next_Level : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter(Collider other)
     {
         if (other.tag == "Player")
         {
             SceneManager.LoadScene("Level 2"); // loads scene When player enter the trigger collider
         }
     }
}
