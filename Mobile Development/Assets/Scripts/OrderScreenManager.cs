using UnityEngine;

public class OrderScreenManager : MonoBehaviour
{
    public GameObject orderCanvas;
    public GameObject shopCanvas;
    void Start()
    {
        orderCanvas.SetActive(true);
        Handheld.Vibrate();
        shopCanvas.SetActive(false);
    }
    void Update()
    {
        
    }
    public void OrderClicked()
    {
        gameObject.SetActive(false);
        GameData.selectedIngredients = 0;
        Handheld.Vibrate();
        UnityEngine.SceneManagement.SceneManager.LoadScene("MergeScreen");
    }
    public void OpenShop()
    {
        orderCanvas.SetActive(false);
        Handheld.Vibrate();
        shopCanvas.SetActive(true);
    }
    public void CloseShop()
    {
        shopCanvas.SetActive(false);
        Handheld.Vibrate();
        orderCanvas.SetActive(true);
    }
}
