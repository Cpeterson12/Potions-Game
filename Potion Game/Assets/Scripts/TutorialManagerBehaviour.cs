using UnityEngine;
using UnityEngine.UI;

public class TutorialManagerBehaviour : MonoBehaviour
{
    public GameObject[] tutorialPanels;
    private int currentPanelIndex = 0;

    void Start()
    {
        ShowPanel(currentPanelIndex);
    }

    public void NextPanel()
    {
        if (currentPanelIndex < tutorialPanels.Length - 1)
        {
            ShowPanel(currentPanelIndex + 1);
        }
    }

    public void PreviousPanel()
    {
        if (currentPanelIndex > 0)
        {
            ShowPanel(currentPanelIndex - 1);
        }
    }

    private void ShowPanel(int index)
    {
        for (int i = 0; i < tutorialPanels.Length; i++)
        {
            tutorialPanels[i].SetActive(i == index);
        }
        currentPanelIndex = index;
    }
}