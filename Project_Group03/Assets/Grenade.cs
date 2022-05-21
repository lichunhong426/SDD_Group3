using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Monster")
        {
            other.GetComponent<EnemiesData>().SetHealth(other.GetComponent<EnemiesData>().GetHealth() - 30);
            if (other.GetComponent<EnemiesData>().GetHealth() <= 0)
            {
                Destroy(other.gameObject);
            }
        }
    }
}
