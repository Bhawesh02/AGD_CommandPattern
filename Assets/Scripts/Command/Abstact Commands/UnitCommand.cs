public abstract class UnitCommand : ICommand
{
    public int m_ActorUnitID;
    public int m_ActorPlayerID;
    public int m_TargetUnitID;
    public int m_TargetPlayerrID;

    public abstract void Execute();
    public abstract bool WillHitTarget();
}
