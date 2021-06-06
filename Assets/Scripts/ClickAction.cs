using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickAction : MonoBehaviour
{
    private int timeScore;

    public Text cubeText;

    void Update()
    {
        timeScore += (int)(Time.deltaTime*100);
        Debug.Log("Time count: "+timeScore);
        
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("mouse Click");
            timeScore = timeScore+100;
        }
        ClickerSingleton.Instance().scoreText.text = timeScore.ToString();
    }

    private void OnMouseDown() 
    {
        
        Debug.Log("Click Cube Character");
        cubeText.text = "Cube Click";
    }
}
