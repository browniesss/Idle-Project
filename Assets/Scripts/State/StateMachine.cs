public class StateMachine
{
    public State currentState;
    private Unit unit;
    
    /// <summary>
    /// 생성자
    /// </summary>
    public StateMachine(Unit unit)
    {
        this.unit = unit;
        Init();
    }

    /// <summary>
    /// 초기 설정
    /// </summary>
    private void Init()
    {
        currentState = new StateMove(this, unit);
    }

    /// <summary>
    /// 상태 머신 실행 
    /// </summary>
    public void PlayMachine()
    {
        if (currentState.Judge())
        {
            currentState.Execute();
        }
    }
}
