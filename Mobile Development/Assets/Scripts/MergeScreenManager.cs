using UnityEngine;

public class MergeScreenManager : MonoBehaviour
{
    public GameObject mergeCanvas;
    public GameObject pauseCanvas;

    void Start()
    {
        mergeCanvas.SetActive(true);
        Handheld.Vibrate();
        pauseCanvas.SetActive(false);
    }
    void Update()
    {
        
    }
    public void PauseClicked()
    {
        mergeCanvas.SetActive(false);
        Handheld.Vibrate();
        pauseCanvas.SetActive(true);
    }
    public void UnpauseClicked()
    {
        pauseCanvas.SetActive(false);
        Handheld.Vibrate();
        mergeCanvas.SetActive(true);
    }
}
