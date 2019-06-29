using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeFood : MonoBehaviour
{
    public bool ready;
    
    public Order foodToCook;

    public bool startCooking = false;

    private float cookingTime = 10;

    // Update is called once per frame
    void Update()
    {
        if (startCooking)
        {
            cookingTime -= Time.deltaTime;
            if (cookingTime<=0)
            {
                ready = true;
                cookingTime = 10;
            }
        }
    }
    
}
