using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowFPS : MonoBehaviour
{
    public static float fps;
    GUIStyle style = new GUIStyle();

    private void Start()
    {
        style.normal.textColor = Color.yellow;
        style.fontStyle = FontStyle.Bold;
    }

    void OnGUI()
    {
        style.normal.textColor = Color.yellow;
        style.fontStyle = FontStyle.Bold;
        fps = 1.0f / Time.deltaTime;
        //GUILayout.Label("" + (int)fps, style);        
    }
}
