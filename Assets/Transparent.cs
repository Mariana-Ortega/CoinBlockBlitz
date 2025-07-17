using UnityEngine;

public class Transparent : MonoBehaviour
{
    void Start()
    {
        foreach (var renderer in GetComponentsInChildren<Renderer>())
        {
            renderer.enabled = false;
        }
    }
}
