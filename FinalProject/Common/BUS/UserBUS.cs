using FinalProject.Common.DAO;
using FinalProject.Common.Helper;
using FinalProject.Database.DTO;
using FinalProject.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Common.BUS
{
    public class UserBUS
    {
        private UserDAO _userDAO = new UserDAO();

        public int CheckExist(int id)
        {
            return _userDAO.CheckExist(id);
        }

        public int Count()
        {
            return _userDAO.Count();
        }

        public List<User> GetAll(UserGetAllInput input = null)
        {
            return _userDAO.GetAll(input);
        }

        public int Add(string username, string password, string email, string status, string role, string phone)
        {
            var user = new User(username, password, email, status, role, phone);
            return _userDAO.Add(user);
        }

        public int Add(User user)
        {
            return _userDAO.Add(user);
        }

        public int Update(int id, string username, string password, string email, string status, string role, string phone)
        {
            var user = new User(username, password, email, status, role, phone);
            user.Id = id;
            return _userDAO.Update(user);
        }

        public int Update(User user)
        {
            return _userDAO.Update(user);
        }

        public int Delete(int id)
        {
            return _userDAO.Delete(id);
        }

        public User GetById(int id)
        {
            return _userDAO.GetById(id);
        }

        public int SoftDelete(int id)
        {
            return _userDAO.SoftDelete(id);
        }

        public User Login(string username, string plainPassword, string role)
        {
            var input = new UserGetAllInput
            {
                Username = username,
                Password = plainPassword.ToMD5(),
                Role = role
            };
            var user = _userDAO.GetAll(input).FirstOrDefault();
            return user;
        }
        public int Signup(string username, string plainPassword, string role)
        {
            var user = new User()
            {
                Username = username,
                Password = plainPassword.ToMD5(),
                Role = role
            };
            var result = _userDAO.Add(user);
            return result;
        }

        /// <summary>
        /// Change password of user by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newPlainPassword"></param>
        /// <returns>true, if success</returns>
        public bool ChangePassword(int id, string newPlainPassword)
        {
            var user = GetById(id);
            if (user == null)
            {
                return false;
            }
            user.Password = newPlainPassword.ToMD5();
            var result = _userDAO.Update(user);

            return result > 0;
        }
    }
}
