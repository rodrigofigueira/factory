namespace FactoryLib.Interfaces
{
    public interface ShotoFighter
    {
        public string Name { get; }
        public Move Fireball();
        public Move AntiAir();
    }
}
