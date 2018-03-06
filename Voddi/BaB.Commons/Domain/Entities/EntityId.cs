using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GPAG.Commons.Domain.Entities
{

    public abstract class EntityId<T> : EntityIdOnly<T>
    {
        [Timestamp]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public byte[] ConcurrencyToken { get; set; }

        public EntityId()
        {
        }

    }
}