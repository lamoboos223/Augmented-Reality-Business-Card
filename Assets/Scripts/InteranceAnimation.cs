using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using TMPro;


public class InteranceAnimation : MonoBehaviour
{
    public Animator Quad;

    public TextMeshPro textMeshPro;

    int frame = 0;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro.color = new Color(textMeshPro.color.r, textMeshPro.color.g, textMeshPro.color.b, 0.0f);

    }

    // Update is called once per frame
    void Update()
    {
        frame++;
        SlideText();
    }


    private void SlideText()
    {
        if (frame == 400)
        {
            //textMeshPro.text = "Interested ?\nCall me =\t";
            StartCoroutine(FadeTextFromZeroAlpha(1f, textMeshPro));
        }
    }


    #region "Fade In/Out"
    public IEnumerator FadeTextToZeroAlpha(float t, TextMeshPro i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
    }

    public IEnumerator FadeTextFromZeroAlpha(float t, TextMeshPro i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime * t));
            yield return null;
        }
    }
    #endregion

    #region "functions i could use one day"
    public IEnumerator FadeTextToFullAlpha(float t, TextMeshPro i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
    }


    //if (Input.GetKeyDown(KeyCode.Q))
    //{
    //    StartCoroutine(FadeTextToFullAlpha(1f, textMeshPro));
    //}
    //if (Input.GetKeyDown(KeyCode.E))
    //{
    //    StartCoroutine(FadeTextToZeroAlpha(1f, textMeshPro));
    //}



    #endregion


}

