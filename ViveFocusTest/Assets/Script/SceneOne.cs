using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneOne : MonoBehaviour
{

    public Transform map1, map2, map3, map4, map5, map6, map7, map8, map9, map10;
    public GameObject SceneOneEnding;

   
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(First("FootStep"));  
        
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
    IEnumerator First(string sound)
    {

        GameObject.Find("fader").GetComponent<Fader>().FadeOut();
        yield return new WaitForSeconds(3.0f);
        
        GameObject.Find("fader").GetComponent<Fader>().FadeIn();
        yield return new WaitForSeconds(3.0f);
        this.GetComponent<MoveCam>().TeleportToDestination(map1);
        GameObject.Find("fader").GetComponent<Fader>().FadeOut();
        SoundManager.PlaySound("Title1");
        yield return new WaitForSeconds(5.0f);
        SoundManager.PlaySound(sound);
        yield return new WaitForSeconds(SoundManager.FootStep.length);
        this.GetComponent<MoveCam>().TeleportToDestination(map2);
        yield return new WaitForSeconds(2.0f);
        this.GetComponent<MoveCam>().TeleportToDestination(map3);
        SoundManager.PlaySound("clip1");
        yield return new WaitForSeconds(SoundManager.clip1.length);
        SoundManager.PlaySound("clip2");
        yield return new WaitForSeconds(SoundManager.clip2.length);
        SoundManager.PlaySound("clip3");
        yield return new WaitForSeconds(SoundManager.clip3.length);
        SoundManager.PlaySound("clip4");
        yield return new WaitForSeconds(SoundManager.clip4.length);
        SoundManager.PlaySound("clip5");
        yield return new WaitForSeconds(SoundManager.clip5.length);
        SoundManager.PlaySound("clip6");
        yield return new WaitForSeconds(SoundManager.clip6.length);
        this.GetComponent<MoveCam>().TeleportToDestination(map4);
        SoundManager.PlaySound("clip7");
        yield return new WaitForSeconds(SoundManager.clip7.length);


        SoundManager.PlaySound("clip8");
        yield return new WaitForSeconds(SoundManager.clip8.length);
        this.GetComponent<MoveCam>().TeleportToDestination(map5);
        SoundManager.PlaySound("clip9");
        yield return new WaitForSeconds(SoundManager.clip9.length);
        SoundManager.PlaySound("clip10");
        yield return new WaitForSeconds(SoundManager.clip10.length);
        this.GetComponent<MoveCam>().TeleportToDestination(map6);
        SoundManager.PlaySound("clip11");
        yield return new WaitForSeconds(SoundManager.clip11.length);
        SoundManager.PlaySound("clip12");
        yield return new WaitForSeconds(SoundManager.clip12.length);
        SoundManager.PlaySound("clip13");
        yield return new WaitForSeconds(SoundManager.clip13.length);
        SoundManager.PlaySound("clip14");
        yield return new WaitForSeconds(SoundManager.clip14.length);
        SoundManager.PlaySound("clip15");
        yield return new WaitForSeconds(SoundManager.clip15.length);
        SoundManager.PlaySound("clip16");
        yield return new WaitForSeconds(SoundManager.clip16.length);
        SoundManager.PlaySound("clip17");
        yield return new WaitForSeconds(SoundManager.clip17.length);
        SoundManager.PlaySound("clip18");
        yield return new WaitForSeconds(SoundManager.clip18.length);
        SoundManager.PlaySound("clip19");
        yield return new WaitForSeconds(SoundManager.clip19.length);
        this.GetComponent<MoveCam>().TeleportToDestination(map7);
        SoundManager.PlaySound("clip20");
        yield return new WaitForSeconds(SoundManager.clip20.length);
        SoundManager.PlaySound("clip21");
        yield return new WaitForSeconds(SoundManager.clip21.length);
        SoundManager.PlaySound("clip22");
        yield return new WaitForSeconds(SoundManager.clip22.length);
        SoundManager.PlaySound("clip23");
        yield return new WaitForSeconds(SoundManager.clip23.length);
        SoundManager.PlaySound("clip24");
        yield return new WaitForSeconds(SoundManager.clip24.length);
        SoundManager.PlaySound("clip25");
        yield return new WaitForSeconds(SoundManager.clip25.length);
        SoundManager.PlaySound("clip26");
        yield return new WaitForSeconds(SoundManager.clip26.length);
        SoundManager.PlaySound("clip27");
        yield return new WaitForSeconds(SoundManager.clip27.length);
        this.GetComponent<MoveCam>().TeleportToDestination(map8);
        SoundManager.PlaySound("clip28");
        yield return new WaitForSeconds(SoundManager.clip28.length);




        GameObject.Find("fader").GetComponent<Fader>().FadeIn();
        yield return new WaitForSeconds(2.0f);
        StartCoroutine(Second());

    }
    IEnumerator Second()
    {
        yield return new WaitForSeconds(2.0f);
        GameObject.Find("fader").GetComponent<Fader>().FadeOut();
        this.GetComponent<MoveCam>().TeleportToDestination(map9);
        yield return new WaitForSeconds(2.0f);
        SoundManager.PlaySound("clip29");
        yield return new WaitForSeconds(SoundManager.clip29.length);
        this.GetComponent<MoveCam>().TeleportToDestination(map10);
        SoundManager.PlaySound("clip30");
        yield return new WaitForSeconds(SoundManager.clip30.length);
        SoundManager.PlaySound("clip31");
        yield return new WaitForSeconds(SoundManager.clip31.length);
        SceneOneEnding.SetActive(true);
        SoundManager.PlaySound("Sad");
        yield return new WaitForSeconds((SoundManager.Sad.length)-2f);



        GameObject.Find("fader").GetComponent<Fader>().FadeIn();
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("裹著糖衣測驗", LoadSceneMode.Single);

    }

    }
