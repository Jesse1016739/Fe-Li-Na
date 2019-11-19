using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickWeapon : MonoBehaviour
{
    public Wspawner E;
    public Weapon W;

    public void OnTriggerEnter(Collider col)
    {
        
        if (col.gameObject.tag == "Player 1" || col.gameObject.tag == "Player 2")
        {
            
            W = col.gameObject.GetComponentInChildren<Weapon>();//GetComponent<Weapon>();
            //E = GetComponent<Wspawner>();
            Debug.Log("picked up!");
            //if (W != null)
            //{
            E.picked = true;
                W.spawnUpdate();
                Destroy(gameObject);
            //}
        }
    }

}
