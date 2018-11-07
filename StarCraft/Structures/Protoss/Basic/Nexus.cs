namespace StarCraft.Structures.Protoss.Basic
{
    public class Nexus : BaseObject, IProtossBaseObject
    {
        public Nexus() : base("Nexus", 200, 2, 75)

        {
            Shield = 200;
        }

        public int Shield { get; set; }
    }
}