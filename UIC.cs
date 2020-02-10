using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIC : MonoBehaviour
{
    public Text Score;
    public float ScoreF;
    public SPF spf;
    public Player player;
    public DeadScore2 deadscore2;

    public float hs = 0;
    public Text HScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ondead();
        
        ScoreRun();
        if (ScoreF > 25)
        {
            spf.SPEEDF = 1.3f;
        }
        if(ScoreF > 60)
        {
            spf.SPEEDF = 1.6f;
        }
        if(ScoreF > 100)
        {
            spf.SPEEDF = 1.9f;
        }
        if(ScoreF > 160)
        {
            spf.SPEEDF = 2.0f;
        }
        if(ScoreF > 300 )
        {
            spf.SPEEDF = 2.1f;
        }
        if(ScoreF > 400)
        {
            spf.SPEEDF = 2.2f;
        }
        if(ScoreF > 520)
        {
            spf.SPEEDF = 2.3f;
        }
        if (ScoreF > 630)
        {
            spf.SPEEDF = 2.5f;
        }
        if (ScoreF > 700)
        {
            spf.SPEEDF = 2.7f;
        }
    }
    public void ScoreRun()
    {
        ScoreF += Time.deltaTime*3f;
        Score.text = ((int)ScoreF).ToString("0000");
    }
    public void Ondead()
    {
        if(PlayerPrefs.GetFloat("Highscore") < ScoreF)
        PlayerPrefs.SetFloat("Highscore",ScoreF);
        deadscore2.ScoreEnd(ScoreF);
    }
}
