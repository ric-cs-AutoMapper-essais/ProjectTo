
using System.Collections.Generic;

namespace ConsolePrj.DTOs
{
    public class PersonneDTO
    {
        public int Id { get; init; }

        public string NomComplet { get; init; }

        public ICollection<CouponDTO> Coupons { get; init; }


    }
}
