﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    [SerializeField]
    private bool selected;

    private Vector2 startPos;

    private void Start()
    {
        startPos = transform.position;
    }
    private void Update()
    {
        if (selected)
        {
            Vector2 curserPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(curserPos.x, curserPos.y);
        }

        if (Input.GetMouseButtonUp(0))
        {
            selected = false;
            
        }
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            selected = true;
        } 
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Customer seated");
        collision.GetComponent<Table>().SeatTable(GetComponent<Customer>());
        Destroy(gameObject);
       
    }
}
