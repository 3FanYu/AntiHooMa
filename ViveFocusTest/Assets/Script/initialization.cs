using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class initialization : MonoBehaviour
{
    // Start is called before the first frame update
    public Button bt1;
    public Button bt2;
    public  GameObject Tips;
    private int counter;
    public Transform[] map;
    public string[] bt1_Text;
    public string[] bt2_Text;

    void Start()
    {
        begin();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void begin() {
        counter = 0;
        bt1.gameObject.SetActive(true);
        bt2.gameObject.SetActive(true);
        bt1.GetComponentInChildren<Text>().text = bt1_Text[counter];
        bt2.GetComponentInChildren<Text>().text = bt2_Text[counter];
        this.GetComponent<MoveCam>().TeleportToDestination(map[counter]);
    }
    public void bt1_click() {
        counter++;
        if (counter == 4)
        {
            bt2.gameObject.SetActive(false);
            this.GetComponent<MoveCam>().MoveToDestination(map[counter]);
            bt1.GetComponentInChildren<Text>().text = bt1_Text[counter];
            return;
        }
        else if (counter == 5) {
            begin();
            return;
        }
       
        this.GetComponent<MoveCam>().MoveToDestination(map[counter]);
        bt1.GetComponentInChildren<Text>().text = bt1_Text[counter];
        bt2.GetComponentInChildren<Text>().text = bt2_Text[counter];
    }
    public void bt2_click() {
        switch (counter) {
            case 0:
                
                StartCoroutine(Restart(2.0f));
                break;
            case 1:
                
                StartCoroutine(Restart(2.0f));
                break;
            case 2:
                this.GetComponent<MoveCam>().MoveToDestination(map[5]);
                StartCoroutine(Restart(4.0f));
                break;
            case 3:

                StartCoroutine(Restart(2.0f));
                break;
            case 4:

                StartCoroutine(Restart(2.0f));
                break;
        }
        
    }
    public void died() {
       
    }
    IEnumerator Restart(float sec)
    {
        SoundManager.PlaySound("CarCrash");
        yield return new WaitForSeconds(2.0f);
        Color White = Color.white;
        White.a = 0.5f;
        Tips.GetComponentInChildren<Text>().text = "YOU DIED";
        Tips.GetComponentInChildren<Text>().color = Color.black;
        Tips.GetComponent<Image>().color = Color.red;
        yield return new WaitForSeconds(sec);
        Tips.GetComponentInChildren<Text>().text = "找找天麒在哪裡";
        Tips.GetComponentInChildren<Text>().color = Color.yellow;
        Tips.GetComponent<Image>().color = White;
      
        begin();
    }
    IEnumerator PlaySound(string sound)
    {
        SoundManager.PlaySound(sound);
        yield return new WaitForSeconds(2.0f);
    }
}
