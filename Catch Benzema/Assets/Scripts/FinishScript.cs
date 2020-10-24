using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour
{
    public GameObject benzema;
    public GameObject player;

    public Text wintext;
    public Text losetext;

    public GameObject lvldata;


    private bool hasended = false;


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



    }

    void finishbenzemawin()
    {
        Debug.Log("Benzema Won");
        Debug.Log(lvldata.GetComponent<LevelData>().getlevel());

        lvldata.GetComponent<LevelData>().restartlevels();

        benzema.GetComponent<ThirdPersonUserControl>().disablestart();
        player.GetComponent<ThirdPersonUserControl>().disablestart();

        losetext.gameObject.SetActive(true);
        Invoke("restartscene", 2);
    }


    void finishplayerwin()
    {
        Debug.Log("player won");
        Debug.Log(lvldata.GetComponent<LevelData>().getlevel());
        lvldata.GetComponent<LevelData>().nextlevel();

        benzema.GetComponent<ThirdPersonUserControl>().disablestart();
        player.GetComponent<ThirdPersonUserControl>().disablestart();

        wintext.gameObject.SetActive(true);
        Invoke("restartscene", 2);

    }

    void restartscene()
    {
        Debug.Log("restart");
        SceneManager.LoadScene("MainScene");
        
    }

 
}



