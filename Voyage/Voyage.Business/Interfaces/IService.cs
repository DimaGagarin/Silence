
using Voyage.DataAccess.Models;

namespace Voyage.Business.Interfaces
{
    public interface IService
    {
        void Create(TransportType transport);

        void Update(TransportType transport);

        void Delete(int id);
    }
}
