using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collotion : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Monster"))
        {
            Debug.Log("Monster");
        }
    }
}
