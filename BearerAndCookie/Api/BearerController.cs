using BearerAndCookie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace BearerAndCookie.Api
{
    [RoutePrefix("api/Bearer")]
    public class BearerController : BaseApiController
    {

        [Authorize]
        [Route("Register")]
        public bool Register(UserModel userModel)
        {
            if (!ModelState.IsValid)
            {
                return false;
            }

            return true;
        }


    }
}
