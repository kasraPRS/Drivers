namespace Drivers.Data
{
        public interface IUserProfileRepository
        {
            Task<List<UserProfile>> GetAllUsersProfileAsync();
            Task<UserProfile> GetUserProfileByIdAsync(int id);
            Task CreateUserProfileAsync(UserProfile user);
            Task UpdateUserProfileAsync(UserProfile user);
            Task DeleteUserProfileAsync(int id);
            Task<bool> SaveChangesAsync();
        }
}
