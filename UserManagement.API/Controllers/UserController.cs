
//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;
using System;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.API.Models.Foundations.Users;
using UserManagement.API.Services.Foundations.Users;

namespace UserManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : RESTFulController
    {
        private IUserService userService;

        public UserController(IUserService userService) =>
            this.userService = userService;

        [HttpPost]
        public async ValueTask<ActionResult<User>> PostUserAsync(User user)
        {
            try
            {
                User addedUser =
                    await userService.AddUserAsync(user);

                return Created(addedUser);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpGet]
        public async ValueTask<ActionResult<IQueryable<User>>> GetUsersAllAsync()
        {
            try
            {
                IQueryable<User> users =
                    await this.userService.RetrieveAllUsers();

                return Ok(users);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpGet("{userId:int}")]
        public async ValueTask<ActionResult<User>> GetUserByIdAsync(int userId)
        {
            try
            {
                User user = await this.userService.RetrieveUserByIdAsync(userId);

                return Ok(user);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpPut]
        public async ValueTask<ActionResult<User>> PutUserAsync(User user)
        {
            try
            {
                User modifiedUser =
                    await this.userService.ModifyUserAsync(user);

                return Ok(modifiedUser);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpDelete("{userId}")]
        public async ValueTask<ActionResult<User>> DeleteUserByIdAsync(int userId)
        {
            try
            {
                User deletedUser = await this.userService.RemoveUserAsync(userId);

                return Ok(deletedUser);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpGet("by-email/{email}")]
        public async ValueTask<ActionResult<User>> GetUserByEmailAsync(string email)
        {
            try
            {
                User user = await this.userService.RetrieveUserByEmailAsync(email);

                return Ok(user);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
    }
}

