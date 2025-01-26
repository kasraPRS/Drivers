

using Microsoft.EntityFrameworkCore;

namespace Drivers.Data.UserProfileRepository
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly ApiDbContext _context;
        public UserProfileRepository(ApiDbContext context)
        {
            _context = context;
        }

        public async Task CreateUserProfileAsync(UserServiceModel user)
        {
            await _context.Profiles.AddAsync(user);
        }

        public Task DeleteUserProfileAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserServiceModel>> GetAllUsersProfileAsync()
        {
            return await _context.Profiles.ToListAsync();
        }

        public Task<UserServiceModel> GetUserProfileByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserProfileAsync(UserServiceModel user)
        {
            throw new NotImplementedException();
        }
    }
}
