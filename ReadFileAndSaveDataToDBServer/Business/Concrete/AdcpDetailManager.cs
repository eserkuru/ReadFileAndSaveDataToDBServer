using System.Collections.Generic;
using ReadFileAndSaveDataToDBServer.Business.Abstract;
using ReadFileAndSaveDataToDBServer.DataAccess.Abstract;
using ReadFileAndSaveDataToDBServer.DataAccess.Entities.Concrete;

namespace ReadFileAndSaveDataToDBServer.Business.Concrete
{
    public class AdcpDetailManager : IAdcpDetailService
    {
        private readonly IAdcpDetailDal _adcpDetailDal;

        public AdcpDetailManager(IAdcpDetailDal adcpDetailDal)
        {
            _adcpDetailDal = adcpDetailDal;

        }
        public List<AdcpDetail> GetAll()
        {
            return _adcpDetailDal.GetList();
        }

        public void Add(AdcpDetail adcpDetail)
        {
            _adcpDetailDal.Add(adcpDetail);
        }

        public void Update(AdcpDetail adcpDetail)
        {
            _adcpDetailDal.Update(adcpDetail);
        }

        public void Delete(int id)
        {
            _adcpDetailDal.Delete(new AdcpDetail { Id = id });
        }

        public AdcpDetail GetById(int id)
        {
            return _adcpDetailDal.Get(p => p.Id == id);
        }
    }
}
