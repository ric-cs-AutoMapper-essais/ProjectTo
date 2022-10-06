using System;
using System.Collections.Generic;
using System.Linq;

using AutoMapper;

using Transverse.Common.DebugTools;

using ConsolePrj.MyAutoMapper;
using ConsolePrj.Entities;
using ConsolePrj.DTOs;
using ConsolePrj.Data;


namespace ConsolePrj
{
    static class Program
    {
        private static IMapper mapper;

        private static Chrono chrono;

        static void Main(string[] args)
        {
            mapper = (new MyAutoMapperFactory()).GetMapper();
            chrono = new Chrono();

            //ICollection<Personne> personnes = Personnes.Get(); Debug.ShowData(personnes); Console.ReadKey();

            Test_PersonnesToPersonnesDTO_via_Select();

            Test_PersonnesToPersonnesDTO_via_Select_et_AutoMapper_Map();

            Test_PersonnesToPersonnesDTO_via_AutoMapper_ProjectTo();
        }


        private static void Test_PersonnesToPersonnesDTO_via_Select()
        {
            Console.WriteLine("\n\n\n\n--------- Test_PersonnesToPersonnesDTO_via_Select (très rapide) ---------\n");

            ICollection<Personne> personnes = Personnes.Get();

            chrono.Start();
            Debug.ShowData(
                personnes.Select(personne => new PersonneDTO()
                    { //Conversion A LA MANO., chaque Personne en PersonneDTO.
                        Id = personne.Id,
                        NomComplet = $"{personne.Nom} - {personne.Prenom}",
                        Coupons = personne.Coupons.Select(coupon => new CouponDTO()
                        {
                            ID = coupon.Id,
                            CODE = coupon.Code
                        }).ToList()
                    }
               ) 
            );
            chrono.StopAndShowDuration();

            Console.ReadKey();
        }


        private static void Test_PersonnesToPersonnesDTO_via_Select_et_AutoMapper_Map()
        {
            Console.WriteLine("\n\n\n\n--------- Test_PersonnesToPersonnesDTO_via_Select_et_Map (assez rapide) ---------\n");

            ICollection<Personne> personnes = Personnes.Get();

            chrono.Start();
            Debug.ShowData(
                personnes.Select(personne => mapper.Map<PersonneDTO>(personne)) //Conversion chaque Personne en PersonneDTO suivant PersonneProfile.
            );
            chrono.StopAndShowDuration();

            Console.ReadKey();
        }


        private static void Test_PersonnesToPersonnesDTO_via_AutoMapper_ProjectTo()
        {
            Console.WriteLine("\n\n\n\n--------- Test_PersonnesToPersonnesDTO_via_ProjectTo (Le moins rapide !) ---------\n");

            ICollection<Personne> personnes = Personnes.Get();

            chrono.Start();
            Debug.ShowData(
                mapper.ProjectTo<PersonneDTO>(personnes.AsQueryable()) //Conversion chaque Personne en PersonneDTO suivant PersonneProfile.
            );
            chrono.StopAndShowDuration();

            Console.ReadKey();
        }
    }
}
