using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{

    public int point = 1;
    public GameManager gameManager;
     
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {   
            Debug.Log("Kill");
            Destroy(collision.gameObject);
            gameManager.SumarPuntos(point);         
            
        }
    }



}
