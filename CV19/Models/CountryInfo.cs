namespace CV19.Models
{
    internal class CountryInfo : PlaceInfo
    {
        public required IEnumerable<ProvinceInfo> ProvinceCounts { get; set; }
    }
}
