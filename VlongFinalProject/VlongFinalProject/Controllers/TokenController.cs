using VlongFinalProject.Models;
using Microsoft.AspNetCore.Mvc;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VlongFinalProject.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {

        [HttpGet]
        [Route("{email}/{password}")]
        public dynamic Get(string email, string password)
        {
            var token = TokenHelper.GetToken(email, password);
            if (token == null)
            {
                return Unauthorized();
            }
            return new { Token = token };
        }

    }
}
