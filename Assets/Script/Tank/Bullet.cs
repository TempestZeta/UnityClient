using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public readonly float BULLET_SPPED = 100.0f;

    private Rigidbody rigidbody;
    private bool isFire = false;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Wall"))
        {
            gameObject.SetActive(false);
            isFire = false;
        }
    }

    public void FireBullet()
    {
        if (isFire)
            return;

        if(null != rigidbody)
        {
            isFire = true;
            Debug.Log("Bullet Forward is " + transform.forward * BULLET_SPPED);
            rigidbody.AddForce(transform.forward * BULLET_SPPED);
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
