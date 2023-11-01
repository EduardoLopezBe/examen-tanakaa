using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallaEnemy2 : MonoBehaviour
{
  

    GameObject ob;
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb2d;
    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        ob = GameObject.FindGameObjectWithTag("Player");
        Vector2 movDir = (ob.transform.position - transform.position).normalized * speed;
        rb2d.velocity = new Vector2(movDir.x, movDir.y);
        Destroy(this.gameObject, 5);
    }


}

