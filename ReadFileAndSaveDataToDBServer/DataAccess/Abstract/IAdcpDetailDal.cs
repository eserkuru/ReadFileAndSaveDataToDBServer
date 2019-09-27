using ReadFileAndSaveDataToDBServer.Core.DataAccess;
using ReadFileAndSaveDataToDBServer.DataAccess.Entities.Concrete;

namespace ReadFileAndSaveDataToDBServer.DataAccess.Abstract
{
    public interface IAdcpDetailDal : IEntityRepository<AdcpDetail>
    {
    }
}
