using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Bala : MonoBehaviour
{   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Colision");          
              
            collision.gameObject.GetComponent<CogerMoneda>().coger();           
            Destroy(collision.gameObject); 
        }
    }
}

