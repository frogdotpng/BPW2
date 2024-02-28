using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisMovement : MonoBehaviour
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
        xPos = this.transform.position.x;
        yPos = this.transform.position.y;

        rotatione = new Vector3(90, 180, 0) + (player.transform.rotation.eulerAngles*-1);

        this.gameObject.transform.position = new Vector3(xPos, yPos, playerPosition + zOffset);
        this.gameObject.transform.eulerAngles = rotatione;

    }
}
