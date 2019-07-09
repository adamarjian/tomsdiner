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
    [SerializeField]
    private Vector2 spawnPlace;

    // Start is called before the first frame update
    void Start()
    {

        currentSpawnTimer = spawnTimer;
        spawnPlace = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        Collider2D customerCheck = Physics2D.OverlapCircle(transform.position, 1, whatIsCustomer);
        if (customerCheck)
        {
            spawnPlace = transform.position;
        }

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

        GameObject newCustomer = Instantiate(customer, spawnPlace, Quaternion.identity);
        spawnPlace += new Vector2(-10, 0);
    }

}
