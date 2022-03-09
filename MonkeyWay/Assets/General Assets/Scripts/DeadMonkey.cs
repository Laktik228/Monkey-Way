using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadMonkey : MonoBehaviour
{
    void Update()
    {
        if (GetComponent<Transform>().position.y < 0){
                SceneManager.LoadScene(2);
            }

    }
}
