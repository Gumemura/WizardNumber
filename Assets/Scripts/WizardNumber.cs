using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardNumber : MonoBehaviour
{
    public int maximo = 1000;
    public int minimo = 0;
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
        int valorPrintado = (maximo + minimo) / 2;

        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            acerto = true;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                comecar = true;
                Debug.Log("Bora começar então. Tó o primeiro número:");
                Debug.Log(valorPrintado);
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.N))
                {
                    Debug.Log("Pensa logo!");
                }
            }
        }

        while (comecar && acerto == false)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Debug.Log((valorPrintado + maximo) / 2);
                valorPrintado = (valorPrintado + maximo) / 2;

                Debug.Log(valorPrintado);
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    Debug.Log((valorPrintado + minimo)/ 2);
                    valorPrintado = (valorPrintado + minimo) / 2;

                    Debug.Log(valorPrintado);
                }
            }
        }

        if (acerto)
        {
            Debug.Log("Seu número é " + valorPrintado + "!!!");
        }
    }
}
