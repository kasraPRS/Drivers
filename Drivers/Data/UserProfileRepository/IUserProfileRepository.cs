
namespace Drivers.Data
{
    public interface IUserProfileRepository
    {
        Task<List<UserServiceModel>> GetAllUsersProfileAsync();
        Task<UserServiceModel> GetUserProfileByIdAsync(int id);
        Task CreateUserProfileAsync(UserServiceModel user);
        Task UpdateUserProfileAsync(UserServiceModel user);
        Task DeleteUserProfileAsync(int id);
    }
}
