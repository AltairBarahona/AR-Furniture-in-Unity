
using UnityEngine;
using TMPro;
public class AppController : MonoBehaviour
{
    [Header("furniture")]
    public int startIndex;
    public FurnitureObject furnitureObject;

    [Header("UI")]
    public TextMeshProUGUI titleTxt;
    public Furniture furniturePrefab;
    public Transform furnitureContainer;

    private Furniture _furniture;

    [Header("Data")]
    public FurnitureSO[] data;

    void Start(){
        CreatePrefab();
        ChangeFurniture(data[startIndex]);
    }

    private void CreatePrefab(){
        for (int i = 0; i < data.Length; i++)
        {
            _furniture=Instantiate(furniturePrefab, furnitureContainer);
            _furniture.Init(data[i]);
            int index=i;
            _furniture.SetButton(()=>ChangeFurniture(data[index]));
        }
    }

    private void ChangeFurniture(FurnitureSO furnitureSO){
        titleTxt.text=furnitureSO.title;
        furnitureObject.SetObject(furnitureSO.prefab);

    }
}
