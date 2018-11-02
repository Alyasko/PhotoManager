using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace PhotoManager.Models
{
    public class FileSystemStorage : IPhotoStorage
    {

        public void CopyPhoto(string sourcePath, string destPath)
        {
            try
            {
                Debug.WriteLine($"{sourcePath} to {destPath}");
                string directory = Path.GetDirectoryName(destPath);
                if (Directory.Exists(directory) == false)
                {
                    Directory.CreateDirectory(directory);
                }
                File.Copy(sourcePath, destPath);
            }
            catch (Exception ex)
            {
                Utils.ShowInfoBox(ex.Message);
            }
        }
    }
}
