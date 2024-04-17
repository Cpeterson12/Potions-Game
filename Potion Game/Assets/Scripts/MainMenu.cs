using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class MainMenu : MonoBehaviour
{
    private int nextSceneIndex;
    
    public void LoadNextScene()
    {
        nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        
        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            Debug.LogWarning("No next scene available.");
        }
    }
    
    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene(0);
    }
    
    
    public void OnVRButtonPress(XRBaseInteractor interactor)
    {
        LoadNextScene();
    }
    
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else

#endif
    }
    
    public void OnVRQuitButtonPress(XRBaseInteractor interactor)
    {
        QuitGame();
    }
}