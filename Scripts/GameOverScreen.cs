using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    private Label score;
    private Button restartButton;
    private Button menuButton;

    private void Awake() => gameObject.SetActive(false);
    public static void MenuButtonPressed()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main Menu");
    }
    public static void RestartButtonPressed()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }
    public void OpenGameOverScreen(int scorePoint)
    {
        gameObject.SetActive(true);

        var root = GetComponent<UIDocument>().rootVisualElement;

        restartButton = root.Q<Button>("RestartButton");
        menuButton = root.Q<Button>("MenuButton");
        score = root.Q<Label>("Score");

        restartButton.clicked += RestartButtonPressed;
        menuButton.clicked += MenuButtonPressed;

        Time.timeScale = 0;
        score.text = scorePoint.ToString() + " POINTS";
        score.style.display = DisplayStyle.Flex;
    }
}