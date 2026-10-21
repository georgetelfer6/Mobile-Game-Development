using UnityEngine;

public class OrderScreenManager : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void OrderClicked()
    {
        gameObject.SetActive(false);
        UnityEngine.SceneManagement.SceneManager.LoadScene("MergeScreen");
        Debug.Log("clicked");
    }
}
