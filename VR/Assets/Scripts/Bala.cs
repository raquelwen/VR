using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


    public class Bala : MonoBehaviour
    {

    
    public GameManager gameManager;    

    void Start()
    {        
        if (gameManager == null)
        {
            gameManager = FindObjectOfType<GameManager>();
        }

        // Check if GameManager was found
        if (gameManager == null)
        {
            Debug.LogError("GameManager is not found in the scene.");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        int puntosBala = 1;
        if (collision.gameObject.CompareTag("Enemy"))
        {

            if (gameManager != null)
            {
                Debug.Log("Sumando puntos: " + puntosBala);
                gameManager.SumarPuntos(puntosBala); 
                Destroy(collision.gameObject);
            }
            else
            {
                Debug.LogError("GameManager is not assigned.");
            }

        }
    }    
}

