﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUiMAnager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene("LevelOne");
    }
}
