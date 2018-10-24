using System;
using System.ComponentModel.DataAnnotations;

namespace ListingScraper.Entities
{
    public interface IEntity
    {
        int Id { get; set; }
    }

    public abstract class EntityBase : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedOn { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
