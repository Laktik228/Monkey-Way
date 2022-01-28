using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerationJungle : MonoBehaviour
{
    [SerializeField] private Transform platform;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPlatform", 2.0f, 5.0f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPlatform(){
        Instantiate(platform, new Vector3(Random.Range(Camera.main.pixelWidth + 3.0f, 10.0f), Random.Range(0.0f + 3.0f, 5.0f), 0.0f), Quaternion.identity);
    }
}
