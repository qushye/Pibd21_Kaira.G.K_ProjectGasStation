using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectGasStation.Entities
{
    public class FuelSupply
    {
        protected FuelSupply()
        {
        }

        [Key]
        public int Id { get; internal set; }

        public int SupplierId { get; internal set; }

        public int SellerId { get; internal set; }

        [Column(TypeName = "timestamp without time zone")]
        public DateTime SupplyDate { get; internal set; }

        [ForeignKey(nameof(SupplierId))]
        [Browsable(false)]
        public Supplier Supplier { get; internal set; } = null!;

        [ForeignKey(nameof(SellerId))]
        [Browsable(false)]
        public Seller Seller { get; internal set; } = null!;

        [Browsable(false)]
        public ICollection<FuelSupplyFuel> FuelSupplyFuels { get; internal set; } = new List<FuelSupplyFuel>();

        public static FuelSupply CreateOperation(int id, int supplierId, int sellerId, IEnumerable<FuelSupplyFuel> fuelSupplyFuels)
        {
            return new FuelSupply
            {
                Id = id,
                SupplierId = supplierId,
                SellerId = sellerId,
                SupplyDate = DateTime.Now,
                FuelSupplyFuels = fuelSupplyFuels?.ToList() ?? new List<FuelSupplyFuel>()
            };
        }
    }
}
