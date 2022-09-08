using VlongFinalProject.Models;
using Microsoft.AspNetCore.Mvc;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VlongFinalProject.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {

        [HttpPost]
        public dynamic Post([FromBody] TokenRequest tokenRequest)
        {
            var token = TokenHelper.Tokenize(tokenRequest.Password);
            return new { Token = token };
        }

    }
}
