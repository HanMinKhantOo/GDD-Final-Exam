using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void PlayDriving() { SceneManager.LoadScene("Driving"); }
    public void PlayFlying()  { SceneManager.LoadScene("Flying"); }
    public void PlaySumo()    { SceneManager.LoadScene("Sumo"); }

    public void ExitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}