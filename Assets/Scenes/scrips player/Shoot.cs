using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform shootcontroller;
    private float firerate = 1.5f;
    private float nextfiretime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (nextfiretime < Time.time)
        {
            Instantiate(bullet, shootcontroller.transform.position, Quaternion.identity);
            nextfiretime = Time.time + firerate;
        }

    }
}

