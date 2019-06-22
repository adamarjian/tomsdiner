using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointClick : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private Transform placement;

    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.Find("Player");


    }

    public void PlayerPlace()
    {
        Debug.Log("clicked");
        player.transform.position = placement.position;
    }
}
