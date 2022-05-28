using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerAndScore : MonoBehaviour
{
    TextMeshProUGUI timerAndScoreText;
    public Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        timerAndScoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        timerAndScoreText.text = "Timer : " + (int)timer.CurrentTime() + "\n" + "\n"+ "Score : " + Weapon.score.ToString();
    }
}
