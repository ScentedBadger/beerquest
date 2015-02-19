using Microsoft.WindowsAzure.Mobile.Service;

namespace beerquestService.DataObjects
{
    public class Beer : EntityData
    {
        public string Name { get; set; }

        public string ABV { get; set; }

        public string BeerStyle { get; set; }
    }

    public class Brewery : EntityData
    {
        public string Name { get; set; }

        public string CountryId { get; set; }

        public string Website { get; set; }
    }

    public class Country : EntityData
    {
        public string Name { get; set; }

        public string FlagLocation { get; set; }
    }

    public class User : EntityData
    {
        public string Name { get; set; }
    }

    public class BeerUserData
    {
        public string UserId { get; set; }

        public string BeerId { get; set; }

        public int Score { get; set; }

        public int Quantity { get; set; }
    }

    class BeerBrewery
    {
        public string BeerId { get; set; }

        public string BreweryId { get; set; }
    }

}