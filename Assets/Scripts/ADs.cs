using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class ADs : MonoBehaviour
{

    private string GoogleID = "3392015";
    public bool testMode;

    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(GoogleID, testMode);
    }

    public void Ad()
    {
        Advertisement.Show("video");
    }
}
