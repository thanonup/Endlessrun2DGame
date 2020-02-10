using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICOIN : MonoBehaviour
{
    public Text UiCoin;
    
    public float Coinnum1;
    public Coinnum coinnum;
    public Player player;
    public DeadScore1 deadscore1;
    // Start is called before the first frame update
    void Start()
    {
        coinnum.CoinS = 0;
    }

    // Update is called once per frame
    void Update()
    {
        CoinRun();
        
        Dead();
    }
    public void CoinRun()
    {
        Coinnum1 = coinnum.CoinS;
        UiCoin.text = ((int)Coinnum1).ToString("000");
    }
    public void Dead()
    {
        if(player.health == 0)
        {
            deadscore1.EndSocre1(Coinnum1);
        }
    }
}
