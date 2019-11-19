using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpH : MonoBehaviour
{
    // Code done by Rohith Maddali

    public float health = 30f;
    public bool picked = false;
    public Spawner spawn;
    

    void OnTriggerEnter(Collider col)
    {
        
        //if the player health is less than 100, the player will be able to pick it up.
        if (col.gameObject.tag == "Player 1" || col.gameObject.tag == "Player 2")
        {
            GameObject player = col.gameObject;
            //checks if the player is eligible for pick up
            if (player.GetComponent<playerStats>().health < 100)
            {
                
                Debug.Log("picked up");
                player.GetComponent<playerStats>().health += 30f;
                des();
                spawn.picked = true;
            }


            else
            {
                Debug.Log("health is full");
            }

        }

    }


    void des()
    {
        //destroys the game object once its picked up.
        Destroy(gameObject);        
    }
        
}
