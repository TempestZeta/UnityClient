using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public readonly float BULLET_SPPED = 10.0f;

    private Rigidbody bulletRigid;
    private bool isFire = false;

    private void Awake()
    {
        bulletRigid = GetComponent<Rigidbody>();
        gameObject.SetActive(false);
    }

    private void Start()
    {
        FireBullet();
    }

    private void Update()
    {
        if (isFire)
        {
            transform.Translate(transform.forward * BULLET_SPPED * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");

        if (collision.gameObject.tag.Equals("Wall"))
        {
            gameObject.SetActive(false);
            isFire = false;
        } else if (collision.gameObject.tag.Equals("Bullet"))
        {
            Debug.Log("Bullet Collision");
        }


    }

    public void FireBullet()
    {
        if (isFire)
            return;

        if(null != bulletRigid)
        {
            isFire = true;
            
            //bulletRigid.AddForce();
        }
        else
        {
            Debug.LogError("Rigidbody is Null");
        }
    }

    public bool GetFire()
    {
        return isFire;
    }
}
