using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class OrderSystem : MonoBehaviour
{
    [System.Serializable]
    public class RequiredIngredients // A list to show what ingredients are required for each pastry, to be used in the merge & order completion system
    {
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

    [System.Serializable]
    public class PastryList // List of variables that are important in identiifying each pastry type
    {
        public string itemName;
        public int itemID;
        public Sprite itemImage;
        public RequiredIngredients ingredients;
    }

    public PastryList[] orderData;
    public int orderNum;
    bool settingOrder = false;

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
            }
        }
    }
}
