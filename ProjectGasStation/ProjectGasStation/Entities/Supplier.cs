using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectGasStation.Entities
{
    public class Supplier
    {
        protected Supplier()
        {
        }

        [Key]
        public int Id { get; internal set; }

        [Required]
        [MaxLength(150)]
        public string CompanyName { get; internal set; } = string.Empty;

        [Required]
        [MaxLength(30)]
        public string ContactPhone { get; internal set; } = string.Empty;

        [Browsable(false)]
        public ICollection<FuelSupply> FuelSupplies { get; internal set; } = new List<FuelSupply>();

        public static Supplier CreateEntity(int id, string companyName, string contactPhone)
        {
            return new Supplier
            {
                Id = id,
                CompanyName = companyName ?? string.Empty,
                ContactPhone = contactPhone ?? string.Empty
            };
        }
    }
}
