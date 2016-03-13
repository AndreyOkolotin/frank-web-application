using System.Web.Http;

namespace FrankWebApi.Controllers
{
    public class CommonController : ApiController
    {
        [Route("api/accountInfo")]
        public IHttpActionResult GetAccountInfo()
        {
            return this.Ok("Info template");
        }
    }
}
