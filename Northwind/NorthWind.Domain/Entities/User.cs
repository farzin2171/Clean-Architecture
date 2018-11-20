using NorthWind.Domain.ValueObjects;

namespace NorthWind.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }

        public AdAccount AdAccount { get; set; }
    }
}
