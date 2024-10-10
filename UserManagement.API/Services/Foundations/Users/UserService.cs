﻿//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using System.Linq;
using System.Threading.Tasks;
using UserManagement.API.Brokers.Storages;
using UserManagement.API.Models.Foundations.Users;

namespace UserManagement.API.Services.Foundations.Users
{
    public class UserService: IUserService
    {
        private readonly IStorageBroker storageBroker;

        public UserService(IStorageBroker storageBroker)=>
            this.storageBroker = storageBroker;

        public async ValueTask<User> AddUserAsync(User user)=>
            await this.storageBroker.InsertUserAsync(user);
       
        public async ValueTask<IQueryable<User>> RetrieveAllUsers()=>
            await this.storageBroker.SelectAllUsersAsync();
       
        public async ValueTask<User> RetrieveUserByIdAsync(int userId)=>
            await this.storageBroker.SelectUserByIdAsync(userId);

        public async ValueTask<User> ModifyUserAsync(User user)=>
            await this.storageBroker.UpdateUserAsync(user);

        public async ValueTask<User> RemoveUserAsync(int userId)
        {
            User maybeUser = await this.storageBroker.SelectUserByIdAsync(userId);

            return await this.storageBroker.DeleteUserAsync(maybeUser);
        }
           
        public async ValueTask<User> RetrieveUserByEmailAsync(string email)=>
            await this.storageBroker.SelectUserByEmailAsync(email);
    }
}
