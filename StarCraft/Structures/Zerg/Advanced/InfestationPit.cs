namespace StarCraft.Structures.Zerg.Advanced
{
    public class InfestationPit : BaseObject, IZergBaseObject
    {
        public InfestationPit()
            : base("Infestation Pit", 550, 1, 80)
        {
            HitPointsRegenerateRate = 3;
        }

        public int HitPointsRegenerateRate { get; set; }
    }
}