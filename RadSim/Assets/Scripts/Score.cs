using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public new Transform transform;
    public Text text;
    int score;

    void FixedUpdate()
    {
        score = (int)transform.position.x;
        text.text = "Score: " + score;
    }
}
