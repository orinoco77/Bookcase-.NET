using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Bookcase.Web.Controllers
{
    public class EbookController : ApiController
    {
        public JsonResult Get(int Id)
        {
            return new JsonResult(Json(Ebooks[Id]));
        }
    }
}
