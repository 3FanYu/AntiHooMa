using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneOneTestMode : MonoBehaviour
{
    public GameObject Buttons;
    public GameObject pass;
    public GameObject Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8;
    
    int counter;
    GameObject A,B,C,D,E,F,G,H;

    private Vector3 p1,p2,p3,p4;
    private Vector3[] positions;
    // Start is called before the first frame update
    void Start()
    {
        p1 = new Vector3(-113, 92, 0);
        p2 = new Vector3(119, 92, 0);
        p3 = new Vector3(-113, -74, 0);
        p4 = new Vector3(121, -72, 0);
       
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

         D=Instantiate(Q4, new Vector3(0, 0, 20.73f), Quaternion.identity);

        StartCoroutine(ShowButton());
    }
    IEnumerator ShowButton()
    {
     
        yield return new WaitForSeconds(1.5f);
        
        Buttons.SetActive(true);

        GameObject.Find("Panel_Buttons/bt_1").GetComponentInChildren<Text>().text = "顏色漂亮、不同形狀的藥丸";
        GameObject.Find("Panel_Buttons/bt_2").GetComponentInChildren<Text>().text = "清澈透明的像水一樣裝在小瓶子中";
        GameObject.Find("Panel_Buttons/bt_3").GetComponentInChildren<Text>().text = "所有選項都是";
        GameObject.Find("Panel_Buttons/bt_4").GetComponentInChildren<Text>().text = "很像茶包或是咖啡包的東西";
        ReArrange();
    }
    public void Correct() {
        counter++;
        SoundManager.PlaySound("True");
        switch (counter) {
            case 2:
                Destroy(D);
                E = Instantiate(Q5, new Vector3(0, 0, 20.73f), Quaternion.identity);

                GameObject.Find("Panel_Buttons/bt_1").GetComponentInChildren<Text>().text = "勇敢說不要，語氣堅定";
                GameObject.Find("Panel_Buttons/bt_2").GetComponentInChildren<Text>().text = "告訴灰太郎毒品對健康的傷害";
                GameObject.Find("Panel_Buttons/bt_3").GetComponentInChildren<Text>().text = "不要拒絕他的好意，並一起服用一起玩";
                GameObject.Find("Panel_Buttons/bt_4").GetComponentInChildren<Text>().text = "告訴灰太郎吸毒是不對的行為，會被警察抓去處罰";
                ReArrange();
                break;



            case 3:
                Destroy(E);
                F = Instantiate(Q6, new Vector3(0, 0, 20.73f), Quaternion.identity);

                GameObject.Find("Panel_Buttons/bt_1").GetComponentInChildren<Text>().text = "和同學分享";
                GameObject.Find("Panel_Buttons/bt_2").GetComponentInChildren<Text>().text = "跟叔叔拿一顆試試看";
                GameObject.Find("Panel_Buttons/bt_3").GetComponentInChildren<Text>().text = "不要拿，並且向爸媽、老師或警察報告";
                GameObject.Find("Panel_Buttons/bt_4").GetComponentInChildren<Text>().text = "拿回家偷偷吃看看";
                ReArrange();
                break;
            case 4:
                Destroy(F);
                G = Instantiate(Q7, new Vector3(0, 0, 20.73f), Quaternion.identity);

                GameObject.Find("Panel_Buttons/bt_1").GetComponentInChildren<Text>().text = "毒品一定要在吸毒的聚會中才買的到";
                GameObject.Find("Panel_Buttons/bt_2").GetComponentInChildren<Text>().text = "小學生絕對不會碰到拿到毒品";
                GameObject.Find("Panel_Buttons/bt_3").GetComponentInChildren<Text>().text = "對來路不明的食物、飲料都要注意不能輕易嘗試";
                GameObject.Find("Panel_Buttons/bt_4").GetComponentInChildren<Text>().text = "咖啡包的包裝完整不會加毒品在裡面的";
                ReArrange();
                break;
            case 5:
                Destroy(G);
                H = Instantiate(Q8, new Vector3(0, 0, 20.73f), Quaternion.identity);

                GameObject.Find("Panel_Buttons/bt_1").GetComponentInChildren<Text>().text = "上網請網友幫忙";
                GameObject.Find("Panel_Buttons/bt_2").GetComponentInChildren<Text>().text = "不要告訴別人，免得被警察抓";
                GameObject.Find("Panel_Buttons/bt_3").GetComponentInChildren<Text>().text = "告訴家長及老師自己遇到的問題，請他們幫助自己";
                GameObject.Find("Panel_Buttons/bt_4").GetComponentInChildren<Text>().text = "私下告訴朋友，但是不要讓家長與老師知道";
                ReArrange();
                break;
            case 6:
                Destroy(H);
                Instantiate(pass, new Vector3(0, 0, 3.675f), Quaternion.identity);
                Destroy(GameObject.Find("WaveVRSceneOneTest/Event_Canvas"));
                SoundManager.PlaySound("Yay");
                break;
               
        }
    }
    public void Wrong() {
        SoundManager.PlaySound("False");

    }
    private void ReArrange() {
        int counter=0;
        int Rand;
        Rand = Random.Range(0, 4);
        List<int> list = new List<int>();
        positions = new Vector3[] {p1,p2,p3,p4};
        while (counter < 4)
        {
            while (list.Contains(Rand))
            {
                Rand = Random.Range(0, 4);
                
            }
            counter++;
            list.Add(Rand);
            print("counter="+counter);
            print("Rand=" + Rand);
            switch (counter)
            {

                case 1:
                    GameObject.Find("Panel_Buttons/bt_1").GetComponent<RectTransform>().anchoredPosition = positions[Rand];
                    list.Add(Rand);
                    break;
                case 2:
                    GameObject.Find("Panel_Buttons/bt_2").GetComponent<RectTransform>().anchoredPosition = positions[Rand];
                    list.Add(Rand);
                    break;
                case 3:
                    GameObject.Find("Panel_Buttons/bt_3").GetComponent<RectTransform>().anchoredPosition = positions[Rand];
                    list.Add(Rand);
                    break;
                case 4:
                    GameObject.Find("Panel_Buttons/bt_4").GetComponent<RectTransform>().anchoredPosition = positions[Rand];
                    list.Add(Rand);
                    break;
            }
        }


    }
  
}
