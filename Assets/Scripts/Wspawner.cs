using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wspawner : MonoBehaviour
{
    public GameObject weapon;


    public bool picked = false;
    public int timer;
    public Weapon W;



    // Start is called before the first frame update
    void Start()
    {
        GameObject A = Instantiate(weapon, transform.position, transform.rotation);
        A.GetComponent<PickWeapon>().E = this;
       

    }

    void Update()
    {
        StartCoroutine(waitTime());
    }

    IEnumerator waitTime()
    {
        if (picked == true)
        {

            picked = false;
            yield return new WaitForSeconds(timer);
            GameObject A = Instantiate(weapon, transform.position, transform.rotation);
            A.GetComponent<PickWeapon>().E = this;
            Debug.Log("Please die");
        }
    
    }
}
