using ReadFileAndSaveDataToDBServer.Core.DataAccess.EntityFrameworkCore;
using ReadFileAndSaveDataToDBServer.DataAccess.Abstract;
using ReadFileAndSaveDataToDBServer.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using ReadFileAndSaveDataToDBServer.DataAccess.Entities.Concrete;

namespace ReadFileAndSaveDataToDBServer.DataAccess.Concrete.EntityFrameworkCore.Dals
{
    public class EfBallcockDal : EfEntityRepositoryBase<Ballcock, DbBallcockData>, IBallcockDal
    {
    }
}
