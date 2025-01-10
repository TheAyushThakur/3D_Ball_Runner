using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingCoins : MonoBehaviour
{

    Vector3 turnCoins;
    // Update is called once per frame
    void Update()
    {
        turnCoins = new Vector3(100, 0, 0);
        transform.Rotate(turnCoins*Time.deltaTime);
    }
}
