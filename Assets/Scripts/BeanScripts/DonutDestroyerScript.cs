using TMPro;
using UnityEngine;

public class DonutDestroyScript : MonoBehaviour
{
    SFX_Script sfx;

    void Start()
    {
        sfx = FindFirstObjectByType<SFX_Script>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Donut"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("Bad"))
        {
            Destroy(collision.gameObject);
        }
    }
}