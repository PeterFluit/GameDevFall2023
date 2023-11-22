using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject laserPrefab; // Reference to your laser prefab

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Change input for mobile
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Assuming the firing point is the player's own transform
        Instantiate(laserPrefab, transform.position, transform.rotation);
    }
}
