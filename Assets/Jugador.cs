using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Jugador : MonoBehaviour
{
    public GameObject flechaPrefab;
    public Transform puntoDisparo;
    public float fuerzaDisparo = 1000f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H) == true)
        {
            DispararFlecha();
        }
    }

    void DispararFlecha()
    {
        GameObject flecha = Instantiate(flechaPrefab, puntoDisparo.position, puntoDisparo.rotation);
        Rigidbody rb = flecha.GetComponent<Rigidbody>();
        rb.AddForce(puntoDisparo.forward * fuerzaDisparo);
    }
}