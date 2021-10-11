using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PontuacaoFinal : MonoBehaviour
{
    public GameObject pontos;
    Pontos pontuacaoFinal;
    public Text PontuacaoGameOver;
    // Start is called before the first frame update
    void Start()
    {
        pontuacaoFinal = pontos.GetComponent<Pontos>();
    }

    // Update is called once per frame
    void Update()
    {
        PontuacaoGameOver = pontuacaoFinal.TextoPontuacao;
    }
}
