using Meetup.Business.Interfaces;
using Meetup.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetupApi.Controllers
{
    [ApiController]
    [Route("xui")]
    public class MeetupController : ControllerBase
    {
        private readonly IService service;

        public MeetupController(IService service)
        {
            this.service = service;
        }

        [HttpGet(Name = "GetAll")]
        public List<Event> GetAll()
        {
            return service.GetAll();
        }

        [HttpGet("{id}", Name = "GetById")]
        public Event? GetById(int id)
        {
            return service.GetById(id);
        }

        [HttpPost(Name = "Create")]
        public void Create(Event anyEvent)
        {
            service.Create(anyEvent);
        }

        [HttpPut("{id}", Name = "Update")]
        public void Update(Event anyEvent)
        {
            service.Update(anyEvent);
        }

        [HttpDelete(Name = "Delete")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}