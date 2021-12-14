using Core.Entities.Concrete;
using Core.Utilities.Security.JWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public const string WordAdded = "Word added";
        public const string WordDeleted = "Word deleted";
        public const string WordUpdated = "Word updated";
        public const string WordsListed = "Words listed";

        public const string AuthorizationDenied = "Authorization Denied";
        public const string UserAdded = "User added";
        public const string UserDeleted = "User deleted";
        public const string UsersListed = "Users listed";
        public const string UserUpdated = "User updated";
        public const string UserRegistered = "User registered";
        public const string UserNotFound = "User doesn't exist";
        public const string PasswordError = "Password is incorrect";
        public const string SuccessfulLogin = "Successful login";
        public const string UserAlreadyExists = "User already exists";
        public const string AccessTokenCreated = "Acess token created";
    }
}
