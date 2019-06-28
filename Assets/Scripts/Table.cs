using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TableState
{

    UNSEATED,
    SEATED,
    EATING,
    BILLING,
    CLEANUP

}

public class Table : MonoBehaviour
{

    // How long before customers order
    // Range from Minimum to Max
    private Vector2 orderTimer;

    // How long before customers finish eating
    // Range from Minimum to Max
    private Vector2 eatingTimer;

    // Max orders the table should handle
    [SerializeField]
    private int maxOrders;

    // Max customers this table can handle
    [SerializeField]
    private int maxCustomers;

    // Current running order
    [SerializeField]
    private Order currentOrder;

    // Current customer
    [SerializeField]
    private Customer currentCustomer;

    [SerializeField]
    private TableState currentTableState;

    // Need reference to a player field here

    // Start is called before the first frame update
    void Start()
    {

        // Grab reference of player now

        currentOrder = null;
        currentCustomer = null;
        currentTableState = TableState.UNSEATED;

    }

    // Update is called once per frame
    void Update()
    {

        StateProcessing();

    }

    //
    bool waiting;

    //
    float currentOrderTimer;
    float currentEatingTimer;

    public void StateProcessing()
    {

        // Frame by frame state executions
        switch (currentTableState)
        {

            case TableState.SEATED:
                {

                    if (!waiting)
                    {

                        // Create new food order
                        NewFoodOrder();

                        // Randomize new time
                        RandomizeTime();
 
                        // Start waiting
                        waiting = true;

                    }

                    currentOrderTimer -= Time.deltaTime;

                    if (waiting && currentOrderTimer < 0)
                    {

                        // Customer leave and stuff

                    }

                    break;
                }
            case TableState.EATING:
                {

                    currentEatingTimer -= Time.deltaTime;
                    
                    // Once customers are done eating switch to billing
                    if (currentEatingTimer < 0)
                    {

                        currentTableState = TableState.BILLING;

                    }

                    // Change customer animation to eating maybe


                    break;
                }
            case TableState.BILLING: break;
            case TableState.CLEANUP: break;

        }

    }

    public void NewFoodOrder()
    {

        // Randomizer
        System.Random randomizer = new System.Random();

        // Create a new order
        currentOrder = new Order(randomizer.Next(1, maxOrders));

    }

    public void RandomizeTime()
    {

        // New Randomized time
        currentOrderTimer = Random.Range(orderTimer.x, orderTimer.y);
        currentEatingTimer = Random.Range(eatingTimer.x, eatingTimer.y);

    }

    public void SeatTable(Customer newCustomers)
    {

        if (newCustomers.totalCustomersInGroup < maxCustomers)
        {

            currentTableState = TableState.SEATED;

        }
        else
        {

            // Penalty for seating

        }

    }

    public void BillTable()
    {

        // Process Billing logic here

        currentTableState = TableState.CLEANUP;

    }

    public void CleanUpTable()
    {

        // Reset table
        currentOrder = null;
        currentCustomer = null;
        currentTableState = TableState.UNSEATED;

    }

    public void ServeFood(FoodTypes ServedFood)
    {

        if (currentOrder.FoodOrders.Contains(ServedFood))
        {

            currentOrder.FoodOrders.Remove(ServedFood);

        }
        else
        {

            // Points lost logic
            // or time lost

        }

        
    }

}
