using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 150 * Time.deltaTime, 0f);
    }
}
