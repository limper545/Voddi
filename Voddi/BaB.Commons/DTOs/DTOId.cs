using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GPAG.Commons.DTOs
{

    public abstract class DTOId<T> : DTOIdOnly<T>
    {
        public string ConcurrencyToken { get; set; }

        public DTOId()
        {
        }

    }
}