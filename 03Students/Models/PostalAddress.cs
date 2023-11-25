// Models.PostalAddress.cs

namespace DSS.Models
{
    public class PostalAddress
    {
        public string Street { get; set; } = "Unknown";
        public string City { get; set; } = "Unknown";
        public string PostalCode { get; set; } = "";
        public string State { get; set; } = "Unknown";
    }
}
