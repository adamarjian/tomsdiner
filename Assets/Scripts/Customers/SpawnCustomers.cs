using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCustomers : MonoBehaviour
{

    public bool canSpawn;

    [SerializeField]
    private float spawnTimer = 10.0f;

    [SerializeField]
    private float spawnTimeModifier;

    [SerializeField]
    private GameObject customer;

    [SerializeField]
    private LayerMask whatIsCustomer;

    private float currentSpawnTimer;

    // Start is called before the first frame update
    void Start()
    {

        currentSpawnTimer = spawnTimer;

    }

    // Update is called once per frame
    void Update()
    {
        if (canSpawn && currentSpawnTimer < 0)
        {

            SpawnCustomer();

            // Add total spawned customers
            KitchenGameManager.totalSpawnedCustomers++;

            // With each successive spawn, their is a chance that the spawn timer will go faster
            spawnTimer -= spawnTimeModifier * Random.Range(0, 1);
            currentSpawnTimer = spawnTimer;

        }
        else
        {

            currentSpawnTimer -= Time.deltaTime;

        }

    }

    public void SpawnCustomer()
    {

        GameObject newCustomer = Instantiate(customer, transform.position, Quaternion.identity);

    }

}
