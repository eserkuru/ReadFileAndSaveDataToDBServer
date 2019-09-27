using ReadFileAndSaveDataToDBServer.Entities.Abstract;

namespace ReadFileAndSaveDataToDBServer.DataAccess.Entities.Concrete
{
    public class AdcpDetail : BaseEntity
    {
        public int AdcpId { get; set; }
        public virtual Adcp Adcp { get; set; }

        public int V1 { get; set; }
        public int V2 { get; set; }
        public int V3 { get; set; }
    }
}
