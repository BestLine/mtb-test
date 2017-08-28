using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {
	void goExit (bool go) {
        if (go)
            Application.Quit();
    }
}
