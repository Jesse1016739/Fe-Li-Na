using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    //Values
    private Vector3 startingPosition;
    [SerializeField]
    private Vector3 newPosition;
    [SerializeField]
    private float distBetweenPlayers;
    public float maxHeight;
    private GameObject player1;
    private GameObject player2;


    // Start is called before the first frame update
    void Start()
    {
        //store initial position data
        startingPosition = transform.position;
        player1 = GameObject.FindGameObjectWithTag("Player1");
        player2 = GameObject.FindGameObjectWithTag("Player2");
    }

    // Update is called once per frame
    void Update()
    {
        //Get Distance between players
        distBetweenPlayers = Vector3.Distance(player1.transform.position, player2.transform.position);
        //adjust camera height relative to distance
        //newPosition = transform.position;
        newPosition.y += distBetweenPlayers / maxHeight;
        newPosition.y = Mathf.Lerp(startingPosition.y, maxHeight, distBetweenPlayers / maxHeight);
        transform.position = new Vector3(transform.position.x, newPosition.y, transform.position.z);
    }
}
