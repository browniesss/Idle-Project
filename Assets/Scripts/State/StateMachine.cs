using System.Collections.Generic;

public class StateMachine
{
    private List<State> preStates = new List<State>();
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
        // 모든 상태에서 전이 가능한 선행 상태들 추가
        preStates.Add(new StateDamaged(this, unit));
        preStates.Add(new StateDie(this, unit));
        
        // 시작 상태 추가
        currentState = new StateIdle(this, unit);
    }

    /// <summary>
    /// 상태 머신 실행 
    /// </summary>
    public void PlayMachine()
    {
        foreach (var state in preStates)
        {
            if (state.Judge())
            {
                state.Execute();
                return;
            }
        }
        
        if (currentState.Judge())
        {
            currentState.Execute();
        }
    }
}
