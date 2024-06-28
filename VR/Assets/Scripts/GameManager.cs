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
        Debug.Log("puntosTotales: " + puntosTotales);
        if (hud != null)
        {
            hud.ActualizarPuntos(puntosTotales);
            if (puntosTotales == 10)
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
    public static GameManager instance;
    void Awake()
    {
        
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

    }
}
