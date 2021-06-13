using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public static class Loader
{
    public enum Scene {GameScene}
    public static void Load(Scene _scene)
    {
        Debug.Log("I'm inside Load < class Loader < Loader.cs");
        //SceneManager.LoadScene(_scene.ToString());
    }
}