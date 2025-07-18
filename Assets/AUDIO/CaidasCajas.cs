using UnityEngine;

public class CaidaControlada : MonoBehaviour
{
    public float alturaFinal = 21.18294f; // Cambia esto al valor exacto que tienen las otras cajas
    public float velocidadCaida = 5f;
    public AudioClip sonidoAlLlegar;

    private bool haCaido = false;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (!haCaido)
        {
            if (transform.position.y > alturaFinal + 0.01f)
            {
                // Sigue cayendo hasta estar cerca
                transform.position -= new Vector3(0, velocidadCaida * Time.deltaTime, 0);
            }
            else
            {
                // Fija posición exacta alineada
                Vector3 nuevaPos = new Vector3(transform.position.x, alturaFinal, transform.position.z);
                transform.position = nuevaPos;

                haCaido = true;

                if (sonidoAlLlegar != null)
                {
                    audioSource.PlayOneShot(sonidoAlLlegar);
                }
            }
        }
    }
}

