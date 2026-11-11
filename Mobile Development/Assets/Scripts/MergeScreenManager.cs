using UnityEngine;

public class MergeScreenManager : MonoBehaviour
{
    public GameObject mergeCanvas;
    public GameObject pauseCanvas;

    void Start()
    {
        mergeCanvas.SetActive(true);
        pauseCanvas.SetActive(false);
    }
    void Update()
    {
        
    }
    public void PauseClicked()
    {
        mergeCanvas.SetActive(false);
        pauseCanvas.SetActive(true);
    }
    public void UnpauseClicked()
    {
        pauseCanvas.SetActive(false);
        mergeCanvas.SetActive(true);
    }
}
