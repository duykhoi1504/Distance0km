using UnityEngine;

public abstract class BaseLevelState : BaseState<GameManager>
{
    protected LevelDataSO data;

    public BaseLevelState(GameManager owner, StateMachine sm, LevelDataSO data) : base(owner, sm, string.Empty)
    {
        this.data = data;
    }

    public override void Enter()
    {
        // Player_Movement.Instance.CanMove = false; // Chặn nhân vật
        // owner.ShowDialogue(data.objectiveMessage); // Hiện UI
    }

    public override void Exit()
    {
        // Player_Movement.Instance.CanMove = true; // Cho đi lại
        // owner.HideUI();
    }
}