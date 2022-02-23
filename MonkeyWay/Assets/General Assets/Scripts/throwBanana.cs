using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwBanana : MonoBehaviour
{

public Transform firePoint;

public GameObject banana;


Vector2 lookDirection;
float lookAngle;

    void Update()
    {
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - new Vector3(firePoint.transform.position.x, firePoint.transform.position.y);
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x)  * Mathf.Rad2Deg;

        firePoint.rotation = Quaternion.Euler(0, 0, lookAngle);


        if(Input.GetMouseButton(0)){
            GameObject b = Instantiate(banana);
            b.transform.position = firePoint.position;
            b.transform.rotation = Quaternion.Euler(0, 0, lookAngle);
            b.GetComponent<Rigidbody2D>().velocity = firePoint.right * 20f;

        }
    }
}
