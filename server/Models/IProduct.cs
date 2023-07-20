using System.ComponentModel.DataAnnotations;

namespace server.Models
{
    public interface IProduct
    {
        [Key]
        int Id { get; set; }
        string Name { get; set; }
        string Image { get; set; }
        string Addition { get; set; }
        string Guarantee { get; set; }
        Category Category { get; set; }
        string Feedback { get; set; }
    }
}
