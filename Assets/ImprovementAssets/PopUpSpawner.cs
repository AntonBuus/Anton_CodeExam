using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpSpawner : MonoBehaviour
{
    Rigidbody2D rb;

    public GameObject ObjectToSpawn;

    public Transform spawnPoint;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void SpawnObjectImproved()
    {
        Instantiate(ObjectToSpawn, spawnPoint.position, Quaternion.identity);
        //Destroy(this.gameObject);
    }
}
