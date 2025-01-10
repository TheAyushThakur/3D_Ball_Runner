using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject ballSphere;
    private Vector3 distance;
    void Start()
    {
        distance = transform.position - ballSphere.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = distance + ballSphere.transform.position;
    }
}
