using System.Collections.Generic;
using ReadFileAndSaveDataToDBServer.Business.Abstract;
using ReadFileAndSaveDataToDBServer.DataAccess.Abstract;
using ReadFileAndSaveDataToDBServer.DataAccess.Entities.Concrete;

namespace ReadFileAndSaveDataToDBServer.Business.Concrete
{
    public class AdcpManager : IAdcpService
    {
        private readonly IAdcpDal _adcpDal;

        public AdcpManager(IAdcpDal adcpDal)
        {
            _adcpDal = adcpDal;

        }
        public List<Adcp> GetAll()
        {
            return _adcpDal.GetList();
        }

        public void Add(Adcp adcp)
        {
            _adcpDal.Add(adcp);
        }

        public void Update(Adcp adcp)
        {
            _adcpDal.Update(adcp);
        }

        public void Delete(int id)
        {
            _adcpDal.Delete(new Adcp { Id = id });
        }

        public Adcp GetById(int id)
        {
            return _adcpDal.Get(p => p.Id == id);
        }
    }
}
