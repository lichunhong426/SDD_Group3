using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Text timerText;
    float time;
    void Start()
    {
        timerText = GetComponent<Text>();
        time = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {   time += 1 * Time.deltaTime;
        timerText.text = time.ToString("000");
    }

    public float CurrentTime()
    {
        return this.time;
    }
}
