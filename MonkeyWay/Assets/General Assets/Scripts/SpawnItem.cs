using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public GameObject itemPrefab;
    public float spawnTime = 1.0f;
    private Vector2 screenBounds;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,
         Screen.height, Camera.main.transform.position.z));
         StartCoroutine(itemGenerate());
    }

    private void spawnItem() {
        GameObject a = Instantiate(itemPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x,screenBounds.x), 0);
 
    }
    IEnumerator itemGenerate( ) {
        while(true) {
            yield return new WaitForSeconds(spawnTime);
            spawnItem();
        }
    }
}
