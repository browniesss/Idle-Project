using UnityEngine;

public class StateDie : State
{
    public StateDie(StateMachine machine, Unit unit) : base(machine, unit)
    {
    }

    public override bool Judge()
    {
        if (unit.IsDie())
        {
            return true;
        }

        return false;
    }

    public override void Execute()
    {
        Debug.Log("Die 상태 실행");
    }
}
