using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;

public class Disparar : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject bala;
    public float shotForce = 2000f;
    public float shotRate = 0.5f;
    private float shotRateTime = 0;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1")) //click izquierdo
        {
            if (Time.time > shotRateTime)
            {
                //Instanciamos la bala desde un punto específico con una velocidad
                GameObject newbala;
                newbala = Instantiate(bala, spawnPoint.position, spawnPoint.rotation);
                newbala.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotForce);

                shotRateTime = Time.time + shotRate;

                Destroy(newbala,5); //desaparece a los 5s
            }
           

        }
    }

}
