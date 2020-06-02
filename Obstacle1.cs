using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacle1 : MonoBehaviour
{
    public int damage = 0;
    public float speed;
    public GameObject fx;
    public SPF spf;
    public Coinnum coinnum;

    private Animator anim;

    private void Start()
    {
        spf.SPEEDF = 1;
        anim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
    }

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime*spf.SPEEDF);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("HIT"))
        {
            anim.SetTrigger("Skake3");
            Instantiate(fx, transform.position, Quaternion.identity);
            coinnum.CoinS++;
            
            
            
            Destroy(gameObject);             
        }



        if (other.CompareTag("GameOver"))
        {
           
            Destroy(gameObject);
        }
    }
}
