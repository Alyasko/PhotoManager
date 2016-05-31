using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhotoManager.Models
{
    public class PhotosManager
    {
        private IList<string> _filesList;

        public PhotosManager()
        {
            InitializeFields();
        }

        private void InitializeFields()
        {
            _filesList = new List<string>();
            FolderPath = "";
        }

        public void LoadFiles()
        {

        }

        public string FolderPath { get; set; }
    }
}
