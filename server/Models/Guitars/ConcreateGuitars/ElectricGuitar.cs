using server.Models.Guitar.Enums;

namespace server.Models.Guitar.ConcreateGuitars
{
    public class ElectricGuitar : Guitar
    {
    //    /// <summary>
    //    /// IGuitar implementation
    //    /// </summary>
    //    public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //    public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //    public string Image { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //    public string Addition { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //    public string Guarantee { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //    public Category Category { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //    public string Feedback { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    //    public GuitarType Type { get; set; }
        public string Description { get; set; }
        public GuitarKind Kind { get; set; }
        public StringsCount StringsCount { get; set; }
        public string Color { get; set; }
        public FretCount FretCount { get; set; }
        public string Soundbox { get; set; }
        public string DeckMaterial { get; set; }
        public string NeckMaterial { get; set; }
        public string FretboardScale { get; set; }
        public string BodyShape { get; set; }
        public string NeckAttachmentType { get; set; }
        public string NeckProfile { get; set; }
        public string Regulators { get; set; }
        public string Bridge { get; set; }
        public string Pegs { get; set; }
        public string Inlay { get; set; }
      
    }
}
