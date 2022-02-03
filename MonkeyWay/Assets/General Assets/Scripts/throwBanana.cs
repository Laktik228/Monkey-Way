using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwBanana : MonoBehaviour
{

public Transform firePoint;

public GameObject banana;
public float bSpeed = 10f;

    void Update()
    {
        if(Input.GetMouseButton(0)){
            Instantiate(banana, firePoint.position, firePoint.rotation);
        }
    }
}
