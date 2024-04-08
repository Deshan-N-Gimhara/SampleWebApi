using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleWebApi.EFCore
{
    [Table("product")]
    public class Product
    {
        [Key,Required]
        public int Id {  get; set; }
        public required string Name {  get; set; }
        public required string Brand {  get; set; }
        public int Size {  get; set; }
        public decimal Price { get; set; }
    }
}
