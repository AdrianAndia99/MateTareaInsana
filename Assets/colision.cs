using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Flecha"))
        {
            Destroy(gameObject);
        }
    }
}
