using AutoMapper;
using Drivers.Models.DTO_s.Users;
namespace Drivers.Mapper
{
    public class UserProfileMapping : Profile
    {
        public UserProfileMapping()
        {
            CreateMap<UserProfile, UserProfileDto>();

            CreateMap<UserProfileDto, UserProfile>()
                .ForMember(dest => dest.DateOfBirth, opt => opt.Ignore()); // می‌توانید فیلدهایی را نادیده بگیرید
        }
    }
}
