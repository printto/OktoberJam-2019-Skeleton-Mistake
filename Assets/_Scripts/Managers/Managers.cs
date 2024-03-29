﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers
{
    public static Managers Instance;
    public UIManager m_UIManager;
    public CameraShake m_CameraShake;
    public Managers()
    {
        m_UIManager = new UIManager();
        m_CameraShake = new CameraShake();

        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void Start(GameObject parentCanvas)
    {
        m_UIManager.Start(parentCanvas);
        m_CameraShake.Start(parentCanvas);
    }

    public void Update()
    {
        m_UIManager.Update();
        m_CameraShake.Update();
    }
}
