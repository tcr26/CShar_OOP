namespace StarCraft
{
    public interface IAttackObject
    {
        int AttackPower { get; set; }

        int AttackRange { get; set; }

        float AttackRate { get; set; }
    }
}