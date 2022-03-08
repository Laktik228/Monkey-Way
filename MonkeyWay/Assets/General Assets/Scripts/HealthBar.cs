using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    
    public Health playerHealth;
    public Image totalHealthBar;
    public Image currentHealthbar;

     
    
    private void Start()
    {
        totalHealthBar.fillAmount = playerHealth.currentHealth / 10;
    }


    private void Update()
    {
        currentHealthbar.fillAmount = playerHealth.currentHealth / 10;
    }
}
