using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("level 1");
    }
    public void QuitGame(){
        Debug.Log("Oyundan çıkıldı!");
        Application.Quit();
    }
    public void ReturnToMainMenu(){
        SceneManager.LoadScene("mainmenü");
    }
}