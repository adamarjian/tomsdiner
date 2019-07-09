using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HoldItems : MonoBehaviour
{
    [SerializeField]
    private GameObject hold1;
    [SerializeField]
    private GameObject hold2;

    public List<Order> orderHolder;

    public FoodTypes readyOrder;

    [SerializeField]
    private bool removeOrder;

    void OnTriggerEnter2D(Collider2D collision)
    {
        string tagCheck = collision.gameObject.tag;
        switch (tagCheck)
        {
            case "Table":
                if (collision.GetComponent<Table>().currentTableState == TableState.SEATED && !collision.GetComponent<Table>().orderGotten)
                {
                    orderHolder.Add(collision.GetComponent<Table>().currentOrder);
                    collision.GetComponent<Table>().orderGotten = true;

                }
                else if (collision.GetComponent<Table>().currentTableState == TableState.SEATED && collision.GetComponent<Table>().orderGotten)
                {
                    if (removeOrder)
                    {
                        collision.GetComponent<Table>().ServeFood(readyOrder);
                        removeOrder = false;
                    }

                }
                else if (collision.GetComponent<Table>().currentTableState == TableState.BILLING)
                {
                    collision.GetComponent<Table>().BillTable();
                }
                else if (collision.GetComponent<Table>().currentTableState == TableState.CLEANUP)
                {
                    collision.GetComponent<Table>().CleanUpTable();
                }
                break;
            case "Kitchen":
                if (!collision.GetComponent<MakeFood>().ready && !removeOrder)
                {

                    MakeFood kitchen = collision.GetComponent<MakeFood>();
                    kitchen.foodToCook = orderHolder[0].FoodOrders[0];
                    orderHolder.Remove(orderHolder[0]);
                    kitchen.startCooking = true;
                    removeOrder = false;

                }
                else if (collision.GetComponent<MakeFood>().ready)
                {
                    readyOrder=collision.GetComponent<MakeFood>().foodToCook;
                    collision.GetComponent<MakeFood>().ready = false;
                    collision.GetComponent<MakeFood>().startCooking = false;
                    removeOrder = true;
                }
                break;
            default:
                break;
        }
        


    }

}
