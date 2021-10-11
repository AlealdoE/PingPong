using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BolaScript : MonoBehaviour
{
    
    private Rigidbody2D rb;
    public Text TextoPontuacao;
    public Text vidasPlayer;
    private int vidas = 3;
    private int pontos =0;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(10f, 0),ForceMode2D.Impulse);
        
        
    }

    void OnCollisionEnter2D(Collision2D bolinha)
    { 
        if(bolinha.gameObject.name == "ParedeEsquerda"){
            pontos ++;
            

        }
        if(bolinha.gameObject.name == "ParedeDireita"){
            vidas --;
           if(vidas ==0)
           {
               LoadGameOver();
           } 
        }
    }

    void LoadGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    // Update is called once per frame
    void Update()
    {
        TextoPontuacao.text = pontos.ToString();
        vidasPlayer.text = vidas.ToString();
    }
}
