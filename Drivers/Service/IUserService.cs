using Drivers.Data;

namespace Drivers.Service
{
    public interface IUserProfileService
    {
        Task<List<UserServiceModel>> GetAllUsersAsync();
        Task<UserServiceModel> GetUserProfileByIdAsync(int id);
        Task CreateUserProfileAsync(UserServiceModel userProfile);
        Task UpdateUserProfileAsync(UserServiceModel userProfile);
        Task DeleteUserProfileAsync(int id);
    }
    public class UserProfileService : IUserProfileService
    {
        private readonly IUserProfileRepository _userProfileRepository;
        public UserProfileService(IUserProfileRepository userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
        }



        public async Task<List<UserServiceModel>> GetAllUsersAsync()
        {
            return await _userProfileRepository.GetAllUsersProfileAsync();
        }
        public async Task<UserServiceModel> GetUserProfileByIdAsync(int id)
        {
            return await _userProfileRepository.GetUserProfileByIdAsync(id);
        }
        public async Task CreateUserProfileAsync(UserServiceModel user)
        {
            await _userProfileRepository.CreateUserProfileAsync(user);

        }
        public async Task UpdateUserProfileAsync(UserServiceModel user)
        {
            await _userProfileRepository.UpdateUserProfileAsync(user);
        }
        public async Task DeleteUserProfileAsync(int id)
        {
            await _userProfileRepository.DeleteUserProfileAsync(id);
        }



    }

}
