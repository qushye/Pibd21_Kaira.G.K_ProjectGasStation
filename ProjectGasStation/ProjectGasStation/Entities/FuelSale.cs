using ProjectGasStation.Entities.Enums;

namespace ProjectGasStation.Entities
{
    public class FuelSale
    {
        public int Id { get; private set; }

        public int FuelId { get; private set; }

        public int SellerId { get; private set; }

        public WorkShift WorkShift { get; private set; }

        public DateTime SaleDate { get; private set; }

        public int Quantity { get; private set; }

        public double TotalSum { get; private set; }

        public static FuelSale CreateOperation(int id, int fuelId, int sellerId, WorkShift workShift, int quantity, double totalSum)
        {
            return new FuelSale
            {
                Id = id,
                FuelId = fuelId,
                SellerId = sellerId,
                WorkShift = workShift,
                SaleDate = DateTime.Now,
                Quantity = quantity,
                TotalSum = totalSum
            };
        }
    }
}