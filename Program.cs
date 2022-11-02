using ServiceCountry;
using System;
using System.ServiceModel;
using System.Threading.Tasks;

namespace ATV_AWS_SOAP
{
    class Program
    {
        static CountryInfoServiceSoapTypeClient client;
        static async Task Main(string[] args)
        {
            client = new CountryInfoServiceSoapTypeClient(CountryInfoServiceSoapTypeClient.EndpointConfiguration.CountryInfoServiceSoap12,
                                              new EndpointAddress(
                                                  "http://webservices.oorsprong.org/websamples.countryinfo/CountryInfoService.wso"));


            tCountryCodeAndName[] countryList = await GetListOfCountry();

            var lastCountryISOCode = countryList[countryList.Length - 1].sISOCode;
            var lastCountry = await GetCountryByCode(lastCountryISOCode);

            var capital = await GetCapitalCity(lastCountryISOCode);
            var currency = await GetCurrency(lastCountryISOCode);
            var phone = await GetPhone(lastCountryISOCode);

            Console.WriteLine($"Foram encontrados {countryList.Length} países.");
            Console.WriteLine($"O país de código {lastCountryISOCode} é {lastCountry}.");
            Console.WriteLine($"A capital do país é {capital}.");
            Console.WriteLine($"A moeda do país é {currency}.");
            Console.WriteLine($"O código de telefone do país é {phone}.");

        }

        public static async Task<tCountryCodeAndName[]> GetListOfCountry()
        {
            ListOfCountryNamesByNameResponse response = await client.ListOfCountryNamesByNameAsync();
            tCountryCodeAndName[] result = response.Body.ListOfCountryNamesByNameResult;
            return result;

        }

        public static async Task<string> GetCountryByCode(string Code)
        {
            CountryNameResponse response = await client.CountryNameAsync(Code);
            return response.Body.CountryNameResult;           
        }

        public static async Task<string> GetCapitalCity(string Code)
        {
            CapitalCityResponse response = await client.CapitalCityAsync(Code);
            return response.Body.CapitalCityResult;
        }

        public static async Task<string> GetCurrency(string Code)
        {
            CountryCurrencyResponse response = await client.CountryCurrencyAsync(Code);
            return response.Body.CountryCurrencyResult.sName;
        }

        public static async Task<string> GetPhone(string Code)
        {
            CountryIntPhoneCodeResponse response = await client.CountryIntPhoneCodeAsync(Code);
            return response.Body.CountryIntPhoneCodeResult;
        }


    }
}
