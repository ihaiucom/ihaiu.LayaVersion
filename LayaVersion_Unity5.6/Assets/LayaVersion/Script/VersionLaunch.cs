using FairyGUI;
using LayaVersion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VersionLaunch : MonoBehaviour
{
    UIVersionWindow window;

    void Awake()
    {
#if UNITY_WEBPLAYER || UNITY_WEBGL || UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX || UNITY_EDITOR
        CopyPastePatch.Apply();
#endif

        //Use the font names directly
        UIConfig.defaultFont = "Microsoft YaHei";


        UIPackage.AddPackage("UI/BlackSkin");
        UIPackage.AddPackage("UI/LayaVersion");
        LayaVersionBinder.BindAll();
    }


    void Start()
    {

        window = (UIVersionWindow) this.GetComponent<UIPanel>().ui;
        window.Init();

    }
}
