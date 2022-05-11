using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PegaItem : MonoBehaviour
{
    public int pontuacao;
    public Text contadorPontuacao;

    private void Update() {
        contadorPontuacao.text = "x " + pontuacao.ToString();
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Moeda") {
            pontuacao += 10;
            Destroy(collision.gameObject);
        }
    }
}
