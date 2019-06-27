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
        if (Input.GetMouseButton(0))
        {
            set.target = placeToMove;
        }
       
    }
}
