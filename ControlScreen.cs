using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class ControlScreen : MonoBehaviour
{
    private Button pauseButton;
    private Button upButton;
    private Button downButton;

    private void Awake()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        pauseButton = root.Q<Button>("PauseButton");
        upButton = root.Q<Button>("UpControlButton");
        downButton = root.Q<Button>("DownControlButton");

        pauseButton.clicked += PauseButtonPressed;
        upButton.clicked += UpControlButtonPressed;
        downButton.clicked += DownControlButtonPressed;
    }

    private void PauseButtonPressed() => FindObjectOfType<PauseScreen>(true).OpenPauseScreen();
    private void UpControlButtonPressed()
    {
        FindObjectOfType<PlayerControl>().UpControlButtonPressed();
    }
    private void DownControlButtonPressed()
    {
        FindObjectOfType<PlayerControl>().DownControlButtonPressed();
    }
}
