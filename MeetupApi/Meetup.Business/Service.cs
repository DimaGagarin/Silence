using Meetup.Business.Interfaces;
using Meetup.DataAccess.Interfaces;
using Meetup.DataAccess.Models;

namespace Meetup.Business
{
    public class Service : IService
    {
        private readonly IRepository repository;

        public Service(IRepository repository)
        {
            this.repository = repository;
        }

        public List<Event> GetAll()
        {
            return repository.GetAll();
        }

        public Event? GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Create(Event anyEvent)
        {
            repository.Create(anyEvent);
        }

        public void Update(Event anyEvent)
        {
            repository.Update(anyEvent);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}