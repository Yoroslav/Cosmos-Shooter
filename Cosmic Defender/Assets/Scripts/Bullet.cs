using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject impactEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(impactEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);
    }
}
