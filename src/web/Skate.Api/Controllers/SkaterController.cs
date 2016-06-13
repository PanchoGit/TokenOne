﻿using System.Web.Http;
using Skate.Api.Attributes;
using Skate.Api.Services;

namespace Skate.Api.Controllers
{
    [AppAuthorize]
    public class SkaterController : ApiController
    {
        private readonly SkaterService service;

        public SkaterController()
        {
            service = new SkaterService();
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var result = service.Get();

            return Ok(result);
        }
    }
}