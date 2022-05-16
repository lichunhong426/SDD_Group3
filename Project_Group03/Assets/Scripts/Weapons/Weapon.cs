using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    Animator anim;
    bool isAttacking;
    public WeaponsDataScriptableObjects Unknown;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isAttacking = false;
        if (Input.GetMouseButtonDown(0) && isAttacking == false)
        {
            anim.SetBool("isAttack", true);
            isAttacking = true;
        }
        else
        {
            anim.SetBool("isAttack", false);
            isAttacking = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Monster")
        {
            other.transform.gameObject.GetComponent<EnemiesData>().SetHealth(other.transform.gameObject.GetComponent<EnemiesData>().GetHealth() - Unknown.attack);
            Debug.Log("Enemy Health : " + other.transform.gameObject.GetComponent<EnemiesData>().GetHealth());
            if (other.transform.gameObject.GetComponent<EnemiesData>().GetHealth() <= 0)
            {
                Destroy(other.transform.gameObject);
            }
        }
    }

}
