using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeadScore2 : MonoBehaviour
{
    public Text Scoreend;
    public UIC uic;
    public float hss;
    public ScoreHS shs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    public void ScoreEnd(float ScoreF)
    {
        Scoreend.text = ((int)ScoreF).ToString("0000");
        hss = ScoreF;

    }
}
