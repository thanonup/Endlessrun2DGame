using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public int heart;
    public int numofheart;

    public Image[] health;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Start()
    {
        
    }
    void Update()
    {

        if(heart > numofheart)
        {
            heart = numofheart;
        }
        for(int i = 0; i < health.Length; i++)
        {
            if (i < heart)
            {
                health[i].sprite = fullHeart;
            }
            else
            {
                health[i].sprite = emptyHeart;
            }
            if(i < numofheart)
            {
                health[i].enabled = true;
            }
            else
            {
                health[i].enabled = false;
            }
        }
    }
}
