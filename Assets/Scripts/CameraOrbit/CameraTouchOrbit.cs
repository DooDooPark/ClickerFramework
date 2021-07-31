using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraTouchOrbit : MonoBehaviour
{
    [SerializeField]
    private Text modeText;
    private bool landScape;
    private Vector2 startPos;
    private Vector2 direction;
    private bool directionChosen;

    void Update()
    {
        if(Screen.orientation == ScreenOrientation.Portrait)
        {
            // transform.Rotate(0f, 0f, 0f);
            landScape = false;
            modeText.text = "Screen Portrait" + landScape;
            Debug.Log("This screen Portrait");
        }

        else if(Screen.orientation == ScreenOrientation.PortraitUpsideDown)
        {
            landScape = false;
            modeText.text = "Screen Portrait" + landScape;
            Debug.Log("This screen Portrait");
        }

        else
        {
            landScape = true;
            modeText.text = "LandScape Mode" + landScape;
            Debug.Log("LandScape Mode");       
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    startPos = touch.position;
                    directionChosen = false;
                    break;

                case TouchPhase.Moved:
                    direction = touch.position - startPos;
                    // transform.Rotate(0f, direction ,0f);
                    break;

                case TouchPhase.Ended:
                    directionChosen = true;
                    break;
            }
        }

        if(directionChosen)
        {

        }
    }
}
