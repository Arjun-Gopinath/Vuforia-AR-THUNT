using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Checkpass : MonoBehaviour {

    private string password= "aryabhata";
    public Text mpassword;
    public AudioSource audio;
    public void Checkpassword() {
        if (mpassword.text == password)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else {
            audio.Play();
        }
    }
}
