using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Variables go here
    // [SerializeField] lets you change the value live during testing in unity env without changing the value in the script.
    [SerializeField] float y_speed = 0f;
    [SerializeField] float move_speed = 22f;
    // Start is called before the first frame update
    // Called once, when the object the script is linked to first exists in the 'void'
    void UpdateVelocity()
    { 
        float vel_x;
        float vel_z;
        Vector3 v3_velocity = GetComponent<Rigidbody>().velocity;
        if (v3_velocity.x > 0)
        {
            vel_x = (v3_velocity.x - (v3_velocity.x / 3));
        }
        else
        {
            vel_x = 0f;
        }
        if (v3_velocity.z > 0)
        {
            vel_z = (v3_velocity.z- (v3_velocity.z / 3));
        }
        else
        {
            vel_z = 0f;
        }
        GetComponent<Rigidbody>().velocity = new Vector3(vel_x, 0, vel_z);
    }

    void Start()

    {
    }

    // Update is called once per frame
    void Update()
    {   
        MovePlayer();
        UpdateVelocity();

    }
    
    void MovePlayer()
    {
        float x_speed = Input.GetAxis("Horizontal") * Time.deltaTime * move_speed;
        float z_speed = Input.GetAxis("Vertical" ) * Time.deltaTime * move_speed;
        transform.Translate(x_speed, y_speed, z_speed);
    }
}
