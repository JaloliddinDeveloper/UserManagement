//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using System.Linq;
using System.Threading.Tasks;
using UserManagement.API.Models.Foundations.Users;

namespace UserManagement.API.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<User> InsertUserAsync(User user);
        ValueTask<IQueryable<User>> SelectAllUsersAsync();
        ValueTask<User> SelectUserByIdAsync(int userId);
        ValueTask<User> UpdateUserAsync(User user);
        ValueTask<User> DeleteUserAsync(User user);
        ValueTask<User> SelectUserByEmailAsync(string email);
    }
}
