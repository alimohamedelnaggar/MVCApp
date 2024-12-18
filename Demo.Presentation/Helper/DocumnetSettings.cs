using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace Demo.Presentation.Helper
{
    public class DocumnetSettings
    {
        public static string UploadFile(IFormFile file, string folderName)
        {
            //1. get location folder path
            string folderPath = "C:\\Users\\SoftLaptop\\source\\repos\\Demo MVC ALi\\Demo.Presentation\\wwwroot\\Files\\" + folderName;
             //folderPath = Directory.GetCurrentDirectory() + @"\wwwroot\Files" + folderName;
             //folderPath = Path.Combine(Directory.GetCurrentDirectory(), @"\wwwroot\Files", folderName);
            //2. get file name

            string fileName = $"{Guid.NewGuid()}{file.FileName}";

            //3. get file path

            string filePath = Path.Combine(folderPath, fileName);

            //4. save 
            using var fileStream = new FileStream(filePath, FileMode.Create);
            //5. copy

            file.CopyTo(fileStream);
            return fileName;

        }
        public static void DeleteFile(string fileName, string folderName)
        {
            string filePath = "C:\\Users\\SoftLaptop\\source\\repos\\Demo MVC ALi\\Demo.Presentation\\wwwroot\\Files\\" + folderName;
            if (File.Exists(filePath))
                File.Delete(filePath);


        }
    }
}
