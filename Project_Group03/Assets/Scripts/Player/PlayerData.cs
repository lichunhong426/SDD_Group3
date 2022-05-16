using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerData : MonoBehaviour
{


    public int QuestNumber;

    public int DialogueNumber;

    public int MaxHealth = 100;
    public int CurrentHealth;
    public int AttackStats = 0;



    public WeaponsDataScriptableObjects weapon;

    public int CurrentWeapons;




    public Player PlayerScript;

    private void Start()
    {
        MaxHealth = 100;
   
        AttackStats = 10;
        CurrentWeapons = 0;
  

        PlayerScript = GetComponent<Player>();
    }


    public void UpdateStats()
    {

        AttackStats =  weapon.attack;




    }




}
