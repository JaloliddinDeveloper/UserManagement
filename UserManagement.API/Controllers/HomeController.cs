//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace UserManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController:RESTFulController
    {
        [HttpGet]
        public ActionResult<string> Get()=>
            Ok("Hello. Mario the prince is in another castle.");
    }
}
