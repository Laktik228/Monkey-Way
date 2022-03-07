using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseLife : MonoBehaviour
{
    public void LifeLose(){
        GetComponent<Renderer>().enabled=false;
    }
}
