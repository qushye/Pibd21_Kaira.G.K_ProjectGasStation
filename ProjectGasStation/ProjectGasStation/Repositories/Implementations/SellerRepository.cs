using ProjectGasStation.Entities;
using ProjectGasStation.Entities.Enums;

namespace ProjectGasStation.Repositories.Implementations
{
    internal class SellerRepository : ISellerRepository
    {
        public void CreateSeller(Seller seller)
        {
        }

        public void DeleteSeller(int id)
        {
        }

        public Seller ReadSellerById(int id)
        {
            return Seller.CreateEntity(0, string.Empty, string.Empty, WorkShift.None, FuelType.None);
        }

        public IEnumerable<Seller> ReadSellers()
        {
            return [];
        }

        public void UpdateSeller(Seller seller)
        {
        }
    }
}