using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterSpot : MonoBehaviour
{
    [SerializeField]
    private MakeFood foodHolder;

    public GameObject readyItem;

    public bool set;

    // Update is called once per frame
    void Update()
    {
        set = foodHolder.ready;
        if (foodHolder.ready)
        {
            readyItem = foodHolder.food;
            foodHolder.ready = false;
        }
    }

     void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
