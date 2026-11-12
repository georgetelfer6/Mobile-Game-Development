using UnityEngine;

public class IngredientSelector : MonoBehaviour
{
    public bool flipFlop;

    void Start()
    {

    }
    void Update()
    {
        if (GameData.selectedIngredients == GameData.ingredientNumber)
        {
            Debug.Log($"ababa");
        }
    }
    public void SetFlour()
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
            }
            Debug.Log($"selected");
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
            }
            Debug.Log($"selected");
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
            }
            Debug.Log($"selected");
        }
    }
}
