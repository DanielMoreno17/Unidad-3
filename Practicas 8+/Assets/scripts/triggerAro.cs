using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class triggerAro : MonoBehaviour
{

    BoxCollider bx;
    [SerializeField] TextMeshProUGUI escudo;
    [SerializeField] TextMeshProUGUI nota;
    [SerializeField] TextMeshProUGUI arma;
    [SerializeField] TextMeshProUGUI corazon;
    int contadorEscudos = 0;
    int contadorCorazones = 0;
    int contadorArma = 0;
    int contadorNota = 0;

    private void Start()
    {
        bx = GetComponent<BoxCollider>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.name == "aroEscudo" && collision.gameObject.CompareTag("escudo"))
        {
            this.bx.isTrigger = true;
        }

        if (gameObject.name == "aroCorazon" && collision.gameObject.CompareTag("corazon"))
        {
            this.bx.isTrigger = true;   
        }
        if (gameObject.name == "aroArma" && collision.gameObject.CompareTag("arma"))
        {
            this.bx.isTrigger = true;
        }

        if (gameObject.name == "aroNota" && collision.gameObject.CompareTag("nota"))
        {
            this.bx.isTrigger = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.name == "aroEscudo" && other.gameObject.CompareTag("escudo"))
        {
            Destroy(other.gameObject, 3);
            contadorEscudos++;
            escudo.SetText("Escudos: " + contadorEscudos + "/5");
        }

        if (gameObject.name == "aroCorazon" && other.gameObject.CompareTag("corazon"))
        {
            Destroy(other.gameObject, 3);
            contadorCorazones++;
            corazon.SetText("Corazones: " + contadorCorazones + "/5");
        }
        if (gameObject.name == "aroArma" && other.gameObject.CompareTag("arma"))
        {
            Destroy(other.gameObject, 3);
            contadorArma++;
            arma.SetText("Armas: " + contadorArma + "/5");
        }

        if (gameObject.name == "aroNota" && other.gameObject.CompareTag("nota"))
        {
            Destroy(other.gameObject, 3);
            contadorNota++;
            nota.SetText("Notas: " + contadorNota + "/5");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (gameObject.name == "aroEscudo" && other.gameObject.CompareTag("escudo"))
        {
            this.bx.isTrigger = false;
        }

        if (gameObject.name == "aroCorazon" && other.gameObject.CompareTag("corazon"))
        {
            this.bx.isTrigger = false;
        }
        if (gameObject.name == "aroArma" && other.gameObject.CompareTag("arma"))
        {
            this.bx.isTrigger = false;

        }
        if (gameObject.name == "aroNota" && other.gameObject.CompareTag("nota"))
        {
            this.bx.isTrigger = false;

        }



    }
}
