using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public GameObject ExplosionEffect;
    public float Delay = 3f;

    public float ExplosionForce = 100f;
    public float Radius = 50f;

    private void Start()
    {
        Invoke("Explode", Delay);
    }

    private void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, Radius);

        foreach(Collider near in colliders)
        {
            Rigidbody rig = near.GetComponent<Rigidbody>();

            if(rig!= null)
            {
                rig.AddExplosionForce(ExplosionForce, transform.position, Radius, 1f, ForceMode.Impulse);

            }

            Instantiate(ExplosionEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
