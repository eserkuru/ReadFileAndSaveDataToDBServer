using ReadFileAndSaveDataToDBServer.Entities.Abstract;

namespace ReadFileAndSaveDataToDBServer.DataAccess.Entities.Concrete
{
    public class Adcp : BaseEntity
    {
        public int BallcockId { get; set; }
        public virtual Ballcock Ballcock { get; set; }
        public int ProfileNo { get; set; }
        public string DateTime { get; set; }
        public string VDT { get; set; }
        public decimal V1 { get; set; }
        public decimal V2 { get; set; }
        public decimal V3 { get; set; }
        public decimal V4 { get; set; }
        public decimal V5 { get; set; }
        public decimal V6 { get; set; }
        public decimal V7 { get; set; }
        public decimal V8 { get; set; }
        public decimal V9 { get; set; }
        public decimal V10 { get; set; }
        public decimal V11 { get; set; }
    }
}
