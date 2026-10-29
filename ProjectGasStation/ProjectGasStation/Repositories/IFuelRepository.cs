using ProjectGasStation.Entities;

namespace ProjectGasStation.Repositories
{
    public interface IFuelRepository
    {
        IEnumerable<Fuel> ReadFuels();

        Fuel ReadFuelById(int id);

        void CreateFuel(Fuel fuel);

        void UpdateFuel(Fuel fuel);

        void DeleteFuel(int id);
    }
}