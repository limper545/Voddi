using System.ComponentModel.DataAnnotations;

namespace GPAG.Commons.DTOs
{

    public abstract class DTOIdOnly<T>
    {
        public T Id { get; set; }

        public DTOIdOnly()
        {
        }

    }
}