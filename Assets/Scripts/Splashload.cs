using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splashload : MonoBehaviour {

    SpriteRenderer rend;
	void Start () {
        rend = GetComponent<SpriteRenderer>();
        Color c = rend.material.color;
        c.a = 0f;
        rend.material.color = c;
        if (SceneManager.GetActiveScene().buildIndex == 0)
            StartCoroutine(FadeIn());
    }
    IEnumerator FadeIn() {
        for (float f = 0.02f; f <= 1; f += 0.02f) {
            Color c = rend.material.color;
            c.a = f;
            rend.material.color = c;
            yield return new WaitForSeconds(0.05f);
        }
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("MainMenu");
    }
}
