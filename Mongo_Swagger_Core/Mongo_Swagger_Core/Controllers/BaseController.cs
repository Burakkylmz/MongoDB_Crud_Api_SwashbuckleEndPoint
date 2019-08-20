using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mongo_Swagger_Core.Models.Abstract;
using Mongo_Swagger_Core.Service.Abstract;

namespace Mongo_Swagger_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TModel> : ControllerBase where TModel : BaseModel
    {
        public BaseRepo<TModel> BaseMongoRepo { get; set; }

        public BaseController(BaseRepo<TModel> baseMongoRepo)
        {
            this.BaseMongoRepo = baseMongoRepo;
        }

        [HttpGet]
        public virtual ActionResult GetModel(string id)
        {
            return Ok(this.BaseMongoRepo.GetById(id));
        }

        [HttpGet("~/GetModelList")]
        public virtual ActionResult GetModelList()
        {
            return Ok(this.BaseMongoRepo.GetList());
        }

        [HttpPost]
        public virtual ActionResult AddModel(TModel model)
        {
            return Ok(this.BaseMongoRepo.Create(model));
        }

        [HttpPut]
        public virtual ActionResult UpdateModel(string id, TModel model)
        {
            this.BaseMongoRepo.Update(id, model);
            return Ok();
        }

        [HttpDelete("{id}")]
        public virtual void DeleteModel(string id)
        {
            this.BaseMongoRepo.Delete(id);
        }

    }
}