using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class Path1_3_buttonClick1 : MonoBehaviour {

    private string[] current = new string[26] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
    private static int i = 1;
    private static int j = 1;
    private static int k = 1;
    private static int l = 1;

    public void OnTapButton1(Text text)
    {
        if (i < 26)
        {
            text.text = current[i];
        }
        else
        {
            i = 0;
            text.text = current[i];
        }
        i++;
    }

    public void OnTapButton2(Text text)
    {
        if (j < 26)
        {
            text.text = current[j];
        }
        else
        {
            j = 0;
            text.text = current[j];
        }
        j++;
    }

    public void OnTapButton3(Text text)
    {
        if (k < 26)
        {
            text.text = current[k];
        }
        else
        {
            k = 0;
            text.text = current[k];
        }
        k++;
    }

    public void OnTapButton4(Text text)
    {
        if (l < 26)
        {
            text.text = current[l];
        }
        else
        {
            l = 0;
            text.text = current[l];
        }
       l++;
    }
}
