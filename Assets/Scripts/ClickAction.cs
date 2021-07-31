using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickAction : MonoBehaviour
{
    Animator anim;

    private void Start() 
    {
        anim = gameObject.GetComponent<Animator>();
    }

    public void GetPoint()
    {
        if(ClickerSingleton.Instance().onGame)
        {
            ClickerSingleton.Instance().timeScore = ClickerSingleton.Instance().timeScore + 100;
            ClickerSingleton.Instance().scoreText.text = (ClickerSingleton.Instance().timeScore/100).ToString();
            anim.speed = 1;
        }
    }

    void Update()
    {
        Debug.Log("Anim Speed: "+anim.speed);
        if(ClickerSingleton.Instance().onGame)
        {
            if(Input.GetMouseButtonDown(0))
            {
                anim.speed += 3;
            }
        }
    }

            // if(ClickerSingleton.Instance().onGame)
        // {
        //     ClickerSingleton.Instance().timeScore += (int)(Time.deltaTime*100);
        //     if (Input.GetMouseButtonDown(0))
        //     {
        //         // Debug.Log("mouse Click");
        //         ClickerSingleton.Instance().timeScore = ClickerSingleton.Instance().timeScore + 100;
        //     } 
        //     // Debug.Log(ClickerSingleton.Instance().timeScore);
        //     ClickerSingleton.Instance().scoreText.text = (ClickerSingleton.Instance().timeScore/100).ToString();
        // }

}
