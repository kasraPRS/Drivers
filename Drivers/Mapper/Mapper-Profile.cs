using AutoMapper;
using Drivers.Models.DTO_s.Profile;
using Drivers.Models.DTO_s.Users;
namespace Drivers.Mapper
{
    public class UserProfileMapping : Profile
    {
        public UserProfileMapping()
        {
            CreateMap<UserServiceModel, UserProfileDto>();

            CreateMap<UserCreateDto, UserServiceModel>();

            //CreateMap<UserProfileRequestResponce, UserProfile>();
        }

    }

}
