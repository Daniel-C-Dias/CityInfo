namespace CityInfoAPI.Controllers
{
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/cities")]
    public class CitiesController
    {
        [HttpGet()]
        public JsonResult GetCities()
        {
            return new JsonResult(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public JsonResult GetCity(int id)
        {
            return new JsonResult(
                CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id)
                );
        }
    }
}