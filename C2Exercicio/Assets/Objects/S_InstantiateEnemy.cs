using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_InstantiateEnemy : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;

    [SerializeField] Vector2 horizontalSpawnRange;

    [SerializeField] Vector2 verticalPawnRange;

    Vector3 RandomInstantiation;

    Transform InstantiateHere;


    private void Start()
    {
      /* RandomInstantiation = Random.RandomRange(horizontalSpawnRange, verticalPawnRange, 0);

        //InstantiateHere = new Vector3(RandomInstantiation.x, RandomInstantiation.y, RandomInstantiation.z);

        Instantiate(enemyPrefab, RandomInstantiation);

        //StartCoroutine(SpawnEnemies);

        */
    }

    /*private IEnumerator SpawnEnemies()
    {
        
        WaitForSeconds(1).Instantiate(enemyPrefab;
    }*/

}
