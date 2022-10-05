using AutoMapper;
using ConsolePrj.DTOs;
using ConsolePrj.Entities;

namespace ConsolePrj.MyAutoMapper.Profiles
{
    public class CouponProfile: Profile
    {
        public CouponProfile()
        {
            CreateMap<Coupon, CouponDTO>();
        }
    }
}
