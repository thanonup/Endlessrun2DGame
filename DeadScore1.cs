using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeadScore1 : MonoBehaviour
{
    public Text CoinEnd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EndSocre1(float Coinnum1)
    {
        CoinEnd.text = ((int)Coinnum1).ToString("000");
    }
}
