using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingXAxis : MonoBehaviour
{
    public float spinRate = 10.0f;

    private void FixedUpdate()
    {
        this.transform.Rotate(new Vector3(0, 0, Time.deltaTime * spinRate));
    }
}
