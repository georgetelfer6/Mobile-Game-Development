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
        GameData.orderPrice = 0;
    }
    public void LoadOrderScreen()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("OrderScreen");
    }
}
