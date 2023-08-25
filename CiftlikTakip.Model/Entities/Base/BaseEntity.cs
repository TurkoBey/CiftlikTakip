using Infrastructure.Model;
using System.ComponentModel.DataAnnotations;

namespace CiftlikTakip.Model.Entities.Base
{
    public class BaseEntity : IEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public Guid? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid? DeleteBy { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; } = true;
        public byte[]? Version { get; set; }
    }
}
