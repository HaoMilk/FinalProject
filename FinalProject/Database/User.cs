namespace FinalProject.Database
{
    using FinalProject.Common.Const;
    using FinalProject.Common.DTO;
    using FinalProject.Common.Helper;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.IO;
    using System.Text;

    [Table("User")]
    public partial class User
    {
        public static string DefaultAvatarUrl = "https://img.icons8.com/bubbles/200/picture.png";

        public int Id { get; set; }

        [StringLength(50)]
        public string UserName { get; set; } = string.Empty;

        [StringLength(50)]
        public string Password { get; set; } = string.Empty;

        [StringLength(50)]
        public string Email { get; set; } = string.Empty;

        [StringLength(50)]
        public string Status { get; set; } = StatusConst.Waiting;

        public bool? IsDeleted { get; set; } = false;

        [StringLength(20)]
        public string Phone { get; set; } = string.Empty;

        private string _role = UserRoleConst.Candidate;

        [StringLength(50)]
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

        [Column(TypeName = "date")]
        public DateTime? CreatedTime { get; set; } = DateTime.Now;

        [Column(TypeName = "date")]
        public DateTime? UpdatedTime { get; set; }

        private string _avatarUrl;

        [StringLength(100)]
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

        [StringLength(20)]
        public string Otp { get; set; } = string.Empty;

        public DateTime? OtpExpiredTime { get; set; } = DateTime.Now;

        public bool? IsEmailVerified { get; set; } = false;

        public User()
        {
            this.CreatedTime = DateTime.Now;
            this.IsDeleted = false;
            this.AvatarUrl = DefaultAvatarUrl;
            this.IsEmailVerified = false;
        }

        public User(string UserName, string password, string email, string status, string role, string phone, string avatarUrl)
        {
            this.UserName = UserName;
            this.Password = password;
            this.Email = email;
            this.Status = status;
            this.Role = role;
            this.Phone = phone;
            this.CreatedTime = DateTime.Now;
            this.IsDeleted = false;
            this.AvatarUrl = avatarUrl;
            this.IsEmailVerified = false;
        }

        public SendEmailBySMTPOutput SendOtpVerifyEmail(string otp, string title = "Xác thực tài khoản")
        {
            var content = File.ReadAllText("Resources/Templates/SendOtpToEmail.html", encoding: Encoding.UTF8);
            content = content.Replace("@EmailTitle", title);
            content = content.Replace("@EmailContent", "Mã OTP xác thực tài khoản");
            content = content.Replace("@OTP", otp);

            var input = new SendEmailBySMTPInput
            {
                Title = title,
                Content = content,
                Recipient = new List<string> { this.Email }
            };
            var output = MailHelper.SendEmailBySMTP(input);
            return output;
        }

        public bool VerifyOtp(string otp)
        {
            if (otp == this.Otp && DateTime.Now < this.OtpExpiredTime)
            {
                this.IsEmailVerified = true;
                return true;
            }
            return false;
        }
    }
}
