using UnityEngine;

public class Personaje3 : MonoBehaviour
{
    void Start()
    {
        // Aquí puedes iniciar variables si las necesitas luego
    }

    void Update()
    {
        // Movimiento o lógica continua, si la agregas después
    }

    // 🔽 Esta función se ejecuta automáticamente al chocar con otro objeto con Collider
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("El personaje chocó con: " + other.gameObject.name);
    }

    }

