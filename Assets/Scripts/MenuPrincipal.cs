using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;

    public void jogar()
    {
        SceneManager.LoadScene(nomeDoLevelDeJogo);
    }
    public void sairJogo()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
     }
    
        
    
    
       
    
}
