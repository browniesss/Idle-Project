public class StateDamaged : State
{
    public StateDamaged(StateMachine machine, Unit unit) : base(machine, unit)
    {
    }

    public override bool Judge()
    {
        return false;
    }

    public override void Execute()
    {
    }
}
