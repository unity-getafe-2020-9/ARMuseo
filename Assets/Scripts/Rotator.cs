using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    
    void Update()
    {
        transform.Rotate(Time.deltaTime * 10, Time.deltaTime * 10, Time.deltaTime * 10);
    }
}
