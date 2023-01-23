using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Scene = UnityEditor.SearchService.Scene;

public class GameManager : MonoBehaviour {

    void Update () {
        if (Input.GetKeyDown(KeyCode.P) || Input.GetMouseButton(0)){
            //Cargo la escena de Juego
            SceneManager.LoadScene("1v1");
        }
        
        if (Input.GetKeyDown(KeyCode.O) || Input.GetMouseButton(1)){
            //Cargo la escena de Juego
            SceneManager.LoadScene("2v2");
        }
        
        if (Input.GetKeyDown(KeyCode.E)){
            //Cargo la escena de Inicio
            SceneManager.LoadScene("Inicio");
        }
    }
}