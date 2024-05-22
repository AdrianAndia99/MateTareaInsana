using UnityEngine;

public class FlechaController : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Objetivo"))
        {
            Destroy(gameObject);
        }
    }
}
