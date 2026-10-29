using ProjectGasStation.Entities.Enums;

namespace ProjectGasStation.Entities
{
    public class Fuel
    {
        public int Id { get; private set; }

        public string Name { get; private set; } = string.Empty;

        public FuelType FuelType { get; private set; }

        public double Price { get; private set; }

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