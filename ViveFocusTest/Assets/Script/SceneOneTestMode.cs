using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneOneTestMode : MonoBehaviour
{
    public GameObject Buttons;
    public GameObject pass;
    public GameObject Q1;
    public GameObject Q2;
    public GameObject Q3;
    int counter;
    GameObject A;
    GameObject B;
    GameObject C;

    // Start is called before the first frame update
    void Start()
    {
        counter = 1;
        StartCoroutine(Fade(4.0f));
        

        //StartCoroutine(BeginTest());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Fade(float sec)
    {
        GameObject.Find("fader").GetComponent<Fader>().FadeOut();
        yield return new WaitForSeconds(sec);    
    }
    public void BeginTest() {
        SoundManager.PlaySound("Click");
        Destroy(GameObject.Find("測驗開始"));

         A=Instantiate(Q1, new Vector3(0, 0, 20.73f), Quaternion.identity);

        StartCoroutine(ShowButton());
    }
    IEnumerator ShowButton()
    {
        yield return new WaitForSeconds(1.5f);
        Buttons.SetActive(true);
        GameObject.Find("Panel_Buttons/bt_1").GetComponentInChildren<Text>().text = "向同學分享";
        GameObject.Find("Panel_Buttons/bt_2").GetComponentInChildren<Text>().text = "跟叔叔拿一顆吃";
        GameObject.Find("Panel_Buttons/bt_3").GetComponentInChildren<Text>().text = "不要拿，並且向父母、老師或警察報告";
        GameObject.Find("Panel_Buttons/bt_4").GetComponentInChildren<Text>().text = "拿回家偷偷嚐";

    }
    public void Correct() {
        counter++;
        SoundManager.PlaySound("True");
        switch (counter) {
            case 2:
                Destroy(A);
                //Destroy(GameObject.Find("Q1-1"));
                 B=Instantiate(Q2, new Vector3(0, 0, 20.73f), Quaternion.identity);
                GameObject.Find("Panel_Buttons/bt_1").GetComponentInChildren<Text>().text = "甲乙丙";
                GameObject.Find("Panel_Buttons/bt_2").GetComponentInChildren<Text>().text = "甲乙丁";
                GameObject.Find("Panel_Buttons/bt_3").GetComponentInChildren<Text>().text = "甲乙丙丁";
                GameObject.Find("Panel_Buttons/bt_4").GetComponentInChildren<Text>().text = "乙丙丁";
                break;
            case 3:
                Destroy(B);
                C=Instantiate(Q3, new Vector3(0, 0, 20.73f), Quaternion.identity);
                GameObject.Find("Panel_Buttons/bt_1").GetComponentInChildren<Text>().text = "甲乙丙";
                GameObject.Find("Panel_Buttons/bt_2").GetComponentInChildren<Text>().text = "甲乙丙丁戊";
                GameObject.Find("Panel_Buttons/bt_3").GetComponentInChildren<Text>().text = "甲乙丙丁";
                GameObject.Find("Panel_Buttons/bt_4").GetComponentInChildren<Text>().text = "乙丙丁戊";
                break;
            case 4:
                Destroy(C);
                Instantiate(pass, new Vector3(0, 0, 3.675f), Quaternion.identity);
                Destroy(GameObject.Find("WaveVRSceneOneTest/Event_Canvas"));
                SoundManager.PlaySound("Yay");
                break;
        }
    }
    public void Wrong() {
        SoundManager.PlaySound("False");

    }
  
}
