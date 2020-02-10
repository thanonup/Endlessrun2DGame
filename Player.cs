using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public int Ypos;

    public float speed;
    public float maxH;
    public float minH;

    private Animator anim;

    public int health = 3;
    public SPF spf;
    public HP hp;

    public GameObject Playerfx;
    public GameObject gameover;
    public GameObject player;
    public GameObject score;
    // Start is called before the first frame update
    void Start()
    {
        if (Time.timeScale == 0f)
            Time.timeScale = 1.0f;
        targetPos = new Vector2(-4.6f, 0);
        anim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        playerCRTL();
        Ondie();
        hp.heart = health;
    }
    public void playerCRTL()
    {
        
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxH)
        {
            anim.SetTrigger("Shake");
            Instantiate(Playerfx, transform.position, Quaternion.identity);
            Destroy(GameObject.Find("PlayerFX(Clone)"), 2);
            targetPos = new Vector2(transform.position.x, transform.position.y + Ypos);
           
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minH)
        {
            anim.SetTrigger("Shake");
            Instantiate(Playerfx, transform.position, Quaternion.identity);
            Destroy(GameObject.Find("PlayerFX(Clone)"), 2);
            targetPos = new Vector2(transform.position.x, transform.position.y - Ypos);
            
        }
    }
    public void Ondie()
    {
        if (health <= 0)
        {
            player.SetActive(false);
            gameover.SetActive(true);
            score.SetActive(false);
            if (Time.timeScale == 1.0f)
                Time.timeScale = 0.0f;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            spf.SPEEDF = 1;

        }
    }
}
