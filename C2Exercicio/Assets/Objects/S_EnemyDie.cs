using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_EnemyDie : MonoBehaviour
{
    // Start is called before the first frame update
    /* void Start()
     {
         StartCoroutine(IEnumerator Die);
     }



     private IEnumerator Die()
     {
         WaitForSeconds(3);
         DestroyEnemy();
     }

     private void DestroyEnemy()
     {
         Destroy(gameObject);
     }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

}
