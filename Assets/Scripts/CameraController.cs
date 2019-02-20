using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject player;       //Public variable to store a reference to the player game object

    private void Update()
    {
        transform.LookAt(player.transform.position);
    }
}