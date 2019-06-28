using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolderScript : MonoBehaviour
{
    private LayerMask item;

    public bool hasItem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D itemCheck = Physics2D.OverlapCircle(transform.position, 1,item);
        if (itemCheck)
        {
            hasItem = false;
        }
        else
        {
            hasItem = true;
        }
    }
}
