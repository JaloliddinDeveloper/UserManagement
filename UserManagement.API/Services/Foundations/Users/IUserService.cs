//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using System.Linq;
using System.Threading.Tasks;
using UserManagement.API.Models.Foundations.Users;

namespace UserManagement.API.Services.Foundations.Users
{
    public interface IUserService
    {
        ValueTask<User> AddUserAsync(User user);
        ValueTask<IQueryable<User>> RetrieveAllUsers();
        ValueTask<User> RetrieveUserByIdAsync(int userId);
        ValueTask<User> ModifyUserAsync(User user);
        ValueTask<User> RemoveUserAsync(int userId);
        ValueTask<User> RetrieveUserByEmailAsync(string email);
    }
}
