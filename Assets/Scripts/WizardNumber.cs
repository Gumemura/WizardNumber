﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardNumber : MonoBehaviour
{
    int maximo = 1000;
    int minimo = 0;
    bool comecar = false;
    bool acerto = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Pensar num número de " + minimo + " a " + maximo);
        Debug.Log("Te darei um número. Seta para cima se seu número for maior, seta para baixo se menor, ou enter se for o número");
        Debug.Log("Já pensou num número? (s/n)");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            comecar = true;
            Debug.Log((maximo + minimo) / 2);
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            Debug.Log("Pensa logo!");
        }

        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            acerto = true;
        }

        while (comecar == true & acerto == false)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                
            }
            if(Input.GetKeyDown(KeyCode.DownArrow))
            {
                
            }
        }

        if (acerto == true)
        {

        }
    }
}