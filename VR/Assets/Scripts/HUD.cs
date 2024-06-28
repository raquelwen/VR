using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI puntos;
    public void ActualizarPuntos(int puntosTotales)
    {
        puntos.text = puntosTotales.ToString();

    }
}
