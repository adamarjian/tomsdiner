using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterSpot : MonoBehaviour
{
    [SerializeField]
    private MakeFood foodHolder;

    public GameObject readyItem;

    

    // Update is called once per frame
    void Update()
    {
        if (foodHolder.ready)
        {
            readyItem = foodHolder.food;
            foodHolder.ready = false;
        }
    }
}
