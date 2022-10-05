
using System.Collections.Generic;

namespace ConsolePrj.Entities
{
    public class Personne
    {
        public int Id { get; init; }

        public string Nom { get; init; }

        public string Prenom { get; init; }

        public IList<Coupon> Coupons { get; init; }

    }
}
