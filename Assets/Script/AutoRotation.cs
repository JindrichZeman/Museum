using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotation : MonoBehaviour
{
    public float angularSpeed = 100.0f;
    public float heading = 0.0f;

    void start() {
        heading = 0;        
    }

    void Update() {
        heading += angularSpeed * Time.deltaTime;
        this.transform.eulerAngles = new Vector3(this.transform.eulerAngles.x, heading, this.transform.eulerAngles.z);
    }
}
