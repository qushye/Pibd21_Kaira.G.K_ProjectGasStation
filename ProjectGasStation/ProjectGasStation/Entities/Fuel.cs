using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ProjectGasStation.Entities.Enums;

namespace ProjectGasStation.Entities
{
    public class Fuel
    {
        protected Fuel()
        {
        }

        [Key]
        public int Id { get; internal set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; internal set; } = string.Empty;

        public FuelType FuelType { get; internal set; }

        public double Price { get; internal set; }

        [Browsable(false)]
        public ICollection<FuelSale> FuelSales { get; internal set; } = new List<FuelSale>();

        [Browsable(false)]
        public ICollection<FuelSupplyFuel> FuelSupplyFuels { get; internal set; } = new List<FuelSupplyFuel>();

        public static Fuel CreateEntity(int id, string name, FuelType fuelType, double price)
        {
            return new Fuel
            {
                Id = id,
                Name = name ?? string.Empty,
                FuelType = fuelType,
                Price = price
            };
        }
    }
}
