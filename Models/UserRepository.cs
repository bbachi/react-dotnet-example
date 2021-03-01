using System;
using System.Collections.Generic;

namespace react_dotnet_example.Models
{
    public class UserRepository: IUserRepository
    {
        private List<UserModel> users = new List<UserModel>();
        private int _nextId = 1;

        public UserRepository()
        {
            Add(new UserModel { firstName= "first1", lastName="last1", email="email1@gmail.com"});
            Add(new UserModel { firstName= "first2", lastName="last2", email="email2@gmail.com"});
            Add(new UserModel { firstName= "first3", lastName="last3", email="email3@gmail.com"});
        }

        public IEnumerable<UserModel> GetAll()
        {
            return users;
        }

        public UserModel Add(UserModel item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            users.Add(item);
            return item;
        }
    }
}