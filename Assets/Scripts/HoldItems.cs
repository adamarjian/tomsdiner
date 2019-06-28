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
            if (!hold1.GetComponent<HolderScript>().hasItem)
            {

                hold1.GetComponent<HolderScript>().hasItem = true;
            }
            else if (!hold2.GetComponent<HolderScript>().hasItem)
            {
                hold2.GetComponent<HolderScript>().hasItem = true;
            }
        }
        else
        {

        }
    }

}
