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
        UnityEngine.SceneManagement.SceneManager.LoadScene("OrderScreen");

    }
}
