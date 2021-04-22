using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Furniture", menuName = "Furniture", order = 0)]

public class FurnitureSO : ScriptableObject
{
    public string title;
    public Sprite furnitureImg;
    public GameObject prefab;
}
