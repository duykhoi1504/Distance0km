using UnityEngine;
[CreateAssetMenu(fileName = "NewFood", menuName = "FoodData")]

public class FoodDataSo : ScriptableObject
{
    public string nameFood;
    public string description;
    public FoodTypeEnum foodType;
    public Sprite spriterender;
}
public enum FoodTypeEnum
{
    healthy,
    unhealthy
}