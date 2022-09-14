using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class PauseScreen : MonoBehaviour
{
    private Button resumeButton;
    private Button restartButton;
    private Button menuButton;
    private void Awake() => gameObject.SetActive(false);
    public void OpenPauseScreen()
    {
        gameObject.SetActive(true);

        var root = GetComponent<UIDocument>().rootVisualElement;

        restartButton = root.Q<Button>("RestartButton");
        resumeButton = root.Q<Button>("ResumeButton");
        menuButton = root.Q<Button>("MenuButton");

        resumeButton.clicked += ResumeButtonClicked;
        restartButton.clicked += delegate () { GameOverScreen.RestartButtonPressed(); };
        menuButton.clicked += delegate () { GameOverScreen.MenuButtonPressed(); };

        Time.timeScale = 0;
    }

    void ResumeButtonClicked()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }
}
