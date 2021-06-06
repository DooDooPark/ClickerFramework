using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickerSingleton : MonoBehaviour
{
    public Text scoreText;
    static ClickerSingleton _instance = null;

    public static ClickerSingleton Instance()
    {
        return _instance;
    }

    private void Awake() 
    {
        if(_instance == null)
        {
            _instance = this;
        }

        else
        {
            Destroy(gameObject);
        }
    }
}
