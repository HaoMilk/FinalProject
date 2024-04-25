using FinalProject.Common.Const;
using FinalProject.Common.DAO;
using FinalProject.Common.DTO;
using FinalProject.Common.Helper;
using FinalProject.Database.DTO;
using FinalProject.Database.Entities;
using FinalProject.UC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FinalProject.Common.BUS
{
    public class UserBUS
    {
        private UserDAO _userDAO = new UserDAO();
        private UngVienBUS _ungVienBUS = new UngVienBUS();
        private CongTyBUS _congTyBUS = new CongTyBUS();

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

        public int Add(string username, string password, string email, string status, string role, string phone, string avatarUrl)
        {
            var user = new User(username, password, email, status, role, phone, avatarUrl);
            return _userDAO.Add(user);
        }

        public int Add(User user)
        {
            return _userDAO.Add(user);
        }

        public int Update(int id, string username, string password, string email, string status, string role, string phone, string avatarUrl)
        {
            var user = new User(username, password, email, status, role, phone, avatarUrl);
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

        private bool CheckUsernameExist(string username, string role)
        {
            var input = new UserGetAllInput
            {
                Username = username,
                Role = role
            };
            var user = _userDAO.GetAll(input).FirstOrDefault();
            return user != null;
        }

        public int Signup(string username, string plainPassword, string role)
        {
            var isUsernameExisted = this.CheckUsernameExist(username, role);
            if (isUsernameExisted)
            {
                UCMessageBox.Show("Tên đăng nhập đã tồn tại, vui lòng chọn tên khác!");
                return -1;
            }

            var result = 0;
            var user = new User()
            {
                Username = username,
                Password = plainPassword.ToMD5(),
                Role = role
            };
            var userId = this.Add(user);
            if (userId > 0)
            {
                if (role == UserRoleConst.Candidate)
                {
                    var ungVien = new UngVien()
                    {
                        UserId = userId,
                        NgaySinh = DateTime.Now,
                        TrangThai = StatusConst.Active,
                        CreatedTime = DateTime.Now,
                    };
                    result = _ungVienBUS.Add(ungVien);
                }
                else if (role == UserRoleConst.Employer)
                {
                    var congTy = new CongTy()
                    {
                        UserId = userId,
                        CreatedTime = DateTime.Now,
                    };
                    result = _congTyBUS.Add(congTy);
                }
            }
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

        /// <summary>
        /// Gửi mã OTP qua email để xác thực
        /// </summary>
        /// <param name="user"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public SendEmailBySMTPOutput SendOtpVerifyEmail(User user, string title = null)
        {
            var otp = new Random().Next(100000, 999999).ToString();
            var otpExpiredTime = DateTime.Now.AddDays(1);
            var output = user.SendOtpVerifyEmail(otp, title);

            if (output != null && output.IsSuccess)
            {
                user.Otp = otp;
                user.OtpExpiredTime = otpExpiredTime;

                var result = _userDAO.Update(user);
                if (result <= 0)
                {
                    output.IsSuccess = false;
                    output.ErrorMessage = "Có lỗi xảy ra, vui lòng thử lại sau!";
                }
            }

            return output;
        }

        public bool VerifyOtp(int id, string otp)
        {
            var user = GetById(id);
            if (user == null)
            {
                return false;
            }

            if (user.VerifyOtp(otp) == false)
            {
                return false;
            }
            else
            {

                user.Otp = null;
                user.OtpExpiredTime = null;
                user.IsEmailVerified = true;
                var result = _userDAO.Update(user);
                return result > 0;
            }
        }
    }
}
