using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public float Speed;

    public GameObject ExpEffect;

    private bool done = false;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BlackboardComponent>().BlackboardData.Insert("speed", Speed);

        Physics2D.IgnoreLayerCollision(8, 9);
    }

    void Update()
    {
        if (transform.position.x < -15)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (!done)
        {
            Instantiate(ExpEffect, col.GetContact(0).point, Quaternion.identity);
            done = true;
        }

        Destroy(gameObject);
    }
}
