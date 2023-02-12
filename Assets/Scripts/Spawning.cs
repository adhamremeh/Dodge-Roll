using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{

    public float randxR;
    public float randxL;

    public float end_time;
    public float spawn_time;

    public GameObject Obstcal;

    // Start is called before the first frame update
    void Start()
    {
        float randspawn = Random.Range(0, 3);
        spawn_time = randspawn;
    }

    // Update is called once per frame
    void Update()
    {
        spawn_time += Time.deltaTime;

        if (spawn_time > end_time)
        {
            Instantiate(Obstcal, transform.position, Quaternion.Euler(0, 0, 180));
            float randspawn = Random.Range(0, 3);
            spawn_time = randspawn;
        }

        float randPos = Random.Range(randxL, randxR);
        transform.position = new Vector2(randPos, transform.position.y);

    }
}