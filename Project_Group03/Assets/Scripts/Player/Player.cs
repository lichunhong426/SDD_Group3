using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{


    public HealthBar HealthBar;


    public GameObject OptionPanel;
    public GameObject SettingPanel;


    public PlayerData data;


    bool isOption = false;
    bool isSetting = false;
    bool isStat = false;



    public void SetIsSetting(bool isSetting)
    {
        this.isSetting = isSetting;
    }

    public void SetIsOption(bool isOption)
    {
        this.isOption = isOption;
    }

    // Start is called before the first frame update
    void Start()
    {
        
        HealthBar.SetMaxHealth(data.MaxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        data.UpdateStats();


        if (Input.GetKeyDown(KeyCode.Escape) && isOption == false && isStat == false)
        {
            OptionPanel.SetActive(true);
            isOption = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isOption == true && isSetting == false)
        {
            OptionPanel.SetActive(false);
            isOption = false;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isOption == true && isSetting == true)
        {
            OptionPanel.SetActive(false);
            SettingPanel.SetActive(false);
            isOption = false;
            isSetting = false;
        }




    }


    void TakeDamage(int damage)
    {
        data.CurrentHealth -= damage;

        HealthBar.SetHealth(data.CurrentHealth);

        if(data.CurrentHealth <= 0)
        {
            data.CurrentHealth = 0;
            LoadScene();
        }
    }



    public void LoadScene()
    {
        SceneManager.LoadScene("GameOverScene");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Monster")
        {
            TakeDamage(5);
        }
 
    }
}
