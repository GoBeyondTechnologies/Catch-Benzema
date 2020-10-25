using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine.SceneManagement;

public class MainScript : MonoBehaviour
{

    public GameObject benzema;
    public GameObject player;

    public Text wintext;
    public Text losetext;
    public Text leveltext;
    public GameObject lvldata;

    public Button playbtn;

    public Button buttonright;
    public Button buttonleft;


    AudioSource refereewhistle;

    // Start is called before the first frame update
    void Start()
    {
        refereewhistle = GetComponent<AudioSource>();
        leveltext.text = "Level: " + (lvldata.GetComponent<LevelData>().getlevel()+1).ToString();
        wintext.gameObject.SetActive(false);
        losetext.gameObject.SetActive(false);

        buttonright.gameObject.SetActive(false);
        buttonleft.gameObject.SetActive(false);
    }



    public void startgame()
    {
        playbtn.gameObject.SetActive(false);
        //Debug.Log("start countdown");
        refereewhistle.Play();

        Invoke("countdown", 1f);
      
    }

    void countdown ()
    {
        //Debug.Log("start");
        buttonright.gameObject.SetActive(true);
        benzema.GetComponent<ThirdPersonUserControl>().enablestart();
        player.GetComponent<ThirdPersonUserControl>().enablestart();

    }
  
    public void updatespeed()
    {
        player.GetComponent<ThirdPersonUserControl>().changespeed(0.01f);
    }

    public void changeRightButtonactivation()
    {
        buttonright.gameObject.SetActive(false);
        buttonleft.gameObject.SetActive(true);

    }
    public void changeLeftButtonactivation()
    {
        buttonright.gameObject.SetActive(true);
        buttonleft.gameObject.SetActive(false);
    }
}
