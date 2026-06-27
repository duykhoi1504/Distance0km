using UnityEngine;

/// <summary>
/// Giao diện này định nghĩa vòng đời cơ bản của một trạng thái. 
/// Tôi đã bổ sung thêm FixedUpdate() để bạn dễ dàng xử lý các logic liên quan đến vật lý (Rigidbody).
/// </summary>
public interface IState
{
    void Enter();
    void Update();
    void FixedUpdate(); 
    void Exit();
}