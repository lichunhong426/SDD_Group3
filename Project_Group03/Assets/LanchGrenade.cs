using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanchGrenade : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject Grenade;

    float range = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.R) && Weapon.score >= 2)
        {
            Lanch();
            Weapon.score -= 2;
        }
    }

    private void Lanch()
    {
        GameObject grenadeInstance = Instantiate(Grenade, SpawnPoint.position, SpawnPoint.rotation);
        grenadeInstance.GetComponent<Rigidbody>().AddForce(SpawnPoint.forward * range, ForceMode.Impulse);
    }



}
