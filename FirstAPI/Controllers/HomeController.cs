﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstAPI.Controllers
{
    public class HomeController : ApiController
    {

        [HttpGet]
        public IHttpActionResult First()
        {
            return Ok("Success");
        }
    }
}
