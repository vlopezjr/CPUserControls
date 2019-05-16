using CreateCustomer.API.DomainServices;
using System.Collections.Generic;
using System.Linq;
using CreateCustomer.API.Entities;

namespace CPUserControls.AddressModule
{
    internal static class ZoneGenerator
    {
        internal static List<string> GenerateHardCodedUSStates()
        {
            var states = new List<string>
            {
                "AL",
                "AK",
                "AZ",
                "AR",
                "CA",
                "CO",
                "CT",
                "DE",
                "FL",
                "GA",
                "HI",
                "ID",
                "IL",
                "IN",
                "IA",
                "KS",
                "KY",
                "LA",
                "ME",
                "MD",
                "MA",
                "MI",
                "MN",
                "MS",
                "MO",
                "MT",
                "NE",
                "NV",
                "NH",
                "NJ",
                "NM",
                "NY",
                "NC",
                "ND",
                "OH",
                "OK",
                "OR",
                "PA",
                "RI",
                "SC",
                "SD",
                "TN",
                "TX",
                "UT",
                "VT",
                "VA",
                "WA",
                "WV",
                "WI",
                "WY"
            };

            return states;
        }


        internal static List<string> GenerateCountryIDs()
        {
            var service = new LookUpService();
            var countries = service.GetAllCountries();

            return countries.Select(c => c.CountryID.TrimEnd()).OrderBy(c => c).ToList();
        }

        internal static List<string> GenerateStateIDsByCountry(string countryId)
        {
            var service = new LookUpService();
            var states = service.GetStatesByCountryID(countryId);
            return states;
        }
    }
}
