using UnityEngine;

public class StateIdle : State
{
    /// <summary>
    /// 생성자
    /// </summary>
    public StateIdle(StateMachine machine, Unit unit) : base(machine, unit)
    {
        // 전이 가능한 상태 추가
        TransStates.Add(new StateMove(machine, unit));
    }
    
    /// <summary>
    /// 상태 판단
    /// </summary>
    /// <returns>Idle 상태의 행동을 해야하는지 여부 반환</returns>
    public override bool Judge()
    {
        if (!unit.SearchTarget())
        {
            return true;
        }

        UpdateState();
        
        return false;
    }

    /// <summary>
    /// Idle 상태 행동 실행
    /// </summary>
    public override void Execute()
    {
        Debug.Log("Idle 상태 실행");
    }
}
