namespace server.Models.Pianos
{
    public interface IPiano 
    {
        public PianoType Type { get; set; }
        public PianoCategory Category { get; set; }
        public KeyMechanics Mechanics { get; set; }
        public int KeysCount { get; set; }


    }
}
