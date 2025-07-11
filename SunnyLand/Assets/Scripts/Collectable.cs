using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectable : MonoBehaviour
{
    public TMP_Text texto_pontos;
    public ParticleSystem efeito;

    int pontos = 0;
    private void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.CompareTag("Player"))
        {
           pontos++;
           texto_pontos.text = "Pontos: " + pontos.ToString();
            colisao.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            Instantiate(efeito, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
