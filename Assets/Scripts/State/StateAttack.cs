using UnityEngine;

public class StateAttack : State
{
    public StateAttack(StateMachine machine, Unit unit) : base(machine, unit)
    {
    }

    public override bool Judge()
    {
        if (unit.IsTargetInRange())
        {
            return true;
        }

        UpdateState();
        return false;
    }

    public override void Execute()
    {
        Debug.Log("Attack 상태 실행");
    }
}
