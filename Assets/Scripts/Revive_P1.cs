using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revive_P1 : MonoBehaviour
{
    //code done by Rohith Maddali
    public bool reviving = false;
    public int reviveTimer;
    
    
    public void OnTriggerEnter(Collider col)
    {
        //player enters the revive zone
        if (col.gameObject.tag == "Player 2")
        {
            //checks if the player is dead.
            if (GameObject.FindGameObjectWithTag("Player 1").GetComponent<playerStats>().health <= 0)
            {
                
                reviving = true;
                StartCoroutine(reviveP1Counter());
            }

        }
    }

    public void OnTriggerExit(Collider col)
    {
        //player exits the revive zone
        if (col.gameObject.tag == "Player 2")
        {
            StopCoroutine(reviveP1Counter());
            reviving = false;
            Debug.Log("revive failed");
        }
    }
    
   

    IEnumerator reviveP1Counter()
    {
        
        yield return new WaitForSeconds(reviveTimer);
        Debug.Log("revive player 1 successful");
        GameObject.FindGameObjectWithTag("Player 1").GetComponent<playerStats>().health = 50;


    }
}
