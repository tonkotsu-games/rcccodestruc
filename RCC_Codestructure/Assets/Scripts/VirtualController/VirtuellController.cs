using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class VirtuellController : MonoBehaviour
{
    IProvider inputProvider;
    InputPackage inputPackage;

    [SerializeField] List<Texture2D> controller;


    bool debugOn = true;

    private void Awake()
    {
        inputProvider = gameObject.GetComponent<PlayerInput>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F4))
        {
            debugOn = !debugOn;
        }
    }

    private void OnGUI()
    {
        inputPackage = inputProvider.GetPackage();

        if (debugOn)
        {
            GUIStyle style = new GUIStyle(EditorStyles.textField);
            style.normal.textColor = Color.red;
            style.fontSize = 30;

            GUI.DrawTexture(new Rect(35, 100, 455, 275), controller[0]);
            GUI.DrawTexture(new Rect(115, 150, 70, 70), controller[1]);
            GUI.DrawTexture(new Rect(130, 165, 40, 40), controller[2]);
            GUI.DrawTexture(new Rect(280, 215, 70, 70), controller[1]);
            GUI.DrawTexture(new Rect(295, 230, 40, 40), controller[2]);
            GUI.DrawTexture(new Rect(170, 210, 70, 70), controller[3]);
            GUI.DrawTexture(new Rect(335, 170, 30, 30), controller[8]);
            GUI.DrawTexture(new Rect(365, 195, 30, 30), controller[8]);
            GUI.DrawTexture(new Rect(395, 170, 30, 30), controller[8]);
            GUI.DrawTexture(new Rect(365, 140, 30, 30), controller[8]);
            GUI.DrawTexture(new Rect(220, 175, 20, 20), controller[9]);
            GUI.DrawTexture(new Rect(280, 175, 20, 20), controller[9]);
            GUI.DrawTexture(new Rect(245, 120, 30, 30), controller[10]);
            GUI.DrawTexture(new Rect(110, 65, 75, 40), controller[11]);
            GUI.DrawTexture(new Rect(335, 65, 75, 40), controller[12]);
            GUI.DrawTexture(new Rect(130, 10, 50, 65), controller[13]);
            GUI.DrawTexture(new Rect(340, 10, 50, 65), controller[14]);

            //GUILayout.Label("Horizontal Movement: " + inputPackage.MoveHorizontal.ToString(), style);
            //GUILayout.Label("Vertical Movement: " + inputPackage.MoveVertical.ToString(), style);
            //GUILayout.Label("Trigger Left: " + inputPackage.TriggerLeft.ToString(), style);
            //GUILayout.Label("Trigger Right: " + inputPackage.TriggerRight.ToString(), style);
            //GUILayout.Label("Cross Horizontal: " + inputPackage.CrossHorizontal, style);
            //GUILayout.Label("Cross Vertical: " + inputPackage.CrossVertical, style);
            //GUILayout.Label("Camera Horizontal: " + inputPackage.CameraHorizontal, style);
            //GUILayout.Label("Camera Vertical: " + inputPackage.CameraVertical, style);
            //GUILayout.Label("Left Bumper: " + inputPackage.BumberLeft, style);
            //GUILayout.Label("Right Bumper: " + inputPackage.BumberRight, style);
            //GUILayout.Label("X: " + inputPackage.InputX, style);
            //GUILayout.Label("A: " + inputPackage.InputA, style);
            //GUILayout.Label("B: " + inputPackage.InputB, style);
            //GUILayout.Label("Y: " + inputPackage.InputY, style);
            //GUILayout.Label("Start: " + inputPackage.StartButton, style);
            //GUILayout.Label("Select: " + inputPackage.SelectButton, style);
            //GUILayout.Label("Move Button: " + inputPackage.MoveButton, style);
            //GUILayout.Label("Camera Button: " + inputPackage.CameraButton, style);
        }
    }
}