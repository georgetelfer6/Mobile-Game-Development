using UnityEngine;

public class WinLoseManager : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {
        if (GameData.gameWon == true)
        {
            GrantWin();
        }
    }
    void GrantWin()
    {
        GameData.gameWon = false;
        GameData.playerMoney = GameData.playerMoney + GameData.orderPrice;
    }
    public void LoadOrderScreen()
    {
        Handheld.Vibrate();
        UnityEngine.SceneManagement.SceneManager.LoadScene("OrderScreen");
    }
}
