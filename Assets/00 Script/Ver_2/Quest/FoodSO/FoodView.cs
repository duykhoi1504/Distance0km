using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FoodView : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] public Button buybtn;
    [SerializeField] public TMPro.TMP_Text nameFood;
    // [SerializeField] public TMPro.TMP_Text description;
    [SerializeField] public FoodDataSo dataFood;
    void Start()
    {
        if (buybtn == null)
            buybtn = transform.GetComponentInChildren<Button>();
        if (nameFood == null)
            nameFood = transform.GetComponentInChildren<TMPro.TMP_Text>();
        if (dataFood == null)
            Debug.LogError("<color=red>FoodDataSo is null</color>");
        SetupFoodView(dataFood);
        // buybtn.onClick.AddListener(() => BreakfastShop.Instance.BuyFood(dataFood.foodType == FoodTypeEnum.healthy));
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetupFoodView(FoodDataSo foodData)
    {
        
        nameFood.text = foodData.nameFood;
        // description.text = foodData.description;
        // Cập nhật các thông tin khác của món ăn nếu cần
    }
}
