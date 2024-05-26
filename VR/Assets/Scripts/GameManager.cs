using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int PuntosTotales { get { return puntosTotales; } }
    public int puntosTotales = 0;
    public HUD hud;   
    public int currentPuntos;   
    public void SumarPuntos(int sumarPuntos)
    {
        puntosTotales += sumarPuntos;
        Debug.Log(puntosTotales);
        if (hud != null)
        {
            hud.ActualizarPuntos(PuntosTotales);
            if (puntosTotales == 1)
            {
                SceneManager.LoadScene(1);
            }
        }
        else
        {
            Debug.LogError("HUD is not assigned in the GameManager.");
        }
        currentPuntos = puntosTotales;
    }   
        
    }
