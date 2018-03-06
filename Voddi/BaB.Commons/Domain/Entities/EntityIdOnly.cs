using System.ComponentModel.DataAnnotations;

namespace GPAG.Commons.Domain.Entities
{

    public abstract class EntityIdOnly<T>
    {
        [Key]
        public T Id { get; set; }

        public EntityIdOnly()
        {
        }

    }
}