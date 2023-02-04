using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlBotones : MonoBehaviour {
    public void OnJugar() {
        SceneManager.LoadScene("GameScene");
    }

    public void OnCreditos() {
        SceneManager.LoadScene("CreditsScene");
    }

    public void OnAyuda() {
        SceneManager.LoadScene("HelpScene");
    }

    public void OnSalir() {
        Application.Quit();
    }

    public void OnMenu() {
        SceneManager.LoadScene("MenuScene");
    }

    public void OnVictoria() {
        SceneManager.LoadScene("VictoryScene");
    }
}
