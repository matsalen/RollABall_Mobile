using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = new Vector3(Input.acceleration.x, 0, -Input.acceleration.z);
        v *= 0.5f;
        transform.Translate(v);
    }
}
