namespace StarCraft.Structures.Zerg.Basic
{
    public class SpawningPool : BaseObject, IZergBaseObject
    {
        public SpawningPool()
            : base("Spawning Pool", 1000, 1, 55)
        {
            HitPointsRegenerateRate = 3;
        }

        public int HitPointsRegenerateRate { get; set; }
    }
}