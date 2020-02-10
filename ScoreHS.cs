using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHS : MonoBehaviour
{
    public Text hsE;

    // Start is called before the first frame update
    void Start()
    {
        hsE.text = ((int)PlayerPrefs.GetFloat("Highscore")).ToString("0000");
    }

    // Update is called once per frame
    void Update()
    {
      
        
    }
}
