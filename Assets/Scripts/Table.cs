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

    [SerializeField]
    private int maxOrders;

    [SerializeField]
    private Order currentOrder;

    [SerializeField]
    private Customer currentCustomer;

    [SerializeField]
    private TableState currentTableState;

    // Start is called before the first frame update
    void Start()
    {
        
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

                    break;
                }
            case TableState.BILLING:
                {


                    break;
                }
            case TableState.CLEANUP:
                {


                    break;
                }

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

    public void ServeFood()
    {


        
    }

}
