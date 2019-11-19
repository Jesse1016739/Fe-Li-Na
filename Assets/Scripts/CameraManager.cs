using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    //code done by Trent
    // Start is called before the first frame update
    //values
    [SerializeField]
    private Vector3 startingPosition;
    [SerializeField]
    private Vector3 newPosition;
    [SerializeField]
    private float distBetweenPlayers;
    [SerializeField]
    public float maxHeight;

    private GameObject player1;
    private GameObject player2;

    public float panSpeed;

    void Start()
    {
        //store initial position of the camera.
        startingPosition = transform.position;
        player1 = GameObject.FindGameObjectWithTag("Player 1");
        player2 = GameObject.FindGameObjectWithTag("Player 2");
    }

    // Update is called once per frame
    void Update()
    {
        //get distance between the players.
        distBetweenPlayers = Vector3.Distance(player1.transform.position, player2.transform.position);
        //adjust the height based on distance.
        newPosition = transform.position;
        newPosition.y = Mathf.Lerp(startingPosition.y, maxHeight, (distBetweenPlayers / maxHeight) * panSpeed );
        transform.position = new Vector3(transform.position.x, newPosition.y, transform.position.z);

    }
}
