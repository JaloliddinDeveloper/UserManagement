//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.API.Models.Foundations.Users;

namespace UserManagement.API.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<User> Users { get; set; }

        public async ValueTask<User> InsertUserAsync(User user) =>
            await InsertAsync(user);

        public async ValueTask<IQueryable<User>> SelectAllUsersAsync() =>
            await SelectAllAsync<User>();

        public async ValueTask<User> SelectUserByIdAsync(int userId) =>
            await SelectByIdAsync<User>(userId);

        public async ValueTask<User> UpdateUserAsync(User user) =>
            await UpdateAsync(user);

        public async ValueTask<User> DeleteUserAsync(User user) =>
            await DeleteAsync(user);

        public async ValueTask<User> SelectUserByEmailAsync(string email)
        {
            using var broker = new StorageBroker(this.configuration);
            return await broker.Users.FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}
