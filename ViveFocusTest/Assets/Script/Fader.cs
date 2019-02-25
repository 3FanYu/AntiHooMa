using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fader : MonoBehaviour
{
    public int fadeSpeed = 3;
    private bool isDone = true;
    private Color matCol;
    private Color newColor;
    private float alfa = 0;
    bool x = true;
    // Start is called before the first frame update
    void Start()
    {
        matCol = GetComponent<Renderer>().material.color;
        
    }

        // Update is called once per frame
        void Update()
        {
            if (!isDone)
            {
                alfa = GetComponent<Renderer>().material.color.a - Time.deltaTime / (fadeSpeed == 0 ? 1 : fadeSpeed);
                newColor = new Color(matCol.r, matCol.g, matCol.b, alfa);
                GetComponent<Renderer>().material.SetColor("_Color", newColor);
                isDone = alfa <= 0 ? true : false;
            }
            if (!x) {
                alfa = GetComponent<Renderer>().material.color.a + Time.deltaTime / (fadeSpeed == 0 ? 1 : fadeSpeed);
                newColor = new Color(matCol.r, matCol.g, matCol.b, alfa);
                GetComponent<Renderer>().material.SetColor("_Color", newColor);
                Debug.Log(alfa);
                x = alfa >=1 ? true : false;            
        }
        }
    IEnumerator StartFade()
    {
        
        isDone = false ;
        yield return new WaitForSeconds(1.0f);
    }
    IEnumerator StartFadeIn()
    {

        x = false;
        yield return new WaitForSeconds(1.0f);
    }
    public void FadeIn() {
        
        StartCoroutine(StartFadeIn());

    }
    public void FadeOut()
    {
        StartCoroutine(StartFade());
    }
}


