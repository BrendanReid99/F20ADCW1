using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyboardController : MonoBehaviour
{

    public bool Check = false;
    public bool CheckTwo = false;
    
    private GameObject correctSelect;
    public bool correctSelectBool = false;
    private Color correctSelectOnC = new Color(0f, 0.5f, 0f, 1f);
    private Color correctSelectOffC = new Color(0f, 1f, 0f, 1f);

    private GameObject almostCorrectSelect;
    public bool almostCorrectSelectBool = false;
    private Color almostCorrectSelectOnC = new Color(0.5f, 0.5f, 0f, 1f);
    private Color almostCorrectSelectOffC = new Color(1f, 1f, 0f, 1f);

    private GameObject wrongSelect;
    public bool wrongSelectBool = false;
    private Color wrongSelectOnC = new Color(0.5f, 0f, 0f, 1f);
    private Color wrongSelectOffC = new Color(1f, 0f, 0f, 1f);


    // Start is called before the first frame update
    void Start()
    {
        correctSelect = GameObject.Find("CorrectSelect");
        almostCorrectSelect = GameObject.Find("AlmostCorrectSelect");
        wrongSelect = GameObject.Find("WrongSelect");
    }

    public void correctSelectOn()
    {
        if (correctSelectBool == false && Check == false && CheckTwo == false)
        {
            correctSelect.GetComponent<Image>().color = correctSelectOnC;
            correctSelectBool = true;
            Check = true;
            CheckTwo = true;
        }
        if (correctSelectBool == true && Check == false)
        {
            correctSelect.GetComponent<Image>().color = correctSelectOffC;
            correctSelectBool = false;
            CheckTwo = false;
        }

        Check = false;
    }

    public void almostCorrectSelectOn()
    {
        if (almostCorrectSelectBool == false && Check == false && CheckTwo == false)
        {
            almostCorrectSelect.GetComponent<Image>().color = almostCorrectSelectOnC;
            almostCorrectSelectBool = true;
            Check = true;
            CheckTwo = true;
        }
        if (almostCorrectSelectBool == true && Check == false)
        {
            almostCorrectSelect.GetComponent<Image>().color = almostCorrectSelectOffC;
            almostCorrectSelectBool = false;
            CheckTwo = false;
        }

        Check = false;
    }

    public void wrongSelectOn()
    {
        if (wrongSelectBool == false && Check == false && CheckTwo == false)
        {
            wrongSelect.GetComponent<Image>().color = wrongSelectOnC;
            wrongSelectBool = true;
            Check = true;
            CheckTwo = true;
        }
        if (wrongSelectBool == true && Check == false)
        {
            wrongSelect.GetComponent<Image>().color = wrongSelectOffC;
            wrongSelectBool = false;
            CheckTwo = false;
        }

        Check = false;
    }

    public void CharacterColorChange()
    {

    }


/*
    public void correctSelectOff()
    {
        correctSelect.GetComponent<Image>().color = new Color(6, 255, 0);
    }
*/
}
