using Microsoft.AspNetCore.Mvc;
using RestSharp;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LocationsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
        
    {
        [HttpGet]
        public async Task<string> Get(string categories, string lat, string lon)
        {

            var client = new RestClient($"https://api.foursquare.com/v3/places/search?ll={lat}%2C{lon}&categories={categories}");
            var request = new RestRequest("", Method.Get);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", "fsq3IouFslgXeyTgG52LqbMdbWVL9ZUxR4dkYoed2BnSAwU=");
            var response = client.ExecuteAsync(request);

            return response.Result.Content;
        }


    }
}
