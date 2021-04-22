using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;


public class Furniture : MonoBehaviour
{
    public TextMeshProUGUI titleTxt;
    public Image furnitureImg;
    public Button furnitureBtn;

    public void Init(FurnitureSO furnitureSO){
        titleTxt.text=furnitureSO.title;
        furnitureImg.sprite=furnitureSO.furnitureImg;
    }

    public void SetButton(UnityAction callback){
        furnitureBtn.onClick.AddListener(callback);
    }
}
