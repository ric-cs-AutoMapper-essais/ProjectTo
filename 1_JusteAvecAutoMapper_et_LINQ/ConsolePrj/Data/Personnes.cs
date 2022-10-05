using ConsolePrj.Entities;
using System.Collections.Generic;

namespace ConsolePrj.Data
{
    public static class Personnes
    {
        public static ICollection<Personne> Get()
        {
            return new[]
            {
                new Personne() { Id = 1, Nom = "AAA", Prenom = "aaa", Coupons = new[]{ new Coupon() { Id=10, Code="A10" }, new Coupon() { Id = 100, Code = "A100" } } },
                new Personne() { Id = 2, Nom = "BBB", Prenom = "bbb", Coupons = new[]{ new Coupon() { Id=20, Code="B20" }, new Coupon() { Id = 200, Code = "B200" } } },
                new Personne() { Id = 3, Nom = "CCC", Prenom = "ccc", Coupons = new[]{ new Coupon() { Id=30, Code="C30" }, new Coupon() { Id = 300, Code = "C300" } } },
                new Personne() { Id = 4, Nom = "DDD", Prenom = "ddd", Coupons = new[]{ new Coupon() { Id=40, Code="D40" }, new Coupon() { Id = 400, Code = "D400" } } },
                new Personne() { Id = 5, Nom = "EEE", Prenom = "eee", Coupons = new[]{ new Coupon() { Id=50, Code="E50" }, new Coupon() { Id = 500, Code = "E500" } } },
                new Personne() { Id = 6, Nom = "FFF", Prenom = "fff", Coupons = new[]{ new Coupon() { Id=60, Code="F60" }, new Coupon() { Id = 600, Code = "F600" } } },

            };
        }
    }
}
