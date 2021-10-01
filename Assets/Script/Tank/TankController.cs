using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    public readonly float MAX_MOVE_SPEED = 30.0f;
    public readonly float SPIN_SPEED = 30;
    
    private float currSpeed = 0.0f;
    private Cannon cannon;

    private void Awake()
    {
        cannon = GetComponentInChildren<Cannon>();
    }

    void Update()
    {
        if(!GameManager.GetInstance().CheckUIFocus())
        {
            Move();

            if (Input.GetKeyUp(KeyCode.Space))
            {
                FireBullet();
            }
        }
    }

    private void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if(vertical == 0.0f)
        {
            if (currSpeed < 0)
                currSpeed = Mathf.Max(0.0f, currSpeed - 0.01f);
            else
                currSpeed = Mathf.Min(0.0f, currSpeed + 0.01f);
        }
        else
        {
            currSpeed = Mathf.Min(currSpeed + vertical, MAX_MOVE_SPEED);
        }

        transform.Translate(Vector3.forward * currSpeed * Time.deltaTime);

        if(horizontal != 0.0f)
            transform.Rotate(0, (SPIN_SPEED * horizontal * Time.deltaTime), 0);

    }

    private void FireBullet()
    {
        if(cannon != null)
        {
            cannon.Fire();
        }
    }
}
