using System.Collections.Generic;

public abstract class State
{
    protected List<State> TransStates = new List<State>();
    
    protected StateMachine machine;
    protected Unit unit;
    
    /// <summary>
    /// 생성자
    /// </summary>
    public State(StateMachine machine, Unit unit)
    {
        this.machine = machine;
        this.unit = unit;
    }
    
    /// <summary>
    /// 상태 판단
    /// </summary>
    /// <returns>현재 상태에서 동작할 수 있는지 여부 반환</returns>
    public abstract bool Judge();

    /// <summary>
    /// 상태에 맞는 행동 실행
    /// </summary>
    public abstract void Execute();
}
