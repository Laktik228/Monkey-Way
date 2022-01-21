using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSides : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject rightSide;
    [SerializeField] private GameObject leftSide;
    private float lastEndpoint;
    private void Awake()
    {
        lastEndpoint = rightSide.transform.GetChild(0).position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(lastEndpoint - transform.position.y < 2f){
            GameObject rightSideClone = Instantiate(rightSide, new Vector3(-23.125f,lastEndpoint, -10f), Quaternion.identity);
            Instantiate(leftSide, new Vector3(-25.45f,lastEndpoint, -10f), Quaternion.identity);
            lastEndpoint = rightSideClone.transform.GetChild(0).position.y;
        }
        
    }
}
