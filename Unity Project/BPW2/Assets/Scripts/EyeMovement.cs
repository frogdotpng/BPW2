using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeMovement : MonoBehaviour
{
    public GameObject player;

    [SerializeField] private float zOffset;

    private float playerPosition;
    private float xPos;
    private float yPos;

    private Vector3 rotatione;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = player.transform.position.z;
        xPos = player.transform.position.x;
        yPos = transform.position.y;


        //rotatione = new Vector3(90, 180, 0) + (player.transform.rotation.eulerAngles * -1);

        transform.position = new Vector3(xPos, yPos, playerPosition + zOffset);
        //transform.eulerAngles = rotatione;

    }
}
