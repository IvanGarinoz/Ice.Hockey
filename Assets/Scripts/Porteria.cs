using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porteria : MonoBehaviour
{

    [SerializeField] private AudioClip audioGol;
    
    AudioSource fuenteDeAudio;

    private void Start()
    {
        fuenteDeAudio = GetComponent<AudioSource>();
    }

    //detecto si la bola atraviesa la porteria
    void OnTriggerEnter2D(Collider2D disco) {

        if (disco.name == "Disco"){
            //Si es la portería izquierda
            if (this.name == "PorteriaIzquierda"){
                //Cuento el gol y reinicio la bola
                disco.GetComponent<Disco>().reiniciarDisco("Derecha");
                fuenteDeAudio.clip = audioGol;
                fuenteDeAudio.Play();
            }
            //Si es la portería derecha
            else if (this.name == "PorteriaDerecha"){
                //Cuento el gol y reinicio la bola
                disco.GetComponent<Disco>().reiniciarDisco("Izquierda");
                fuenteDeAudio.clip = audioGol;
                fuenteDeAudio.Play();
            }
        }
    }
}
