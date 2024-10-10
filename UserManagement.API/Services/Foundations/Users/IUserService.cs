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
        ValueTask<User> AddUserService(User user);
        ValueTask<IQueryable<User>> RetrieveAllUsers();
        ValueTask<User> RetrieveUserByIdAsync(int userId);
        ValueTask<User> ModifyUserService(User user);
        ValueTask<User> RemoveUserService(int userId);
        ValueTask<User> RetrieveUserByEmailAsync(string email);

    }
}
