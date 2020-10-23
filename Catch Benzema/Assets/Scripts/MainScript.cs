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

    public Text CountDownText;
    private int countdownindex;
    private bool finishflag;


    public Button playbtn;

    public Button buttonright;
    public Button buttonleft;

    private bool hasended = false;

    public float benzemaspeed;
    public float playerspeed;

    // Start is called before the first frame update
    void Start()
    {
        //Time.timeScale = 0;

        wintext.gameObject.SetActive(false);
        losetext.gameObject.SetActive(false);
        CountDownText.gameObject.SetActive(false);

        buttonright.gameObject.SetActive(false);
        buttonleft.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (benzema.transform.position.z > 54 && hasended == false) //finish if benzema is at finish line
        {
            hasended = true;
            finishbenzemawin();
        }
        if (benzema.transform.position.z < player.transform.position.z && hasended == false) //finish if player succeeded
        {
            hasended = true;
            finishplayerwin();
        }

        benzemaspeed = benzema.GetComponent<ThirdPersonUserControl>().speed;
        playerspeed = player.GetComponent<ThirdPersonUserControl>().speed;



    }



    public void startgame()
    {
        //Time.timeScale = 1;
        playbtn.gameObject.SetActive(false);
        Debug.Log("start countdown");
        Invoke("countdown", 1f);
      
    }

    void countdown ()
    {
        //Time.timeScale = 1;
        Debug.Log("start");
        buttonright.gameObject.SetActive(true);

        benzema.GetComponent<ThirdPersonUserControl>().enablestart();
        player.GetComponent<ThirdPersonUserControl>().enablestart();

        //Invoke("finishbenzemawin", 3);

    }

    void finishbenzemawin()
    {
        Debug.Log("benzema won");
        benzema.GetComponent<ThirdPersonUserControl>().disablestart();
        player.GetComponent<ThirdPersonUserControl>().disablestart();

        losetext.gameObject.SetActive(true);
        Invoke("restartscene", 2);
    }
    

    void finishplayerwin()
    {
        Debug.Log("player won");

        wintext.gameObject.SetActive(true);
        Invoke("restartscene", 2);

    }

    void restartscene()
    {
        SceneManager.LoadScene("MainScene");
        Debug.Log("restart");
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
