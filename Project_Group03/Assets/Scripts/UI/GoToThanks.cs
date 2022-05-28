using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToThanks : MonoBehaviour
{
    public GameObject ThanksCanvas;
    public void DeleteAll()
    {
        foreach (GameObject o in Object.FindObjectsOfType<GameObject>())
        {
            if(o.name != "ThanksCanvas")
            {
                Destroy(o);
                ThanksCanvas.SetActive(true);
            }

        }
    }
}
