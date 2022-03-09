using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeFall : MonoBehaviour
{
    void Update()
    {   
        Debug.Log(GetComponent<Transform>().rotation.z);
        if (GetComponent<Transform>().rotation.z < 0) {
            GetComponent<Rigidbody2D>().mass = 5;
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
        }
        
    }
}
