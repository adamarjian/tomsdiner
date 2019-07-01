using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCustomers : MonoBehaviour
{
    [SerializeField]
    private GameObject customer;
    [SerializeField]
    private LayerMask whatIsCustomer;

    private bool spawned = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D checkCustomer = Physics2D.OverlapCircle(transform.position, 1, whatIsCustomer);
        if (!checkCustomer)
        {
            if (!spawned)
            {
                StartCoroutine(WaitForCustomer());
                spawned = true;
            }
        }
        else
        {
            spawned = false;
        }
    }

    IEnumerator WaitForCustomer()
    {
        yield return new WaitForSeconds(10f);
        GameObject newCustomer = Instantiate(customer, transform.position, Quaternion.identity);
    }

}
