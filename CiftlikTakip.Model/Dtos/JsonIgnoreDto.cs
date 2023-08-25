using Infrastructure.Model;
using System.Text.Json.Serialization;

namespace CiftlikTakip.Model.Dtos
{
    public class JsonIgnoreDto : IEntity
    {
        [JsonIgnore]
        public bool IsActive { get; set; }
        [JsonIgnore]
        public byte[]? Version { get; set; }
        [JsonIgnore]
        public Guid? CreatedBy { get; set; }
        [JsonIgnore]
        public DateTime? CreationDate { get; set; }
        [JsonIgnore]
        public Guid? UpdateBy { get; set; }
        [JsonIgnore]
        public DateTime? UpdateDate { get; set; }
    }
}
