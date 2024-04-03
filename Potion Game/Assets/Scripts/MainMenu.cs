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

    // Method to handle VR button press
    public void OnVRButtonPress(XRBaseInteractor interactor)
    {
        // Call the LoadNextScene function
        LoadNextScene();
    }
    
    // Function to quit the application
    public void QuitGame()
    {
        // Check if the application is running in the Unity Editor
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // Quit the application when running in a standalone build
        Application.Quit();
#endif
    }

    // Method to handle VR button press for quitting the application
    public void OnVRQuitButtonPress(XRBaseInteractor interactor)
    {
        // Call the QuitGame function
        QuitGame();
    }
}