using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;

public class MainScript : MonoBehaviour
{

    public GameObject benzema;
    public GameObject player;

    public Text wintext;
    public Text losetext;



    public Button buttonright;
    public Button buttonleft;

    private bool hasended = false;

    public float benzemaspeed;
    public float playerspeed;

    // Start is called before the first frame update
    void Start()
    {
        wintext.gameObject.SetActive(false);
        losetext.gameObject.SetActive(false);
        changeLeftButtonactivation();

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

    void finishbenzemawin()
    {
        Debug.Log("benzema won");
        Time.timeScale = 0;
        losetext.gameObject.SetActive(true);
    }

    void finishplayerwin()
    {
        Debug.Log("player won");
        Time.timeScale = 0;
        wintext.gameObject.SetActive(true);
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
