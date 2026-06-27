# Hướng Dẫn Cách Áp Dụng Nhanh Cho Game Mới
Khi bạn làm một con quái vật (Enemy) mới, bạn chỉ cần kế thừa từ BaseState<Enemy> thay vì phải viết lại từ đầu.

Ví dụ tạo trạng thái đi tuần cho Enemy:

C#
```CSharp
public class EnemyPatrolState : BaseState<Enemy>
{
    public EnemyPatrolState(Enemy enemy, StateMachine stateMachine, string animBoolName) 
        : base(enemy, stateMachine, animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
        owner.anim.SetBool(animBoolName, true); 
    }

    public override void Update()
    {
        base.Update();
        
        owner.MoveAround();

        // Chuyển trạng thái tấn công nếu thấy Player
        if (owner.DetectPlayer())
        {
            stateMachine.ChangeState(owner.attackState);
        }
    }
    
    public override void Exit()
    {
        base.Exit();
        owner.anim.SetBool(animBoolName, false);
    }
}
///Cách khai báo trong Script chính của Enemy:

C#
public class Enemy : MonoBehaviour
{
    public StateMachine stateMachine { get; private set; }
    public EnemyPatrolState patrolState { get; private set; }
    public EnemyAttackState attackState { get; private set; }

    public Animator anim;

    private void Awake()
    {
        stateMachine = new StateMachine();
        patrolState = new EnemyPatrolState(this, stateMachine, "isPatrolling");
        attackState = new EnemyAttackState(this, stateMachine, "isAttacking");
    }

    private void Start()
    {
        stateMachine.Initialize(patrolState);
    }

    private void Update()
    {
        stateMachine.CurrentState.Update();
    }
    
    private void FixedUpdate()
    {
        stateMachine.CurrentState.FixedUpdate();
    }
}
```
Cấu trúc này giúp toàn bộ thư mục Script của bạn cực kỳ gọn gàng. Bất cứ khi nào tạo dự án mới, bạn chỉ cần copy thả 3 file IState.cs, StateMachine.cs, và BaseState.cs vào là đã có ngay một hệ thống quản lý AI và Player chuyên nghiệp.