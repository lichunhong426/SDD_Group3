using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon : MonoBehaviour
{

    Collider hitCollider;

    Animator anim;
    bool isAttacking;
    public WeaponsDataScriptableObjects Unknown;
    public Text ScoreText;
    public static int score;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        hitCollider = GetComponent<BoxCollider>();
        isAttacking = false;
        hitCollider.enabled = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {

        ScoreText.text = "Score : " + score.ToString("000");
        if (Input.GetMouseButtonDown(0) && isAttacking == false)
        {
            hitCollider.enabled = true;
            isAttacking = true;
            FindObjectOfType<AudioManager>().Play("Slash");
            anim.SetBool("isAttack", true);
            
            Invoke("EnableHitBlock", 0.3f);
            Invoke("FinishAttack", 0.6f);
        }


    }
    
    private void EnableHitBlock()
    {
        hitCollider.enabled = false;


    }

    private void FinishAttack()
    {
        isAttacking = false;

        anim.SetBool("isAttack", false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Monster") 
        {
            other.transform.gameObject.GetComponent<EnemiesData>().SetHealth(other.transform.gameObject.GetComponent<EnemiesData>().GetHealth() - Unknown.attack);

            Debug.Log(other.transform.gameObject.GetComponent<EnemiesData>().GetName() + " Health : " + other.transform.gameObject.GetComponent<EnemiesData>().GetHealth());


            if (other.transform.gameObject.GetComponent<EnemiesData>().GetHealth() <= 0)
            {
                score += 1;
                Destroy(other.transform.gameObject);
            }
        }
    }

}
