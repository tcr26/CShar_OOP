namespace StarCraft.Contracts.Interfaces
{
    public interface IAttacking
    {
        void AttackingProtossObject(ProtossShield unitToBeAttacked);

        void AttackinObject(BaseObject unitToBeAttacked);
    }
}