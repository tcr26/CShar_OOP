namespace StarCraft.Structures.Zerg.Advanced
{
    public class UltraliskCavern : BaseObject, IZergBaseObject
    {
        public UltraliskCavern()
            : base("Ultralisk Cavern", 800, 1, 90)
        {
            HitPointsRegenerateRate = 3;
        }

        public int HitPointsRegenerateRate { get; set; }
    }
}