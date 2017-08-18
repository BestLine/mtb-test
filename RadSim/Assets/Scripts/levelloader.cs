﻿using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelloader : MonoBehaviour {

    public GameObject loadingScreen;
    public Slider slider;

    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronuosly(sceneIndex));
    }

    IEnumerator LoadAsynchronuosly(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            yield return null;
        }
    }
}
