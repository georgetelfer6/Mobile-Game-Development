using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class OrderSystem : MonoBehaviour
{
    [System.Serializable]
    public class PastryList // List of variables that are important in identiifying each pastry type
    {
        public string itemName;
        public int itemID;
        public Sprite itemImage;
        public int itemPrice;
        public int totalIngredientNumber;
        public bool Flour;
        public bool Yeast;
        public bool Egg;
        public bool Milk;
        public bool Butter;
        public bool Sugar;
        public bool Chocolate;
        public bool Strawberry;
        public bool Apple;
    }

    public PastryList[] orderData;
    public int orderNum;
    bool settingOrder = false;
    public Image orderSprite;

    void Start()
    {
        orderNum = Random.Range(0, orderData.Length); // Gets a random int between 0 and the array length to create a randomised order
        settingOrder = true;
        Debug.Log($"setting order");
    }

    
    void Update()
    {
        if (settingOrder == true)
        {
            SetOrder();
            settingOrder = false;
        }
        
    }

    void SetOrder()
    {
        Debug.Log($"Running");
        foreach (var item in orderData)
        {
            if (item.itemID == orderNum)
            {
                Debug.Log($"item id =" + orderNum);
                GameData.orderImage = item.itemImage;
                GameData.orderName = item.itemName;
                GameData.ingredientNumber = item.totalIngredientNumber;
                GameData.orderPrice = item.itemPrice;
                GameData.needsFlour = item.Flour;
                GameData.needsYeast = item.Yeast;
                GameData.needsEgg = item.Egg;
                GameData.needsMilk = item.Milk;
                GameData.needsButter = item.Butter;
                GameData.needsSugar = item.Sugar;
                GameData.needsChocolate = item.Chocolate;
                GameData.needsApple = item.Apple;
                GameData.needsStrawberry = item.Strawberry;
                orderSprite.sprite = GameData.orderImage;
            }
        }
    }
}
