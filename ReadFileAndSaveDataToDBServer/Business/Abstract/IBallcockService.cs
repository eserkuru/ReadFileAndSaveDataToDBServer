using System.Collections.Generic;
using ReadFileAndSaveDataToDBServer.DataAccess.Entities.Concrete;

namespace ReadFileAndSaveDataToDBServer.Business.Abstract
{
    public interface IBallcockService
    {
        List<Ballcock> GetAll();
        void Add(Ballcock ballcock);
        void Update(Ballcock ballcock);
        void Delete(int id);
        Ballcock GetById(int id);
    }
}
