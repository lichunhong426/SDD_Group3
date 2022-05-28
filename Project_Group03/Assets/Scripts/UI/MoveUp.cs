using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveUp : MonoBehaviour
{
    private RectTransform moveUpRectTransform;
    public static float speed;
    private void Start()
    {
        moveUpRectTransform = GetComponent<RectTransform>();
        speed = 70f;
    }

    // Update is called once per frame
    void Update()
    {
        Vertical(speed);
    }

    public void Vertical(float speed)
    {
        moveUpRectTransform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
