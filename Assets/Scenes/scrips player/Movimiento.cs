using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2D;
    public GameObject Bullet;
    public float speedShooter;
    private float timeShooter;
    private float shooterleytimer = 0.5f;
    private Vector2 dir;


    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Mov();
        shooter();
        Timer();
    }
    void Mov()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
          dir = new Vector2(horizontal, vertical);


        rb2D.velocity = new Vector2(horizontal, vertical) * speed;
         
    }
    void Timer()
    {
        timeShooter += Time.deltaTime;
    }

    void shooter()
    {
        if (Input.GetKeyDown(KeyCode.Space) && timeShooter >= shooterleytimer)
        {
            GameObject obj = Instantiate(Bullet);
            obj.transform.position = transform.position;
            timeShooter = 0;
            obj.GetComponent<BalaPlayer>().direction(dir);
        }
    }

}
