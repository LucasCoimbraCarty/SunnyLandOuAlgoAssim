using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public string nome = "Cleide";
    private int vida = 3;
    private float velocidade = 2.5f;
    private bool vivo = true;
    private Rigidbody2D rb;
    public int novaGravidade = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = novaGravidade;
        //Debug.Log("O jogo começou:\n" + nome + " é seu nome \n" + vida + " vidas\n" + velocidade + " velocidade\n" + vivo + " Ele está vivo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
