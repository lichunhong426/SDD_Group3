using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesData : MonoBehaviour
{
    private new string name;
    private string descriptions;
    private int health;
    private int attackDamage;
    private int defend;
    private int experience;


    private MeshRenderer rend;

    [SerializeField]
    private Color colorToTurnTo = Color.red;

    public EnemiesDataScriptableObject enemiesScriptableObj;


    private void Start()
    {
        rend = GetComponent<MeshRenderer>();

    }

    public virtual void OnEnable()
    {
        SetUpEnemy();
    }

    // Start is called before the first frame update
    public virtual void SetUpEnemy()
    {
        name = enemiesScriptableObj.Name;
        descriptions = enemiesScriptableObj.Descriptions;
        health = enemiesScriptableObj.Health;
        attackDamage = enemiesScriptableObj.AttackDamage;
        defend = enemiesScriptableObj.Defend;
        experience = enemiesScriptableObj.Experience;
        
    }

    public void SetHealth(int health)
    {
        this.health = health;
    }

    public int GetHealth()
    {
        return this.health;
    }

    public int GetAttackDamage()
    {
        return this.attackDamage;
    }

    public string GetName()
    {
        return this.name;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Weapon")
        {
            rend.material.color = colorToTurnTo;
        }
    }

}
