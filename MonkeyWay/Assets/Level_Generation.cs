using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
        int numberToSpawn = Random.Range(1, 5);
        List<int> itemPositionX = new List<int>();
        List<int> itemPositionY = new List<int>();
        foreach(int i in Enumerable.Range(1, numberToSpawn)){
            int posX = (int)rightEdgeX + Random.Range(5, 10);
            int posY = Random.Range(-2, 3);
            
            while(itemPositionX.Contains(posX)){
                posX = (int)rightEdgeX + Random.Range(5, 10);
            }
            itemPositionX.Add(posX);

            while(itemPositionY.Contains(posY)){
                posY = Random.Range(-2, 3);
            }
            itemPositionY.Add(posY);

            Instantiate(platform, new Vector3(posX, posY, 0.0f), Quaternion.identity);
        }   
    }
}
