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

    public List<Order> readyOrders;

   
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Table" && readyOrders[0]==null)
        {
            orderHolder.Add(collision.GetComponent<Table>().currentOrder);

        }
        else if (collision.gameObject.tag == "Kitchen" && !collision.GetComponent<MakeFood>().ready)
        {
            if (orderHolder!=null)
            {
                MakeFood kitchen = collision.GetComponent<MakeFood>();
                kitchen.foodToCook = orderHolder[0];
                orderHolder.Remove(orderHolder[0]);
                kitchen.startCooking = true;
            }
            
        }
        else if (collision.gameObject.tag == "Kitchen" && collision.GetComponent<MakeFood>().ready)
        {
            readyOrders[0] = collision.GetComponent<MakeFood>().foodToCook;
            collision.GetComponent<MakeFood>().ready = false;
            collision.GetComponent<MakeFood>().foodToCook = null;
        }
        else if (collision.gameObject.tag == "Table" && readyOrders != null)
        {
            collision.GetComponent<Table>().ServeFood(readyOrders[0].FoodOrders);
        }


    }

}
