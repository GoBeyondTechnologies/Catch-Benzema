using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;

public class MainScript : MonoBehaviour
{

    public GameObject benzema;
    public GameObject player;
    public Text speedtext;

   

    public float benzemaspeed;
    public float playerspeed;

    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        benzemaspeed = benzema.GetComponent<ThirdPersonUserControl>().speed;
        playerspeed = player.GetComponent<ThirdPersonUserControl>().speed;

        speedtext.text = benzemaspeed.ToString() + "\n" + playerspeed.ToString();
    }

    public void updatespeed()
    {
        player.GetComponent<ThirdPersonUserControl>().changespeed(0.01f);
    }
}
