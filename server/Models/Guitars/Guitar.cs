using server.Models.Guitar.Enums;

namespace server.Models.Guitar
{
    public abstract class Guitar : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Addition { get; set; }
        public string Guarantee { get; set; }
        public Category Category { get; set; }
        public string Feedback { get; set; }


        public GuitarType Type { get; set; }
        public string Description { get; set; }
        public GuitarKind Kind { get; set; }
        public StringsCount StringsCount { get; set; }
        public string Color { get; set; }
        public FretCount FretCount { get; set; }
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
