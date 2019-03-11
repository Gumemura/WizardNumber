using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardNumber : MonoBehaviour
{
    public int maximo = 1000;
    public int minimo = 0;
    int valorPrintado;

    void Start()
    {
        Debug.Log("Pensar num número de " + minimo + " a " + maximo);
        Debug.Log("Te darei um número. Seta para cima se seu número for maior, seta para baixo se menor, ou espaço se for o número");
        Debug.Log("Bora começa. Primeiro número:");
        valorPrintado = (maximo + minimo) / 2;
        Debug.Log(valorPrintado);
    }

    void Update()
    {
        bool acerto = false;
        bool comecar = true;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            acerto = true;
            comecar = false;
        }

        if((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow)) && acerto == false && comecar)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                minimo = valorPrintado;
                valorPrintado = (valorPrintado + maximo) / 2;
                Debug.Log(valorPrintado);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                maximo = valorPrintado;
                valorPrintado = (valorPrintado + minimo) / 2;
                Debug.Log(valorPrintado);
            }
        }

        else if (acerto)
        {
            Debug.Log("Seu número é " + valorPrintado + "!!!");
            acerto = false;
            comecar = false;
        }
    }
}
