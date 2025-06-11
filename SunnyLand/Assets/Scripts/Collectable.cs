using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private int pontos = 1;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Pontos: \n" + pontos);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Its over!!");
    }
}
