
using Voyage.DataAccess.Context;
using Voyage.DataAccess.Interfaces;
using Voyage.DataAccess.Models;

namespace Voyage.DataAccess.Repositories
{
    public class TransportRepository: ITransportRepository
    {
        private readonly ApplicationDbContext appContext;

        public TransportRepository(ApplicationDbContext context)
        {
            appContext = context;
        }

        public void Create(TransportType transport)
        {
            appContext.TransportTypes.Add(transport);
            appContext.SaveChanges();
        }

        public void Update(TransportType transport)
        {
            appContext.TransportTypes.Update(transport);
            appContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var transport = appContext.TransportTypes.Find(id);
            if (transport != null)
            {
                appContext.TransportTypes.Remove(transport);
                appContext.SaveChanges();
            }
        }



    }
}
