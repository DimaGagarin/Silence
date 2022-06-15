
using Voyage.Business.Interfaces;
using Voyage.DataAccess.Interfaces;
using Voyage.DataAccess.Models;

namespace Voyage.Business
{
    public class Service : IService
    {
        private readonly ITransportRepository repository;

        public Service(ITransportRepository repository)
        {
            this.repository = repository;
        }
        public void Create(TransportType transport)
        {
            repository.Create(transport);
        }

        public void Update(TransportType transport)
        {
            repository.Update(transport);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
