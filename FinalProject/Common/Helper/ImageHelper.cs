using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Common.Helper
{
    public static class ImageHelper
    {
        private static Cloudinary cloudinary = new Cloudinary(Properties.Settings.Default.cloudinary_url);
        
        public static ImageUploadResult UploadImage(string filePath, string fileName = null, string fileFormat = "jpg", System.Drawing.Size? size = null)
        {
            // Khởi tạo đối tượng upload image chứa các thông tin cần thiết
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(filePath), // Thông tin đường dẫn đến file
                AssetFolder = "job-management",
                Folder = "job-management",
                UseFilename = true,
                FilenameOverride = fileName,
                Format = fileFormat, // Định dạng hình ảnh
                UniqueFilename = false,  
                Overwrite = true, // xác định trùng tên có muốn ghi đè.
                UseFilenameAsDisplayName = true,
            };
            // nếu muốn thu gọn hình
            if (size != null) 
            {
                // cắt hình với chiều dài , rộng 
                uploadParams.Transformation = new Transformation()
                    .Width(size.Value.Width)
                    .Height(size.Value.Height)
                    .Crop("fill");
            }
            var uploadResult = cloudinary.Upload(uploadParams); // Đem thông tin upload lên cloud
            return uploadResult; // Trả về kết quả.
        }

    }
}
