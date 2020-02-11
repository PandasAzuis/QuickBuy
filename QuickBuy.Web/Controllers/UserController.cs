using Microsoft.AspNetCore.Mvc;
using QuickBuy.Domain.Contracts;
using QuickBuy.Domain.Entities;

namespace QuickBuy.Web.Controllers
{
    [Route("api/[Controller]")]
    public class UserController : Controller
    {

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                // Status Code 200
                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post()
        {
            try
            {
                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("CheckUser")]
        public ActionResult CheckUser([FromBody]User user)
        {
            try
            {
                if(user.Email == "nicoly.melo18@outlook.com" && user.Password == "0")
                    return Ok(user);

                return BadRequest("User or password invalid!");
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
