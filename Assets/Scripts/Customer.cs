using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{

    // This value should be predefined and read from a game manager
    public int MaxPossibleCustomers;

    // Total number of customers in these customer group
    public int totalCustomersInGroup;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateRandomCustomer()
    {

        // Generate a random number of customers in this group
        System.Random randomizer = new System.Random();
        totalCustomersInGroup = randomizer.Next(1, MaxPossibleCustomers);

    }

}
