using System.Collections.Generic;
using ReadFileAndSaveDataToDBServer.Business.Abstract;
using ReadFileAndSaveDataToDBServer.DataAccess.Abstract;
using ReadFileAndSaveDataToDBServer.DataAccess.Entities.Concrete;

namespace ReadFileAndSaveDataToDBServer.Business.Concrete
{
    public class BallcockManager : IBallcockService
    {
        private readonly IBallcockDal _ballcockDal;

        public BallcockManager(IBallcockDal ballcockDal)
        {
            _ballcockDal = ballcockDal;

        }
        public List<Ballcock> GetAll()
        {
            return _ballcockDal.GetList();
        }

        public void Add(Ballcock ballcock)
        {
            _ballcockDal.Add(ballcock);
        }

        public void Update(Ballcock ballcock)
        {
            _ballcockDal.Update(ballcock);
        }

        public void Delete(int id)
        {
            _ballcockDal.Delete(new Ballcock { Id = id });
        }

        public Ballcock GetById(int id)
        {
            return _ballcockDal.Get(p => p.Id == id);
        }
    }
}
