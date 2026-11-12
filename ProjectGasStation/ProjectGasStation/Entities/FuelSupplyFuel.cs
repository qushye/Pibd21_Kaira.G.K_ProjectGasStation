using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectGasStation.Entities
{
    public class FuelSupplyFuel
    {
        protected FuelSupplyFuel()
        {
        }

        [Key]
        public int Id { get; internal set; }

        public int FuelSupplyId { get; internal set; }

        public int FuelId { get; internal set; }

        public int Count { get; internal set; }

        [ForeignKey(nameof(FuelSupplyId))]
        [Browsable(false)]
        public FuelSupply FuelSupply { get; internal set; } = null!;

        [ForeignKey(nameof(FuelId))]
        [Browsable(false)]
        public Fuel Fuel { get; internal set; } = null!;

        public static FuelSupplyFuel CreateElement(int id, int fuelId, int count)
        {
            return new FuelSupplyFuel
            {
                Id = id,
                FuelId = fuelId,
                Count = count
            };
        }
    }
}
