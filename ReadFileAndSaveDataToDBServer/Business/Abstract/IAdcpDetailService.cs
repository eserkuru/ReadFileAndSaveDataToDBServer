using System.Collections.Generic;
using ReadFileAndSaveDataToDBServer.DataAccess.Entities.Concrete;

namespace ReadFileAndSaveDataToDBServer.Business.Abstract
{
    public interface IAdcpDetailService
    {
        List<AdcpDetail> GetAll();
        void Add(AdcpDetail adcpDetail);
        void Update(AdcpDetail adcpDetail);
        void Delete(int id);
        AdcpDetail GetById(int id);
    }
}
