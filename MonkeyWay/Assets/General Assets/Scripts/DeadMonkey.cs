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

        if (GetComponent<Health>().currentHealth <= 0)
        {
            SceneManager.LoadScene(2);
        }

        if (GetComponent<Transform>().position.x >= 312){
                SceneManager.LoadScene(2);
            }

    }
}
