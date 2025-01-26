using Drivers.Data;

namespace Drivers.Service
{
    public interface IUserProfileService
    {
        Task<List<UserProfile>> GetAllUsersAsync();
        Task <UserProfile> GetUserProfileByIdAsync(int id);
        Task CreateUserProfileAsync(UserProfile userProfile);
        Task UpdateUserProfileAsync(UserProfile userProfile);
        Task DeleteUserProfileAsync(int id);
    }
    public class UserProfileService : IUserProfileService
    {
        private readonly IUserProfileRepository _userProfileRepository;
        public UserProfileService(IUserProfileRepository userProfileRepository) 
        {
            _userProfileRepository = userProfileRepository;
        }
        public async Task<List<UserProfile>> GetAllUsersAsync()
        {
            return await _userProfileRepository.GetAllUsersProfileAsync();
        }
        public async Task<UserProfile> GetUserProfileByIdAsync(int id)
        {
            return await _userProfileRepository.GetUserProfileByIdAsync(id);
        }
        public async Task CreateUserProfileAsync(UserProfile user)
        {
             await _userProfileRepository.CreateUserProfileAsync(user);
        }
        public async Task UpdateUserProfileAsync(UserProfile user)
        {
            await _userProfileRepository.UpdateUserProfileAsync(user);
        }
        public async Task DeleteUserProfileAsync(int id)
        {
            await _userProfileRepository.DeleteUserProfileAsync(id);
        }

    }

}
