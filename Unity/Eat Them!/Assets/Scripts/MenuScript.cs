﻿using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenScene()
    {
        //SceneManager.LoadScene (1);
        Application.LoadLevel(1);
    }
}
