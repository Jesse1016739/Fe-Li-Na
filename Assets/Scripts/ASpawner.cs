using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASpawner : MonoBehaviour
{
    
    public GameObject ammo;
    

    public bool picked = false;
    public int timer;
    


    // Start is called before the first frame update
    void Start()
    {
        GameObject A = Instantiate(ammo, transform.position, transform.rotation);
        A.GetComponent<PickUpA>().aSpawner = this;
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(waitTime());
    }

    IEnumerator waitTime()
    {
        if(picked == true)
        {

            
            yield return new WaitForSeconds(timer);
            if (picked == true)
            {
                picked = false;
                GameObject A = Instantiate(ammo, transform.position, transform.rotation);
                A.GetComponent<PickUpA>().aSpawner = this;
                
            }
        }
    }
}
