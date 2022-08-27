using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace UserPersonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "this", "is", "hard", "code" };
        }
    }
}