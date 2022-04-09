    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityCollision : MonoBehaviour
{
    Color hit_color = new Color(0.345f, 0.180f, 0.113f, 1f);
    Color base_color = new Color(0.377f, 0.260f, 0.116f, 1.000f);
    float hit_time = 0;


    void Start()
    {
        Debug.Log("Hit Color: ");
        Debug.Log(hit_color);
        Debug.Log("Base Color: ");
        Debug.Log(base_color);
        Debug.Log("Current Color: ");
        Debug.Log(GetComponent<MeshRenderer>().material.color);
        GetComponent<MeshRenderer>().material.color = base_color;
    }
    void Update()
    {
        if (gameObject.tag == "Hit")
        {
            if ((Time.time - hit_time)  > 3)
            {
                GetComponent<MeshRenderer>().material.SetColor("_Color", base_color);
                gameObject.tag = "Obstacle";
            }
        }

    }
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Player")
        {
            if(gameObject.tag != "Hit")
            {
                GetComponent<MeshRenderer>().material.color = hit_color;
                hit_time = Time.time;
                gameObject.tag = "Hit";
            }
        }
        
    }
}
