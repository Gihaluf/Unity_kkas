using UnityEngine;

public class ObjectCatchScript : MonoBehaviour
{
    public float sizeIncrease = 0.5f;
    public float massIncrease = 1f;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    private Rigidbody2D rb;
    SFX_Script sfx;


    void Start()
    {
        sfx = FindFirstObjectByType<SFX_Script>();
        rb = GetComponent<Rigidbody2D>();
    }

    private int heart = 3;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.IsChildOf(transform))
            return;

        if (collision.CompareTag("Donut"))
        {
            sfx.PlaySFX(3);
            Destroy(collision.gameObject);
            transform.localScale += new Vector3(sizeIncrease, sizeIncrease, 0);
            rb.mass += massIncrease;

        }
        else if (collision.CompareTag("Bad"))
        {
            if (heart == 0)
            {

            }
            sfx.PlaySFX(4);
            Destroy(collision.gameObject);
            heart--;
            switch(heart)
            {
                case 2:
                    heart3.SetActive(false);
                    break;
                case 1:
                    heart2.SetActive(false);
                    break;
                case 0:
                    heart1.SetActive(false);
                    break;
            }
        }
    }
}