using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    public float jumpForce = 10;
    // Update is called once per frame
    void Update()
    {
        // If the space bar is pressed down and the player is on the ground (not jumping or falling) then jump
        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(GetComponent<Rigidbody>().velocity.y) < 0.01f)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
