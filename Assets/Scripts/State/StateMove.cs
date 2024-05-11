public class StateMove : State
{
    /// <summary>
    /// 생성자
    /// </summary>
    public StateMove(StateMachine machine, Unit unit) : base(machine, unit) { }

    /// <summary>
    /// 상태 판단
    /// </summary>
    /// <returns>움직이는 행동을 해야하는 지 검사하여 반환</returns>
    public override bool Judge()
    {
        if (!unit.IsTargetInRange())
        {
            return true;
        }
        
        return false;
    }

    /// <summary>
    /// 움직이는 행동 실행
    /// </summary>
    public override void Execute()
    {
        unit.Move();
    }
}
