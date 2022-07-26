using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillCollider : MonoBehaviour
{



    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.transform.CompareTag("Player"))
        {
            GameController.Instance.GameOver();
        }
    }
    
}
