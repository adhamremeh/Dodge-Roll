using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private int Health = 3;
    public GameObject hearts3;
        public GameObject hearts2;
            public GameObject heart;
                public GameObject Spawners;
                    public GameObject Crack;
                        public Sprite Player2H;
                            public Sprite Player1H;
    private float zoom = 0.1286f;

    private Rigidbody2D rb;
    public float speed;

    private int Direction;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Health == 3)
        {
            hearts3.SetActive(true);
            hearts2.SetActive(false);
            heart.SetActive(false);
        }
        else if (Health == 2)
        {
            GetComponent<SpriteRenderer>().sprite = Player2H;
            hearts3.SetActive(false);
            hearts2.SetActive(true);
            heart.SetActive(false);
        }
        else if (Health == 1)
        {
            GetComponent<SpriteRenderer>().sprite = Player1H;
            hearts3.SetActive(false);
            hearts2.SetActive(false);
            heart.SetActive(true);
        }
        else if (Health <= 0)
        {
            hearts3.SetActive(false);
            hearts2.SetActive(false);
            heart.SetActive(false);
            Spawners.SetActive(false);
            FindObjectOfType<Score>().dead = true;
            zoom += Time.deltaTime * 2;
            if (zoom >= 0.9533632f)
            {
                zoom = 0.9533632f;
                Crack.SetActive(true);
            }
            transform.localScale = new Vector3(zoom, zoom, zoom);
        }

        if (Controls.control == 1)
        {
            rb.velocity = new Vector2(Input.acceleration.x * speed * 2.5f, rb.velocity.y);
        }

        if (Direction == 1 && Controls.control == 2)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        else if (Direction == 2 && Controls.control == 2)
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
    }

    public void Right_D()
    {
        Direction = 1;
    }
    public void Right_U()
    {
        Direction = 0;
    }
    public void Left_D()
    {
        Direction = 2;
    }
    public void Left_U()
    {
        Direction = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("obstcal"))
        {
            collision.gameObject.GetComponent<Obstcals>().Explosion_V();
            Destroy(collision.gameObject);
            Health -= 1;
        }
    }

}
