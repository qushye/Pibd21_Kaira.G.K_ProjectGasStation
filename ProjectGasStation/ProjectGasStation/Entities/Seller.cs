using ProjectGasStation.Entities.Enums;

namespace ProjectGasStation.Entities
{
    public class Seller
    {
        public int Id { get; private set; }

        public string FirstName { get; private set; } = string.Empty;

        public string LastName { get; private set; } = string.Empty;

        public WorkShift WorkShift { get; private set; }

        public FuelType AllowedFuelTypes { get; private set; }

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