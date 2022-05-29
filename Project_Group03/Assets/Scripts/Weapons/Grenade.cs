using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public GameObject ExplosionEffect;
    public float Delay = 3f;

    public float ExplosionForce = 5000f;
    public float Radius = 1000f;

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
                if (rig.gameObject.tag == "Monster")
                {
                    rig.transform.gameObject.GetComponent<EnemiesData>().SetHealth(rig.transform.gameObject.GetComponent<EnemiesData>().GetHealth() - 30);
                    if(rig.transform.gameObject.GetComponent<EnemiesData>().GetHealth() <= 0)
                    {
                        Destroy(rig.gameObject);
                    }
                }
            }



            Instantiate(ExplosionEffect, transform.position, transform.rotation);
            FindObjectOfType<AudioManager>().Play("Explosion");
            Destroy(gameObject);
        }
    }
}
