using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public int speed;
    public GameObject flashlight;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        flashlight = GameObject.Find("FlashLight");
    }

    // Update is called once per frame
    void Update()
    {
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        rb.AddForce(movement * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (flashlight.activeSelf)
            {
                flashlight.SetActive(false);
            } else
            {
                flashlight.SetActive(true);
            }
        }
    }
}
