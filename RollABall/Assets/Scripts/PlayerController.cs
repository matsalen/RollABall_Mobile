﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float velocidade;

    private Rigidbody rb;
    private Vector3 forca;
    private Vector3 movimento;
    private float movimentoX;
    private float movimentoY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        forca = Vector3.zero;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //movimentoX = Input.GetAxis("Horizontal");
        movimentoY = Input.GetAxis("Vertical");

        //movimento = Input.acceleration;
        forca = new Vector3(movimentoX, 0, movimentoY);

        //forca.x = movimento.x;
        //forca.z = movimento.y;
        forca *= velocidade;
        rb.AddForce(forca);
    }
}
