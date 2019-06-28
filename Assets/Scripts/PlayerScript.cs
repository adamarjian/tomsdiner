using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerScript : MonoBehaviour
{
    public Transform placeToMove;

    public AIDestinationSetter set;

    private void Start()
    {
        set = GetComponent<AIDestinationSetter>();
    }
    // Update is called once per frame
    void Update()
    {
        //move to clicked object
        if (Input.GetMouseButtonUp(0))
        {
            set.target = placeToMove;
        }
       
    }
}
