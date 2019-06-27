using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointClick : MonoBehaviour
{
    private PlayerScript player;
    [SerializeField]
    private GameObject placement;
    

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerScript>();
    }

    void OnMouseOver()
    {
        Debug.Log("Mouse over");
        if (Input.GetMouseButton(0))
        {
            PlayerPlace();
        }

    }

    public void PlayerPlace()
    {
        player.placeToMove = placement.transform;
    }

   
}
