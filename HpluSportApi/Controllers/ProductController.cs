using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HpluSportApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public String GetProducts()
        {
            return "ok";
        }
    }
}
