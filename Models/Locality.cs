namespace Recruitment_Angels.Models
{
    public class Locality
    {
        public IList<LocalityTable> Table { get; set; }
    }


    public class LocalityTable
    {
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string PostalCode { get; set; }
        public string FullAddress { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string AddressLine5 { get; set; }
        public bool RemoteWilling { get; set; }
        public bool RelocateWilling { get; set; }


    }
}