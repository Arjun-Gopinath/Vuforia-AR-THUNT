using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class ChangeCam : MonoBehaviour {

    private float load = 5f;
    void Start () {
        StartCoroutine(Load());
    }

    IEnumerator Load()
    {
        yield return new WaitForSeconds(load);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
