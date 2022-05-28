using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveUp : MonoBehaviour
{
    RectTransform moveUpRectTransform;

    private void Start()
    {
        moveUpRectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        moveUpRectTransform.Translate(Vector3.up * 70f * Time.deltaTime);
    }


}
