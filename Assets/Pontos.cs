using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Pontos : MonoBehaviour
{
    private int pontos =0;
    public Text TextoPontuacao;
    void Start()
    {
        void OnCollisionEnter2D(Collision2D bolinha)
    { 
        if(bolinha.gameObject.name == "ParedeEsquerda"){
            pontos ++;
    }
    }

    // Update is called once per frame
    void Update()
    {
        TextoPontuacao.text = pontos.ToString();
    }
}
    }
