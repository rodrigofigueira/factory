namespace FactoryLib.Interfaces
{
    public interface ShotoFighter
    {
        public string Name { get; }
        public string ImgMain { get; }
        public Move Fireball();
        public Move DragonPunch();
    }
}
