using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeyboardController : MonoBehaviour
{

    [SerializeField] public TextMeshProUGUI passwordGuessBox;


    private string password = "raccoon45";
    private string passwordCheck = "";
    private bool gameStarted = false;

    private string password1 = "";
    private string password2 = "";
    private string password3 = "";
    private string password4 = "";
    private string password5 = "";
    private string password6 = "";
    private string password7 = "";
    private string password8 = "";
    private string password9 = "";
    private string password10 = "";

    private bool password1full = false;
    private bool password2full = false;
    private bool password3full = false;
    private bool password4full = false;
    private bool password5full = false;
    private bool password6full = false;
    private bool password7full = false;
    private bool password8full = false;
    private bool password9full = false;
    private bool password10full = false;

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
    private Color wrongSelectOnC = new Color(0f, 0f, 1f, 1f);
    private Color wrongSelectOffC = new Color(0f, 0f, 0.5f, 1f);

    private GameObject characterA;
    private GameObject characterB;
    private GameObject characterC;
    private GameObject characterD;
    private GameObject characterE;
    private GameObject characterF;
    private GameObject characterG;
    private GameObject characterH;
    private GameObject characterI;
    private GameObject characterJ;
    private GameObject characterK;
    private GameObject characterL;
    private GameObject characterM;
    private GameObject characterN;
    private GameObject characterO;
    private GameObject characterP;
    private GameObject characterQ;
    private GameObject characterR;
    private GameObject characterS;
    private GameObject characterT;
    private GameObject characterU;
    private GameObject characterV;
    private GameObject characterW;
    private GameObject characterX;
    private GameObject characterY;
    private GameObject characterZ;
    private GameObject character1;
    private GameObject character2;
    private GameObject character3;
    private GameObject character4;
    private GameObject character5;
    private GameObject character6;
    private GameObject character7;
    private GameObject character8;
    private GameObject character9;
    private GameObject character0;




    // Start is called before the first frame update
    void Start()
    {
        
        correctSelect = GameObject.Find("CorrectSelect");
        almostCorrectSelect = GameObject.Find("AlmostCorrectSelect");
        wrongSelect = GameObject.Find("WrongSelect");
        characterA = GameObject.Find("A");
        characterB = GameObject.Find("B");
        characterC = GameObject.Find("C");
        characterD = GameObject.Find("D");
        characterE = GameObject.Find("E");
        characterF = GameObject.Find("F");
        characterG = GameObject.Find("G");
        characterH = GameObject.Find("H");
        characterI = GameObject.Find("I");
        characterJ = GameObject.Find("J");
        characterK = GameObject.Find("K");
        characterL = GameObject.Find("L");
        characterM = GameObject.Find("M");
        characterN = GameObject.Find("N");
        characterO = GameObject.Find("O");
        characterP = GameObject.Find("P");
        characterQ = GameObject.Find("Q");
        characterR = GameObject.Find("R");
        characterS = GameObject.Find("S");
        characterT = GameObject.Find("T");
        characterU = GameObject.Find("U");
        characterV = GameObject.Find("V");
        characterW = GameObject.Find("W");
        characterX = GameObject.Find("X");
        characterY = GameObject.Find("Y");
        characterZ = GameObject.Find("Z");
        character0 = GameObject.Find("0");
        character1 = GameObject.Find("1");
        character2 = GameObject.Find("2");
        character3 = GameObject.Find("3");
        character4 = GameObject.Find("4");
        character5 = GameObject.Find("5");
        character6 = GameObject.Find("6");
        character7 = GameObject.Find("7");
        character8 = GameObject.Find("8");
        character9 = GameObject.Find("9");

    }

    void Update()
    {
        passwordGuessBox.text = password1 + password2 + password3 + password4 + password5 + password6 + password7 + password8 + password9 + password10;
        passwordCheck = password1 + password2 + password3 + password4 + password5 + password6 + password7 + password8 + password9 + password10;
        if (passwordCheck == password)
        {
            Debug.Log("You Win!!");
        }
    }

    public void EnterPassword()
    {
        if(gameStarted == false)
        {

        }
    }

    public void OpenKeyboard()
    {
        TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, true, true, true, true);
    }

    public void passwordGuess(string letter)
    {
        if (password1full == false) 
        {
            password1 = letter;
            password1full = true;
        }
        else if(password1full == true && password2full == false)
        {
            password2 = letter;
            password2full = true;
        }
        else if(password2full == true && password3full == false)
        {
            password3 = letter;
            password3full = true;
        }
        else if(password3full == true && password4full == false)
        {
            password4 = letter;
            password4full = true;
        }
        else if(password4full == true && password5full == false)
        {
            password5 = letter;
            password5full = true;
        }
        else if(password5full == true && password6full == false)
        {
            password6 = letter;
            password6full = true;
        }
        else if(password6full == true && password7full == false)
        {
            password7 = letter;
            password7full = true;
        }
        else if (password7full == true && password8full == false)
        {
            password8 = letter;
            password8full = true;
        }
        else if(password8full == true && password9full == false)
        {
            password9 = letter;
            password9full = true;
        }
        else if(password9full == true && password10full == false)
        {
            password10 = letter;
            password10full = true;
        }

        if(passwordCheck == password)
        {
            Debug.Log("You Win!!");
        }
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

    public void ACharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            characterA.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("a");
        }
        if (almostCorrectSelectBool == true)
        {
            characterA.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            characterA.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void BCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            characterB.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("b");
        }
        if (almostCorrectSelectBool == true)
        {
            characterB.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            characterB.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void CCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            characterC.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("c");
        }
        if (almostCorrectSelectBool == true)
        {
            characterC.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            characterC.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void DCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            characterD.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("d");
        }
        if (almostCorrectSelectBool == true)
        {
            characterD.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            characterD.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void ECharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            characterE.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("e");
        }
        if (almostCorrectSelectBool == true)
        {
            characterE.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            characterE.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void FCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            characterF.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("f");
        }
        if (almostCorrectSelectBool == true)
        {
            characterF.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            characterF.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void GCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            characterG.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("g");
        }
        if (almostCorrectSelectBool == true)
        {
            characterG.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            characterG.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void HCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            characterH.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("h");
        }
        if (almostCorrectSelectBool == true)
        {
            characterH.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            characterH.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void ICharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            characterI.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("i");
        }
        if (almostCorrectSelectBool == true)
        {
            characterI.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            characterI.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void JCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            characterJ.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("j");
        }
        if (almostCorrectSelectBool == true)
        {
            characterJ.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            characterJ.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void KCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            characterK.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("k");
        }
        if (almostCorrectSelectBool == true)
        {
            characterK.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            characterK.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void LCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            characterL.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("l");
        }
        if (almostCorrectSelectBool == true)
        {
            characterL.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            characterL.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void MCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            characterM.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("m");
        }
        if (almostCorrectSelectBool == true)
        {
            characterM.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            characterM.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void NCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            characterN.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("n");
        }
        if (almostCorrectSelectBool == true)
        {
            characterN.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            characterN.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void OCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            characterO.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("o");
        }
        if (almostCorrectSelectBool == true)
        {
            characterO.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            characterO.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void PCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            characterP.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("p");
        }
        if (almostCorrectSelectBool == true)
        {
            characterP.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            characterP.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void QCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            characterQ.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("q");
        }
        if (almostCorrectSelectBool == true)
        {
            characterQ.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            characterQ.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void RCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            characterR.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("r");
        }
        if (almostCorrectSelectBool == true)
        {
            characterR.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            characterR.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void SCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            characterS.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("s");
        }
        if (almostCorrectSelectBool == true)
        {
            characterS.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            characterS.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void TCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            characterT.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("t");
        }
        if (almostCorrectSelectBool == true)
        {
            characterT.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            characterT.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void UCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            characterU.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("u");
        }
        if (almostCorrectSelectBool == true)
        {
            characterU.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            characterU.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void VCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            characterV.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("v");
        }
        if (almostCorrectSelectBool == true)
        {
            characterV.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            characterV.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void WCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            characterW.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("w");
        }
        if (almostCorrectSelectBool == true)
        {
            characterW.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            characterW.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void XCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            characterX.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("x");
        }
        if (almostCorrectSelectBool == true)
        {
            characterX.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            characterX.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void YCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            characterY.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("y");
        }
        if (almostCorrectSelectBool == true)
        {
            characterY.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            characterY.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void ZCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            characterZ.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("z");
        }
        if (almostCorrectSelectBool == true)
        {
            characterZ.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            characterZ.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void ZeroCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            character0.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("0");
        }
        if (almostCorrectSelectBool == true)
        {
            character0.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            character0.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void OneCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            character1.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("1");
        }
        if (almostCorrectSelectBool == true)
        {
            character1.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            character1.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void TwoCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            character2.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("2");
        }
        if (almostCorrectSelectBool == true)
        {
            character2.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            character2.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void ThreeCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            character3.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("3");
        }
        if (almostCorrectSelectBool == true)
        {
            character3.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            character3.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void FourCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            character4.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("4");
        }
        if (almostCorrectSelectBool == true)
        {
            character4.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            character4.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void FiveCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            character5.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("5");
        }
        if (almostCorrectSelectBool == true)
        {
            character5.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            character5.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void SixCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            character6.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("6");
        }
        if (almostCorrectSelectBool == true)
        {
            character6.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            character6.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void SevenCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            character7.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("7");
        }
        if (almostCorrectSelectBool == true)
        {
            character7.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            character7.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void EightCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            character8.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("8");
        }
        if (almostCorrectSelectBool == true)
        {
            character8.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            character8.GetComponent<Image>().color = wrongSelectOffC;
        }
    }

    public void NineCharacterColorChange()
    {
        if (correctSelectBool == true)
        {
            character9.GetComponent<Image>().color = correctSelectOffC;
            passwordGuess("9");
        }
        if (almostCorrectSelectBool == true)
        {
            character9.GetComponent<Image>().color = almostCorrectSelectOffC;
        }
        if (wrongSelectBool == true)
        {
            character9.GetComponent<Image>().color = wrongSelectOffC;
        }
    }
    
}
