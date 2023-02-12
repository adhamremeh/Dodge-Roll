using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstcals : MonoBehaviour
{

    public GameObject Explosion;

    private Rigidbody2D rb;
    private SpriteRenderer SPR;

    public Color NewColor;

    public float Timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SPR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        if (FindObjectOfType<Score>().Real_Score == 200)
        {
            if (rb.gravityScale < 0.3f)
                rb.gravityScale += 0.1f;
        }
        if (FindObjectOfType<Score>().Real_Score == 400)
        {
            if (rb.gravityScale < 0.4f)
                rb.gravityScale += 0.1f;
        }

        if (Timer < 5)
        {
            NewColor.r -= Time.deltaTime * 0.2f;
            NewColor.g += Time.deltaTime * 0.2f;
        }
        else if (Timer > 5 && Timer < 10)
        {
            NewColor.r += Time.deltaTime * 0.2f;
            NewColor.g -= Time.deltaTime * 0.2f;
        }
        else if (Timer > 10)
        {
            Timer = 0;
        }
        SPR.color = NewColor;
    }

    public void Explosion_V()
    {
        Instantiate(Explosion, transform.position, Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Destroyer"))
        {
            Destroy(gameObject);
        }
    }
}