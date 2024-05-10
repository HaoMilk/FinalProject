﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Database.Entities
{
    public class CongTy
    {
        public int ID { get; set; }
        public string Email { get; set; } = string.Empty;
        public string TenCongTy { get; set; } = string.Empty;
        public string DiaChi { get; set; } = string.Empty;
        public string CEO { get; set; } = string.Empty;
        public string MST { get; set; } = string.Empty;
        public string WordFileUrl { get; set; } = string.Empty;
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime? UpdatedTime { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int UserId { get; set; }

        public bool CheckNull()
        {
            var properties = new object[] {ID, Email, TenCongTy, DiaChi, CEO, MST, WordFileUrl };
            foreach (var property in properties)
            {
                if (IsNull(property))
                {
                    return true; // Trả về true nếu có bất kỳ thuộc tính nào null hoặc mặc định
                }
            }

            return false; // Trả về false nếu tất cả các thuộc tính đều không null hoặc mặc định
        }

        public bool IsNull(object obj)
        {
            // Kiểm tra cho chuỗi
            if (obj is string && string.IsNullOrEmpty((string)obj))
            {
                return true;
            }
            if (obj is decimal && (decimal)obj == default(decimal))
            {
                return true;
            }
            if (obj is int && (int)obj == default(int))
            {
                return true;
            }

            return false;
        }
    }

}
