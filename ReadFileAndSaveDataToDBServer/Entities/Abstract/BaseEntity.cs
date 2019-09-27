using System.ComponentModel.DataAnnotations.Schema;
using ReadFileAndSaveDataToDBServer.Core.Entities;

namespace ReadFileAndSaveDataToDBServer.Entities.Abstract
{
    public class BaseEntity : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
    }
}
