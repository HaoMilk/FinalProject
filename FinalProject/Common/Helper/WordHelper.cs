﻿using FinalProject.Database.Entities;
using FinalProject.UC;
using NPOI.XWPF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FinalProject.Common.Helper
{
    public static class WordHelper
    {
        public static void ExportWord(string template, string generateFile, Dictionary<string, string> data)
        {
            using (var rs = File.OpenRead(template))
            {
                using (var doc = new XWPFDocument(rs))
                {
                    foreach (var item in data)
                    {
                        doc.FindAndReplaceText(item.Key, item.Value);
                    }

                    using (var ws = File.Create(generateFile))
                    {
                        doc.Write(ws);
                    }
                }
            }
        }

        public static string ExportCV(CV cv, UngVien ungVien, string template = null, string generateFile = null)
        {
            if (cv == null || ungVien == null)
            {
                return null;
            }
            if (string.IsNullOrEmpty(template))
            {
                template = "Resources/Template-Stylish_teaching_resume.docx";
            }
            if (string.IsNullOrEmpty(generateFile))
            {
                // Lấy đường dẫn đang chạy của ứng dụng
                var path = AppDomain.CurrentDomain.BaseDirectory;
                // Tạo thư mục Output/CV nếu chưa tồn tại
                if (!Directory.Exists($"{path}Output/CV"))
                {
                    Directory.CreateDirectory($"{path}/Output/CV");
                }
                generateFile = $"{path}/Output/CV/CV{cv.Id}_{ungVien.HoTen}_{cv.Ten}_{DateTime.Now:yyyyMMddhhmmss}.docx";
            }
            var data = new Dictionary<string, string>
            {
                { "{HoTen}", ungVien.HoTen },
                { "{NgaySinh}", ungVien.NgaySinh.ToString("yyyy-MM-dd") },
                { "{GioiTinh}", ungVien.GioiTinh },
                { "{DiaChi}", ungVien.DiaChi },
                { "{SDT}", ungVien.SDT },
                { "{Email}", ungVien.Email },
                { "{ChuyenMon}", ungVien.ChuyenMon },
                //{ "{Avatar}", ungVien.Avatar },
                { "{TenCV}", cv.Ten },
                { "{Link}", cv.Link },
                { "{MoTa}", cv.MoTa },
                { "{ViTriUngTuyen}", cv.ViTriUngTuyen },
                { "{KyNang}", cv.KyNang },
                { "{NgoaiNgu}", cv.NgoaiNgu },
                { "{TinHoc}", cv.TinHoc },
                { "{HocVan}", cv.HocVan },
                { "{HoatDong}", cv.HoatDong },
                { "{ChungChi}", cv.ChungChi },
                { "{MucTieu}", cv.MucTieu },
                { "{KinhNghiem}", cv.KinhNghiem },
            };

            try
            {
                using (var rs = File.OpenRead(template))
                {
                    using (var doc = new XWPFDocument(rs))
                    {
                        foreach (var item in data)
                        {
                            doc.FindAndReplaceText(item.Key, item.Value);
                        }

                        using (var ws = File.Create(generateFile))
                        {
                            doc.Write(ws);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UCMessageBox.Show(ex.Message, "Lỗi xuất file", UCMessageBox.MessageBoxButtons.OK);
                return null;
            }

            return generateFile;
        }
    }
}
