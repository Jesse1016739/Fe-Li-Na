using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    public GameObject pickup;
    public bool picked = false;
    public int timer;
    

    // Update is called once per frame
    void Start()
    {
        //spawns the pick up initially in the game 
        GameObject P = Instantiate(pickup, transform.position, transform.rotation);
        P.GetComponent<PickUpH>().spawn = this;

    }

    void Update()
    {
        StartCoroutine(waitTime());
    }  
    
    IEnumerator waitTime()
    {

        
        //checks if there is an existing pick up.
        if (picked == true)
        {
            picked = false;
            yield return new WaitForSeconds(timer);
            GameObject P = Instantiate(pickup, transform.position, transform.rotation);
            P.GetComponent<PickUpH>().spawn = this;
            
        }
    }
}
