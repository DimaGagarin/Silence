
using Voyage.DataAccess.Models;

namespace Voyage.DataAccess.Interfaces
{
    public interface ITransportRepository
    {
        void Create(TransportType transport);

        void Update(TransportType transport);

        void Delete(int id);
    }
}
