using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] shipPrefabs;
    public int shipIndex;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomShip", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomShip()
    {
        Instantiate(shipPrefabs[shipIndex], new Vector3(Random.Range(-5, 5), 5, 13), shipPrefabs[shipIndex].transform.rotation);
    }
}
