using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //Cre
    public void Escena1v1()
    {
        SceneManager.LoadScene(1);
    }
    
    public void Escena2v2()
    {
        SceneManager.LoadScene(2);
    }

    public void Salir()
    {
        Application.Quit();
    }
}
