﻿using CloudinaryDotNet;
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
        
        public static ImageUploadResult UploadImage(string filePath, string fileName = null, string fileFormat = "jpg")
        {
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(filePath),
                AssetFolder = "job-management",
                Folder = "job-management",
                UseFilename = true,
                FilenameOverride = fileName,
                Format = fileFormat,
                UniqueFilename = false,
                Overwrite = true
            };
            var uploadResult = cloudinary.Upload(uploadParams);
            return uploadResult;
        }
    }
}