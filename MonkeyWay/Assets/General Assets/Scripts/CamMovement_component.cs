using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement_component : MonoBehaviour
{
    private float minSpeed = 0.1f;
    private float maxSpeed = 5f;
    private float currentSpeed;
    private float time = 0;
    public float accelerationTime;  
    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = minSpeed;
    }

    // Update is called once per frame
    void Update()
    {   
        currentSpeed = Mathf.SmoothStep(minSpeed, maxSpeed, time / accelerationTime );
        transform.Translate(0,transform.up.y*currentSpeed*Time.deltaTime,0);
        time += Time.deltaTime;
    }
}
