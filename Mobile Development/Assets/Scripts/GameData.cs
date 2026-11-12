using UnityEngine;
using UnityEngine.UI;

public class GameData : MonoBehaviour
{
    [Header("Order Variables")]
    public static int playerMoney = 0;
    public static bool gameWon = false;
    public static Sprite orderImage;
    public static string orderName;
    public static int orderPrice = 0;
    public static int ingredientNumber;
    public static int selectedIngredients;
    public static bool needsFlour;
    public static bool needsYeast;
    public static bool needsEgg;
    public static bool needsMilk;
    public static bool needsButter;
    public static bool needsSugar;
    public static bool needsChocolate;
    public static bool needsStrawberry;
    public static bool needsApple;

}
