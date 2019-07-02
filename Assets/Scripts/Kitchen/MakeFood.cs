using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeFood : MonoBehaviour
{
    public bool ready;
    
    public Order foodToCook;

    public bool startCooking = false;

    private float cookingTime = 10;

    private SpriteRenderer kitchenSprite;

    private void Start()
    {
        kitchenSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //start cooking
        if (startCooking)
        {
            
            cookingTime -= Time.deltaTime;
            if (cookingTime<=0)
            {
                //food done
                ready = true;
                
                cookingTime = 10;
            }
        }

        //visual representation
        if (startCooking && !ready)
        {
            kitchenSprite.color = Color.red;
        }
        else if (startCooking && ready)
        {
            kitchenSprite.color = Color.green;
        }
        else
        {
            kitchenSprite.color = Color.white;
        }
    }
    
}
