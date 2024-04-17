using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Common.Const;
using FinalProject.Common.Helper;

namespace FinalProject.Database.Entities
{
    public class User
    {
        public static string TableName = "User";
        public static string DefaultAvatarUrl = "https://img.icons8.com/bubbles/200/picture.png";

        private string _password;
        private string _role;

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password
        {
            get => this._password;
            set
            {
                this._password = value.ToMD5();
            }
        }
        public string Email { get; set; } = string.Empty;
        public string Status { get; set; } = StatusConst.Waiting;
        public string Role
        {
            get => this._role;
            set
            {
                if (value == UserRoleConst.Admin || value == UserRoleConst.Candidate || value == UserRoleConst.Employer)
                {
                    this._role = value;
                }
                else
                {
                    throw new Exception("Invalid role");
                }
            }
        }
        public string Phone { get; set; } = string.Empty;
        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime? UpdatedTime { get; set; }
        private string _avatarUrl;
        public string AvatarUrl
        {
            get
            {
                if (this._avatarUrl == null)
                {
                    return DefaultAvatarUrl;
                }
                return this._avatarUrl;
            }
            set
            {
                if (value == null)
                {
                    this._avatarUrl = DefaultAvatarUrl;
                }
                else
                {
                    this._avatarUrl = value;
                }
            }
        }

        public User()
        {
            this.CreatedTime = DateTime.Now;
            this.IsDeleted = false;
        }

        public User(string username, string password, string email, string status, string role, string phone, string avatarUrl)
        {
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.Status = status;
            this.Role = role;
            this.Phone = phone;
            this.CreatedTime = DateTime.Now;
            this.IsDeleted = false;
            this.AvatarUrl = avatarUrl;
        }
    }
}
