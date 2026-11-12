using UnityEngine;
using UnityEngine.UI;

public class IngredientSelector : MonoBehaviour
{
    public bool flipFlop;
    public GameObject bakeButton;
    public GameObject mergeCanvas;
    public GameObject winCanvas;

    void Start()
    {

    }
    void Update()
    {
        Debug.Log(GameData.selectedIngredients);
        if (GameData.selectedIngredients == GameData.ingredientNumber)
        {
            BakeButton();
        }
    }
    public void SetFlour() // in the future seperat the set ingredients script from the bake button & win script
    {
        flipFlop = !flipFlop;
        if (flipFlop == false)
        {
            if (GameData.needsFlour == true)
            {
                GameData.selectedIngredients--;
            }
            Debug.Log($"unselected");
        }
        if (flipFlop == true)
        {
            if (GameData.needsFlour == true)
            {
                GameData.selectedIngredients++;
                gameObject.SetActive(false);
            }
            Debug.Log($"selected");
            Handheld.Vibrate();
        }
    }
    public void SetYeast()
    {
        flipFlop = !flipFlop;
        if (flipFlop == false)
        {
            if (GameData.needsYeast == true)
            {
                GameData.selectedIngredients--;
            }
            Debug.Log($"unselected");
        }
        if (flipFlop == true)
        {
            if (GameData.needsYeast == true)
            {
                GameData.selectedIngredients++;
                gameObject.SetActive(false);
            }
            Debug.Log($"selected");
            Handheld.Vibrate();
        }
    }
    public void SetEgg()
    {
        flipFlop = !flipFlop;
        if (flipFlop == false)
        {
            if (GameData.needsEgg == true)
            {
                GameData.selectedIngredients--;
            }
            Debug.Log($"unselected");
        }
        if (flipFlop == true)
        {
            if (GameData.needsEgg == true)
            {
                GameData.selectedIngredients++;
                gameObject.SetActive(false);
            }
            Debug.Log($"selected");
            Handheld.Vibrate();
        }
    }
    public void BakeButton() //need to set it to be disabled if u continue adding ingredients  or un add ingredients
    {
        bakeButton.SetActive(true);
    }
    public void LoadWin()
    {
        winCanvas.SetActive(true);
        mergeCanvas.SetActive(false);
        GameData.gameWon = true;
    }
}
