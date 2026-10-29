namespace ProjectGasStation.Entities
{
    public class Supplier
    {
        public int Id { get; private set; }

        public string CompanyName { get; private set; } = string.Empty;

        public string ContactPhone { get; private set; } = string.Empty;

        public static Supplier CreateEntity(int id, string companyName, string contactPhone)
        {
            return new Supplier
            {
                Id = id,
                CompanyName = companyName ?? string.Empty,
                ContactPhone = contactPhone ?? string.Empty
            };
        }
    }
}