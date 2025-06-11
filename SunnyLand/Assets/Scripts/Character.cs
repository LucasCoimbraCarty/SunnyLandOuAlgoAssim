using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string nomePersonagem = "Personagem1";
    public int vidaInicial = 5;
    public float velocidadePersonagem = 2.5f;
    public bool isAlive = true;
    public Rigidbody2D rb;
    public float novaGravidade = 10;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Nome: \n" + nomePersonagem + "\n Vida: " + vidaInicial);
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = novaGravidade;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            print("Yes");
        }
    }
}
