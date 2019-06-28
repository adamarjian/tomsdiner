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
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<CounterSpot>().set)
        {
            if (hold1.GetComponent<HolderScript>().hasItem)
            {
                GameObject food1 = Instantiate(collision.GetComponent<CounterSpot>().readyItem, hold1.transform.position, Quaternion.identity);
                food1.name = collision.GetComponent<CounterSpot>().readyItem.name;
                food1.transform.position = hold1.transform.position;
            }
            else if (hold2.GetComponent<HolderScript>().hasItem)
            {
                GameObject food2 = Instantiate(collision.GetComponent<CounterSpot>().readyItem, hold2.transform.position, Quaternion.identity);
                food2.name = collision.GetComponent<CounterSpot>().readyItem.name;
                food2.transform.position = hold2.transform.position;
            }
        }
        else
        {

        }
    }

}
