using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConntroller : MonoBehaviour
{
     void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f,moveVertical);

        rigidbody.velocity = movement;
    }
}
