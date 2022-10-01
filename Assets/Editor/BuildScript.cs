using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BuildScript 
{
    static void PerformBuildAndroid()
    {
        string[] defaultScene = { 
            "Assets/Scenes/SampleScene.unity"
            };

        BuildPipeline.BuildPlayer(defaultScene, "MyGame.apk" ,
            BuildTarget.Android, BuildOptions.None);
    }

    static void PerformBuildWeb()
    {
        string[] defaultScene = {
            "Assets/Scenes/SampleScene.unity"
            };

        BuildPipeline.BuildPlayer(defaultScene, "Web" ,
            BuildTarget.WebGL, BuildOptions.None);
    }

}

