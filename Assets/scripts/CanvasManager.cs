using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{

    public TextMeshProUGUI txtSpeed;
    public PlayerMovement player;

    private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //        float speedKmh = playerRb.velocity.magnitude * 3.6f;
        float speedKmh = playerRb.velocity.magnitude;
        txtSpeed.text = "Speed: " + speedKmh.ToString("F2") + " m/s";
    }
}
