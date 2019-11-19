using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revive_P2 : MonoBehaviour
{
    //code done by Rohith Maddali
    public bool reviving = false;
    public int reviveTimer;
    int count = 0;

    public void OnTriggerEnter(Collider col)
    {
        //player enters the revive zone
        if (col.gameObject.tag == "Player 1")
        {
            //checks if the player is dead.
            if (GameObject.FindGameObjectWithTag("Player 2").GetComponent<playerStats>().health <= 0)
            {

                reviving = true;
                //if (Input.GetButtonDown("Fire1"))
                //{
                    StartCoroutine(reviveP2Counter());
                //}
            }

        }
    }

    public void OnTriggerExit(Collider col)
    {
        //player exits the revive zone
        if (col.gameObject.tag == "Player 1")
        {
            StopCoroutine(reviveP2Counter());
            reviving = false;
            Debug.Log("revive failed");
        }
    }



    IEnumerator reviveP2Counter()
    {

        yield return new WaitForSeconds(reviveTimer);
        Debug.Log("revive player 2 successful");
        GameObject.FindGameObjectWithTag("Player 2").GetComponent<playerStats>().health = 50;


    }
}
