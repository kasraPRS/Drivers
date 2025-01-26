using AutoMapper;
using Drivers.Models.DTO_s.Profile;
using Drivers.Models.DTO_s.Users;

namespace Drivers.Mapper
{
    public class BankCardMapper
    {
        public class BankCardMapping : Profile
        {
            public BankCardMapping()
            {
                CreateMap<UserServiceModel, UserProfileDto>();

                CreateMap<UserCreateDto, UserServiceModel>();

                //CreateMap<UserProfileRequestResponce, UserProfile>();
            }

        }
    }
}
