using UnityEngine;

public abstract class BaseState<T> : IState
{
    protected T owner; // Chủ thể của trạng thái (Player, Enemy, v.v.)
    protected StateMachine stateMachine;
    protected string animBoolName;

    // Biến dùng chung cho mọi state
    protected float stateTimer;

    public BaseState(T owner, StateMachine stateMachine, string animBoolName)
    {
        this.owner = owner;
        this.stateMachine = stateMachine;
        this.animBoolName = animBoolName;
    }

    public virtual void Enter()
    {
        // Khởi tạo timer mỗi khi vào state
        stateTimer = 0f;
        
        // Gọi Animation (Yêu cầu lớp T phải cung cấp cách truy cập Animator, hoặc bạn xử lý trực tiếp ở lớp con)
        // Ví dụ: owner.anim.SetBool(animBoolName, true);
    }

    public virtual void Update()
    {
        stateTimer += Time.deltaTime;
    }

    public virtual void FixedUpdate()
    {
        // Xử lý vật lý ở lớp con nếu cần
    }

    public virtual void Exit()
    {
        // Tắt Animation
        // Ví dụ: owner.anim.SetBool(animBoolName, false);
    }
}