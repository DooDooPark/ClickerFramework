using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemEvent : MonoBehaviour 
{
    public List<GameObject> menuBox;
    public List<Text> eventAlarm;
    //event alarm 0.이미구매완료. 1.가격이모자름

    [SerializeField]
    private GameObject menuItem;
    public void MenuOn()
    {
        ClickerSingleton.Instance().onGame = false;
        if(menuItem.activeSelf)
        {
            ClickerSingleton.Instance().onGame = true;
            menuItem.SetActive(false);
        }

        else
        {
            ClickerSingleton.Instance().onGame = false;
            menuItem.SetActive(true);
        }
    }

    public void MenuBox(int num)
    {
        for(int i=0; i<menuBox.Count; ++i)
        {
            menuBox[i].gameObject.SetActive(false);
        }

        menuBox[num].gameObject.SetActive(true);
    }

    public void ItemPayment(Text itemprice)
    {
        int totalMoney = ClickerSingleton.Instance().timeScore;
        int payment = int.Parse(itemprice.text);
        Debug.Log("Click Function");

        if(totalMoney > payment)
        {
            totalMoney -= payment;
            ClickerSingleton.Instance().scoreText.text = totalMoney.ToString();
            Debug.Log("payment");
        }

        else
        {
            eventAlarm[0].gameObject.SetActive(true);
            StartCoroutine(SetOffAlarm(eventAlarm[0]));
        }
        
    }

    IEnumerator SetOffAlarm(Text alarmText)
    {
        yield return new WaitForSeconds(1.5f);
        alarmText.gameObject.SetActive(false);        
    }
}