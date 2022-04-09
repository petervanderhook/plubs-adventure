using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{   
    public int time_to_wait;
    MeshRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        time_to_wait = Random.Range(3, 180);
        renderer = GetComponent<MeshRenderer>();

        renderer.enabled = false;
    }

    void DestroySelf()
    {
        Object.Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            DestroySelf();
        }
    }
    void Update()
    {
        if (Time.time > time_to_wait)
        {
            GetComponent<Rigidbody>().useGravity = true;
            renderer.enabled = true;
        }
        if (Time.time > (time_to_wait + 5))
        {
            DestroySelf();
        }
    }
}
