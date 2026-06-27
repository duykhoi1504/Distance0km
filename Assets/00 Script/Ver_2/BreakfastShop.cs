using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BreakfastShop : MonoBehaviour, IInteractable
{
     public static BreakfastShop Instance { get; private set; }

    [SerializeField] private bool isCompleted = false;
    [SerializeField] private Canvas ShopCanvas;
    // [SerializeField] private List<FoodView> ListFoodViews;
    bool playerInShop = false;

    void Start()
    {
        ShopCanvas.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !isCompleted && playerInShop)
        {
            Interact();
        }
    }
    public void Interact()
    {
        if (isCompleted)
        {
            Debug.Log("<color=green>Đã ăn sáng rồi, đừng ăn nữa, Béo đó nha 😤</color>");
            return;
        }

        // Báo cho GameManager kích hoạt State làm nhiệm vụ ăn sáng
        // GameManager.Instance.StartLevel("level_1");
        ShopCanvas.gameObject.SetActive(true);
    
        // BuyFood(true); // Giả sử người chơi chọn món ăn lành mạnh
        // Đánh dấu để lần sau không ăn nữa

    }
    public void BuyFood(bool isHealthy)
    {
        // Đánh dấu để lần sau không ăn nữa
        if (isHealthy)
        {
            Debug.Log("<color=green>Giỏi thía❤️ Thưởng cho em một nụ hôn ảo! 💋</color>");
            isCompleted = true;
            GameManager.Instance.CompleteLevel(CONSTANT.level_1, GameManager.Instance.level1Data);
            GameManager.Instance.StartLevel(CONSTANT.level_2);
        }
        else
        {
            Debug.Log("<color=red>Ớ lén hả 😤 Anh dặn phải ăn nhiều rau xanh cơ mà! Chọn lại đi cô giáo ơi!</color>");
        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            Debug.Log("<color=yellow> đã vào shop</color>");
            playerInShop = true;

            // Debug.Log("<color=yellow>Nhấn E - Chọn Bánh mì & Salad rau củ\nNhấn R - Chọn Mì tôm trứng</color>");
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("<color=yellow> đã rời shop</color>");
        playerInShop = false;
    }
}