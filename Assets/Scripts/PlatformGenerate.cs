using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerate : MonoBehaviour
{
    public GameObject platformPrefab;
    void Start()
    {
        Vector3 spawnerPositon = new Vector3();
        for (int i=0;i<10; i++)
        {
            spawnerPositon.x = Random.Range(-2.55f, 2.60f);
            spawnerPositon.y += Random.Range(0.5f, 2.0f);
            Instantiate(platformPrefab, spawnerPositon, Quaternion.identity);
        }
    }

   
    void Update()
    {
        
    }
}
