using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Voyage.Business.Interfaces;
using Voyage.DataAccess.Models;

namespace Voyage.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransportController : ControllerBase
    {
        private readonly IService service;

        public TransportController(IService service)
        {
            this.service = service;
        }

        [HttpPost(Name = "Create")]
        public void Create(TransportType transport)
        {
            service.Create(transport);
        }

        [HttpPut( Name = "Update")]
        public void Update(TransportType transport)
        {
            service.Update(transport);
        }

        [HttpDelete("{id}", Name = "Delete")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
