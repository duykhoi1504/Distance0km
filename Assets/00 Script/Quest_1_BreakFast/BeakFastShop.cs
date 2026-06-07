using UnityEngine;
public enum FoodType
{
    Salad,
    Noodle
}
public class BeakFastShop : MonoBehaviour
{
    [SerializeField] private QuestData breakfastQuest;
    [SerializeField] private QuestData lessonQuest;


    private bool playerInShop;

    private void Update()
    {
        if (!playerInShop)
            return;

        if (Input.GetKeyDown(KeyCode.E))
        {
            BuyFood(FoodType.Salad);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            BuyFood(FoodType.Noodle);
        }
    }

    public void BuyFood(FoodType food)
    {
        // string foodName = foodType.ToString();
        {
          
            if (QuestManager.Instance.IsCompleted(breakfastQuest))
            {
                Debug.Log("<color=green>Đã ăn sáng rồi, đừng ăn nữa, Béo đó nha 😤</color>");
                return;
            }
            if (!QuestManager.Instance.IsActive(breakfastQuest))
            {
                Debug.Log("Bạn chưa nhận nhiệm vụ.");
                return;
            }

            switch (food)
            {
                case FoodType.Salad:
                    QuestManager.Instance.CompleteQuest(breakfastQuest);
                    Debug.Log("Giỏi thía❤️");
                    // QuestManager.Instanc
                    QuestManager.Instance.UnlockQuest(lessonQuest);
                    break;

                case FoodType.Noodle:
                    Debug.Log("<color=Red>Ớ lén hả 😤</color>");
                    break;

                ///case FoodType.Salad:
                ///    Debug.Log("Giỏi thía❤️");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
            return;

        playerInShop = true;

        ShowShopUI();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
            return;

        playerInShop = false;

        Debug.Log("Đã rời cửa hàng");
    }

    private void ShowShopUI()
    {
        Debug.Log(
            "Bạn đã vào cửa hàng ăn sáng\n" +
            "E - Salad\n" +
            "R - Noodle");
    }

}
