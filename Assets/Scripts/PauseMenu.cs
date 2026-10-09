using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;
    bool paused;

    void Start() { SetPaused(false); }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            SetPaused(!paused);
    }

    void SetPaused(bool value)
    {
        paused = value;
        pausePanel.SetActive(value);
        Time.timeScale = value ? 0f : 1f;
        Cursor.visible = value;
        Cursor.lockState = value ? CursorLockMode.None : CursorLockMode.None;
    }

    public void Resume() { SetPaused(false); }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void BackToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}