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
    private Vector2 olrderTimer;

    // How long before customers finish eating
    // Range from Minimum to Max
    private Vector2 eatingTimer;

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
        
    }

    float Timer;

    float currentOrderTimer;
    float currentEatingTimer;

    public void StateProcessing()
    {

        switch (currentTableState)
        {

            case TableState.SEATED:
                {

                    
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



    }

}
