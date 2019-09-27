using System.Collections.Generic;
using ReadFileAndSaveDataToDBServer.DataAccess.Entities.Concrete;

namespace ReadFileAndSaveDataToDBServer.Business.Abstract
{
    public interface IAdcpService
    {
        List<Adcp> GetAll();
        void Add(Adcp adcp);
        void Update(Adcp adcp);
        void Delete(int id);
        Adcp GetById(int id);
    }
}
