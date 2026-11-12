using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void StartClicked()
    {
        gameObject.SetActive(false);
        Handheld.Vibrate();
        UnityEngine.SceneManagement.SceneManager.LoadScene("OrderScreen");

    }
}
