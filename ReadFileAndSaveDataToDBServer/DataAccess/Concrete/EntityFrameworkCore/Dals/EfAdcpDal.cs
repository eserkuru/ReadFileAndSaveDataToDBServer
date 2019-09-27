using System;
using System.Collections.Generic;
using System.Text;
using ReadFileAndSaveDataToDBServer.Core.DataAccess.EntityFrameworkCore;
using ReadFileAndSaveDataToDBServer.DataAccess.Abstract;
using ReadFileAndSaveDataToDBServer.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using ReadFileAndSaveDataToDBServer.DataAccess.Entities.Concrete;

namespace ReadFileAndSaveDataToDBServer.DataAccess.Concrete.EntityFrameworkCore.Dals
{
    public class EfAdcpDal : EfEntityRepositoryBase<Adcp, DbBallcockData>, IAdcpDal
    {
    }
}
