using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float moveSpeed = 5f;
    public bool CanMove = true;
    private Rigidbody2D rb;
    private Vector2 moveInput;

    
    public static Player_Movement Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        moveInput = moveInput.normalized;

    }
    void FixedUpdate()
    {
        Movement();
    }
    public void Movement()
    {
        if (!CanMove)
            return;
        rb.linearVelocity = moveInput * moveSpeed * Time.fixedDeltaTime;

    }
}
