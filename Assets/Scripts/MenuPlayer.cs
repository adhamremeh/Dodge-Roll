using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPlayer : MonoBehaviour
{

    private Rigidbody2D rb;

    private float scalar;

    private bool turning = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(turnOn());
    }

    // Update is called once per frame
    void Update()
    {
        scalar += Time.deltaTime;

        if (turning) 
        { 
            if (scalar % 5 > 2.5f)
            {
                rb.velocity = new Vector2(-6, rb.velocity.y);
            }
            else if (scalar % 5 < 2.6f)
            {
                rb.velocity = new Vector2(6, rb.velocity.y);
            }
        }
    }

    IEnumerator turnOn()
    {
        yield return new WaitForSeconds(0.5f);
        turning = true;
    }
}
