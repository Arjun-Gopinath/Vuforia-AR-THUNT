using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class Path1_3_Padlock1 : MonoBehaviour {

    const string pass_code = "IEEE";
    string code_typed = "";
    public Button mbutton;
    public Text button_3;
    public Text button_1;
    public Text button_2;
    public Text button_4;

    void Start()
    {
        mbutton.interactable = false;

    }

    void Update()
    {
        code_typed = button_1.text + button_2.text + button_3.text + button_4.text;
        if (code_typed == pass_code)
        {
            mbutton.interactable = true;
        }
        else
        {
            mbutton.interactable = false;
        }
    }
}
