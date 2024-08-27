using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public int velocidade;
    public int vida;
    public int forçaPulo;
    private Rigidbody2D rb;
    public float moveH;
    public float moveV;
    public bool isJumping = false;
    private Vector3 posInicial;

    // Start is called before the first frame update
    void Start()
    {
        posInicial = transform.position;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        //andar
        moveH = Input.GetAxis("Horizontal");
        transform.position += new Vector3(moveH * velocidade * Time.deltaTime, 0, 0);

        //pular
        if(Input.GetKeyDown(KeyCode.Space) && !isJumping);
        {
            rb.AddForce(transform.up * forçaPulo,ForceMode2D.Impulse);
            isJumping = true;
        }
    }
}