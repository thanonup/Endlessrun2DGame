using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int damage = 1;
    public float speed;
    public GameObject fx;
    public SPF spf;

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
            anim.SetTrigger("Shake2");
            Instantiate(fx, transform.position, Quaternion.identity);
            other.GetComponent<Player>().health -= 1;
            Debug.Log(other.GetComponent<Player>().health);
            Destroy(gameObject);
        }



        if (other.CompareTag("GameOver"))
        {
            print("Destroy");
            Destroy(gameObject);
        }
    }
}
