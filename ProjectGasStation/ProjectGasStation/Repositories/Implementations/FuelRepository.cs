using ProjectGasStation.Entities;
using ProjectGasStation.Entities.Enums;

namespace ProjectGasStation.Repositories.Implementations
{
    internal class FuelRepository : IFuelRepository
    {
        public void CreateFuel(Fuel fuel)
        {
        }

        public void DeleteFuel(int id)
        {
        }

        public Fuel ReadFuelById(int id)
        {
            return Fuel.CreateEntity(0, string.Empty, FuelType.None, 0);
        }

        public IEnumerable<Fuel> ReadFuels()
        {
            return [];
        }

        public void UpdateFuel(Fuel fuel)
        {
        }
    }
}