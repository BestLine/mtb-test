using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartZoneSc : MonoBehaviour {

   



    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.tag == "ResZone")
        
            SceneManager.LoadScene("mainLevel");



    }
        }
