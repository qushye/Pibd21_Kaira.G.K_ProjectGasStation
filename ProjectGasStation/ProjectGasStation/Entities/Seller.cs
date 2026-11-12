using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ProjectGasStation.Entities.Enums;

namespace ProjectGasStation.Entities
{
    public class Seller
    {
        protected Seller()
        {
        }

        [Key]
        public int Id { get; internal set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; internal set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string LastName { get; internal set; } = string.Empty;

        public WorkShift WorkShift { get; internal set; }

        public FuelType AllowedFuelTypes { get; internal set; }

        [Browsable(false)]
        public ICollection<FuelSale> FuelSales { get; internal set; } = new List<FuelSale>();

        [Browsable(false)]
        public ICollection<FuelSupply> FuelSupplies { get; internal set; } = new List<FuelSupply>();

        public static Seller CreateEntity(int id, string firstName, string lastName, WorkShift workShift, FuelType allowedFuelTypes)
        {
            return new Seller
            {
                Id = id,
                FirstName = firstName ?? string.Empty,
                LastName = lastName ?? string.Empty,
                WorkShift = workShift,
                AllowedFuelTypes = allowedFuelTypes
            };
        }
    }
}
