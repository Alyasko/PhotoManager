using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhotoManager.Models
{
    public interface IPhotoStorage
    {
        void CopyPhoto(string sourcePath, string destPath);

    }
}
