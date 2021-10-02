using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public const int MAX_BULLET = 10;

    public Bullet originBullet;
    private List<Bullet> bullets;

    void Start()
    {
        bullets = new List<Bullet>();

        for(int i = 0; i < MAX_BULLET; i++)
        {
            Bullet b = Instantiate(originBullet);
            bullets.Add(b);
        }
    }

    public void Fire()
    {
        foreach(Bullet b in bullets)
        {
            if (b.GetFire())
                continue;

            b.gameObject.SetActive(true);
            b.transform.position = transform.position;
            //b.transform.rotation = Quaternion.identity;
            //b.transform.Rotate(Vector3.up * transform.eulerAngles.y);
            b.FireBullet();
            break;
        }
    }
}
