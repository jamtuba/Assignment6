using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Assignment6.Models;
using Newtonsoft.Json;

namespace Assignment6.Helpers
{
    public class ApiRepo : IApiRepo
    {
        private readonly HttpClient _httpClient;

        public ApiRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task SendHttp(OfferClassDTO offerClassDTO)
        {
            //var stringForJson = JsonConvert.SerializeObject(new OfferClass
            //{
            //    OfferNumber = Guid.NewGuid().ToString(),
            //    OfferType = offerClassDTO.OfferType,
            //    FullName = offerClassDTO.FullName,
            //    EmailAddress = offerClassDTO.EmailAddress,
            //    Message = offerClassDTO?.Message
            //});

            var stringForJson = new OfferClass
            {
                OfferNumber = Guid.NewGuid().ToString(),
                OfferType = offerClassDTO.OfferType,
                FullName = offerClassDTO.FullName,
                EmailAddress = offerClassDTO.EmailAddress,
                Message = offerClassDTO?.Message
            };

            //var content = new StringContent(stringForJson, Encoding.UTF8, "text/plain");

            //var request = new HttpRequestMessage
            //{
            //    Method = HttpMethod.Post,
            //    RequestUri = new Uri(Endpoints.MessageSenderEndpoint),
            //    Content = new StringContent(stringForJson, Encoding.UTF8, "text/plain")
            //};

            var endpoint = Endpoints.MessageSenderEndpoint;

            var result = await _httpClient.PostAsJsonAsync(endpoint, stringForJson);
        }
    }
}
