using System;
using System.Collections.Generic;

namespace react_dotnet_example.Models
{
    public interface IUserRepository
    {
        IEnumerable<UserModel> GetAll();
        
        UserModel Add(UserModel user);
    }
}