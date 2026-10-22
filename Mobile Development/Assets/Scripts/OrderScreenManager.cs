using UnityEngine;

public class OrderScreenManager : MonoBehaviour
{
    public GameObject orderCanvas;
    public GameObject shopCanvas;
    void Start()
    {
        orderCanvas.SetActive(true);
        shopCanvas.SetActive(false);
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
    public void OpenShop()
    {
        orderCanvas.SetActive(false);
        shopCanvas.SetActive(true);
        Debug.Log("Shop Opened");
    }
    public void CloseShop()
    {
        shopCanvas.SetActive(false);
        orderCanvas.SetActive(true);
        Debug.Log("Shop Closed");
    }
}
