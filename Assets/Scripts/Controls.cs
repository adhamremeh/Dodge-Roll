using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{

    public static int control;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        if (control < 1)
        {
            panel.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            panel.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void tilt()
    {
        control = 1;
        Time.timeScale = 1;
        panel.SetActive(false);
    }
    public void touch()
    {
        control = 2;
        Time.timeScale = 1;
        panel.SetActive(false);
    }
}
