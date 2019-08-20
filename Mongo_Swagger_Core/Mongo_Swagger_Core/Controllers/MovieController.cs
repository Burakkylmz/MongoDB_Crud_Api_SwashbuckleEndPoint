using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mongo_Swagger_Core.Models.Concrete;
using Mongo_Swagger_Core.Service.Concrete;

namespace Mongo_Swagger_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : BaseController<Movie>
    {
        public MovieController(MovieRepo movieRepo):base(movieRepo)
        {

        }
    }
}