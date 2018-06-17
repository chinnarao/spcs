namespace SP.DL.Models
{
    public class CountryVM 
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
    }

    public class StateVM
    {
        public string StateCode { get; set; }
        public string StateName { get; set; }
    }

    public class CountyOrProvinceVM
    {
        public string CountyOrProvinceCode { get; set; }
        public string CountyOrProvinceName { get; set; }
    }

    public class CommunityVM
    {
        public string CommunityCode { get; set; }
        public string CommunityName { get; set; }
    }

    public class CityVM 
    {
        public string CityName { get; set; }
        public string CityZipCode { get; set; }
    }

    public class PlaceVM
    {
        public int PlaceID { get; set; }
        public string PlaceName { get; set; }
        public decimal PlaceLatitude { get; set; }
        public decimal PlaceLongitude { get; set; }
        public decimal PlaceAccuracyLatLong { get; set; }
        public string PlaceZipCode { get; set; }
    }
}
