using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(20)]
        [Required]
        public string Name { get; set; }
        [Range(1, 9999)]
        public int Price {  get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        [StringLength(20)]
        [Required]
        public string Category { get; set; }
        [StringLength(20)]
        [Required]
        public string Shelf { get; set; }
        [Range(1, 999)]
        public int Count { get; set; }
        [StringLength(30)]
        [Required]
        public string Description {  get; set; }

    }
}
