using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string name;
    public int ID;
    public Sprite icon;

    public enum ItemType
    {
        None,
        Weapon,
        Consumable
    }

    public ItemType itemType;

    public void Action()
    {
        switch (itemType)
        {
            case ItemType.Weapon:
                Debug.Log($"This is a {ItemType.Weapon}");
                break;
            case ItemType.Consumable:
                Debug.Log($"This is a {ItemType.Consumable}");
                break;
            case ItemType.None:
                break;
        }
    }


}
