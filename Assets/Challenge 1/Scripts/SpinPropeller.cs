using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    private float rotateSpeed = 1200.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotateSpeed);
    }
}
