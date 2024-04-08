using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleWebApi.EFCore
{
    [Table("order")]
    public class Order
    {
        [Key, Required]
        public int Id { get; set; }
        public int Product_id { get; set; }
        public virtual Product Product { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone {  get; set; }

    }
}
