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
    
    
    public void PlayerPlace()
    {
        Debug.Log("clicked");
        player.placeToMove = placement.transform.position;
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButton(0))
        {
            PlayerPlace();
        }
        
    }
}
