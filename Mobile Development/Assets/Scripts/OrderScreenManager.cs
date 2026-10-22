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
    }
    public void OpenShop()
    {
        orderCanvas.SetActive(false);
        shopCanvas.SetActive(true);
    }
    public void CloseShop()
    {
        shopCanvas.SetActive(false);
        orderCanvas.SetActive(true);
    }
}
