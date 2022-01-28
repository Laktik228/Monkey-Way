using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Generation : MonoBehaviour
{
    [SerializeField] private Transform platform;
    private float rightEdgeX;
    private float rightEdgeY;
    // Start is called before the first frame update
    void Start()
    {
        rightEdgeX = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth, 0, 0)).x;
        InvokeRepeating("SpawnPlatform", 2.0f, 5.0f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPlatform(){
        //TODO Make it adjustable to the ground
        Instantiate(platform, new Vector3(rightEdgeX + Random.Range(5, 10), Random.Range(1, 7), 0.0f), Quaternion.identity);
    }
}
