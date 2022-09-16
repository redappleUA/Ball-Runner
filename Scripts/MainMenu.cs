using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    private Button startButton;
    private Button exitButton;

    void Awake()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        startButton = root.Q<Button>("StartButton");
        exitButton = root.Q<Button>("ExitButton");

        startButton.clicked += StartButtonPressed;
        exitButton.clicked += ExitButtonPressed;
    }

    void StartButtonPressed() => SceneManager.LoadScene("Game");
    void ExitButtonPressed() => Application.Quit();
}
