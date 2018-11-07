namespace StarCraft.Structures.Zerg.Basic
{
    public class EvolutionChamber : BaseObject, IZergBaseObject
    {
        public EvolutionChamber()
            : base("Evolution Chamber", 450, 1, 45)
        {
            HitPointsRegenerateRate = 3;
        }

        public int HitPointsRegenerateRate { get; set; }
    }
}