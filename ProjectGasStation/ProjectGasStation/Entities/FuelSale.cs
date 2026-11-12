using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjectGasStation.Entities.Enums;

namespace ProjectGasStation.Entities
{
    public class FuelSale
    {
        protected FuelSale()
        {
        }

        [Key]
        public int Id { get; internal set; }

        public int FuelId { get; internal set; }

        public int SellerId { get; internal set; }

        public WorkShift WorkShift { get; internal set; }

        [Column(TypeName = "timestamp without time zone")]
        public DateTime SaleDate { get; internal set; }

        public int Quantity { get; internal set; }

        public double TotalSum { get; internal set; }

        [ForeignKey(nameof(FuelId))]
        [Browsable(false)]
        public Fuel Fuel { get; internal set; } = null!;

        [ForeignKey(nameof(SellerId))]
        [Browsable(false)]
        public Seller Seller { get; internal set; } = null!;

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
