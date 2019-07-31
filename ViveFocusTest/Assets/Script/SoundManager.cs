using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip CarCrash, FootStep, clip1, clip2, clip3, clip4, clip5, clip6, clip7, clip8, clip9,
        clip10, clip11, clip12, clip13, clip14, clip15, clip16, clip17, clip18, clip19, clip20, clip21, clip22, clip23, clip24,
        clip25, clip26, clip27, clip28, clip29, clip30, clip31, True, False, Click, Yay, Title1, Sad, BGM;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        CarCrash = Resources.Load<AudioClip>("CarCrash");
        FootStep = Resources.Load<AudioClip>("walkingSound");

        Sad = Resources.Load<AudioClip>("Sad");
        Title1 = Resources.Load<AudioClip>("前言");
        True= Resources.Load<AudioClip>("True");
        False = Resources.Load<AudioClip>("False");
        Click= Resources.Load<AudioClip>("Click");
        Yay= Resources.Load<AudioClip>("YAY");

        clip1 = Resources.Load<AudioClip>("Scene1/1");
        clip2 = Resources.Load<AudioClip>("Scene1/2");
        clip3 = Resources.Load<AudioClip>("Scene1/3");
        clip4 = Resources.Load<AudioClip>("Scene1/4");
        clip5 = Resources.Load<AudioClip>("Scene1/5");
        clip6 = Resources.Load<AudioClip>("Scene1/6");
        clip7 = Resources.Load<AudioClip>("Scene1/7");
        clip8 = Resources.Load<AudioClip>("Scene1/8");
        clip9 = Resources.Load<AudioClip>("Scene1/9");
        clip10 = Resources.Load<AudioClip>("Scene1/10");
        clip11 = Resources.Load<AudioClip>("Scene1/11");
        clip12 = Resources.Load<AudioClip>("Scene1/12");
        clip13 = Resources.Load<AudioClip>("Scene1/13");
        clip14 = Resources.Load<AudioClip>("Scene1/14");
        clip15 = Resources.Load<AudioClip>("Scene1/15");
        clip16 = Resources.Load<AudioClip>("Scene1/16");
        clip17 = Resources.Load<AudioClip>("Scene1/17");
        clip18 = Resources.Load<AudioClip>("Scene1/18");
        clip19 = Resources.Load<AudioClip>("Scene1/19");
        clip20 = Resources.Load<AudioClip>("Scene1/20");
        clip21 = Resources.Load<AudioClip>("Scene1/21");
        clip22 = Resources.Load<AudioClip>("Scene1/22");
        clip23 = Resources.Load<AudioClip>("Scene1/23");
        clip24 = Resources.Load<AudioClip>("Scene1/24");
        clip25 = Resources.Load<AudioClip>("Scene1/25");
        clip26 = Resources.Load<AudioClip>("Scene1/26");
        clip27 = Resources.Load<AudioClip>("Scene1/27");
        clip28 = Resources.Load<AudioClip>("Scene1/28");
        clip29 = Resources.Load<AudioClip>("Scene1/29");
        clip30 = Resources.Load<AudioClip>("Scene1/30");
        clip31 = Resources.Load<AudioClip>("Scene1/31");

        BGM = Resources.Load<AudioClip>("bgm");


        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Sad":
                audioSrc.PlayOneShot(Sad);
                break;
            case "Title1":
                audioSrc.PlayOneShot(Title1);
                break;
            case "Yay":
                audioSrc.PlayOneShot(Yay);
                break;
            case "Click":
                audioSrc.PlayOneShot(Click);
                break;
            case "True":
                audioSrc.PlayOneShot(True);
                break;
            case "False":
                audioSrc.PlayOneShot(False);
                break;
            case "CarCrash":
                audioSrc.PlayOneShot(CarCrash);
                break;
            case "FootStep":
                audioSrc.PlayOneShot(FootStep);
                break;
            case "clip1":
                audioSrc.PlayOneShot(clip1);
                break;
            case "clip2":
                audioSrc.PlayOneShot(clip2);
                break;
            case "clip3":
                audioSrc.PlayOneShot(clip3);
                break;
            case "clip4":
                audioSrc.PlayOneShot(clip4);
                break;
            case "clip5":
                audioSrc.PlayOneShot(clip5);
                break;
            case "clip6":
                audioSrc.PlayOneShot(clip6);
                break;
            case "clip7":
                audioSrc.PlayOneShot(clip7);
                break;
            case "clip8":
                audioSrc.PlayOneShot(clip8);
                break;
            case "clip9":
                audioSrc.PlayOneShot(clip9);
                break;
            case "clip10":
                audioSrc.PlayOneShot(clip10);
                break;
            case "clip11":
                audioSrc.PlayOneShot(clip11);
                break;
            case "clip12":
                audioSrc.PlayOneShot(clip12);
                break;
            case "clip13":
                audioSrc.PlayOneShot(clip13);
                break;
            case "clip14":
                audioSrc.PlayOneShot(clip14);
                break;
            case "clip15":
                audioSrc.PlayOneShot(clip15);
                break;
            case "clip16":
                audioSrc.PlayOneShot(clip16);
                break;
            case "clip17":
                audioSrc.PlayOneShot(clip17);
                break;
            case "clip18":
                audioSrc.PlayOneShot(clip18);
                break;
            case "clip19":
                audioSrc.PlayOneShot(clip19);
                break;
            case "clip20":
                audioSrc.PlayOneShot(clip20);
                break;
            case "clip21":
                audioSrc.PlayOneShot(clip21);
                break;
            case "clip22":
                audioSrc.PlayOneShot(clip22);
                break;
            case "clip23":
                audioSrc.PlayOneShot(clip23);
                break;
            case "clip24":
                audioSrc.PlayOneShot(clip24);
                break;
            case "clip25":
                audioSrc.PlayOneShot(clip25);
                break;
            case "clip26":
                audioSrc.PlayOneShot(clip26);
                break;
            case "clip27":
                audioSrc.PlayOneShot(clip27);
                break;
            case "clip28":
                audioSrc.PlayOneShot(clip28);
                break;
            case "clip29":
                audioSrc.PlayOneShot(clip29);
                break;
            case "clip30":
                audioSrc.PlayOneShot(clip30);
                break;
            case "clip31":
                audioSrc.PlayOneShot(clip31);
                break;
          
        }
    }
}
