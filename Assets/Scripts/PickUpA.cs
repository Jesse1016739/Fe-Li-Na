using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpA : MonoBehaviour
{
    public ASpawner aSpawner;
    public bool picked = false;


    public int ammoCount;

    void OnTriggerEnter(Collider col)
    {

        //if the player has less ammo, the player will be able to pick it up.
        if (col.gameObject.tag == "Player 1" || col.gameObject.tag == "Player 2")
        {
            GameObject player = col.gameObject;
            //checks if player is eligible to pick up the ammo block.
            if(player.GetComponent<playerStats>().curAmmo < player.GetComponent<playerStats>().maxAmmo)
            {
                
                aSpawner.picked = true;
                player.GetComponent<playerStats>().curAmmo += ammoCount;
                //checks if the player is picking up more than the max ammo that he can store in that weapon.
                if (player.GetComponent<playerStats>().curAmmo > player.GetComponent<playerStats>().maxAmmo)
                {
                    player.GetComponent<playerStats>().curAmmo = player.GetComponent<playerStats>().maxAmmo;
                }
                des();
            }
            else
            {
                Debug.Log("Ammo is full");
            }
        }
    }


    void des()
    {
        //destroys the game object once its picked up.
        Destroy(gameObject);
    }
}
