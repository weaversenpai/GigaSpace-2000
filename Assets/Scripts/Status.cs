using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Status : MonoBehaviour
{
    Text UI_Status;


    // Start is called before the first frame update
    void Start()
    {
        UI_Status = gameObject.GetComponent<Text>();

        Text_Changing(1);

    }

    // Update is called once per frame
    void Update()
    {








    }

    public void Text_Changing(int TextValue)
    {
        Debug.Log(TextValue);

        if (TextValue == 1)
        {
            UI_Status.text = "KILL 50 ENEMIES!";
            StartCoroutine(Text_Mode(0));

        }

        if (TextValue == 2)
        {
            UI_Status.text = "THE PORTAL IS OPEN!";
            StartCoroutine(Text_Mode(1));

        }

        if (TextValue == 3)

        {

            UI_Status.text = "YOU DIED, BRO! OH NO!";
    	    StartCoroutine(Text_Mode(2));
        }
    }

    IEnumerator Text_Mode(int Blah)
    {   
        yield return new WaitForSeconds(5);
        UI_Status.text = "";
        
        if (Blah == 1)
        {
            UI_Status.text = "PROCEED TO THE NEXT AREA!";
            yield return new WaitForSeconds(5);
            UI_Status.text = "";

        }

        if (Blah == 2)
        {            
        SceneManager.LoadScene("Level 1");
        }
        
        yield return null;

    }

}
