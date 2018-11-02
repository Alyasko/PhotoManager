using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhotoManager.Models
{
    public class PhotoEntry
    {
        public PhotoEntry()
        {
            InitializeFields();
        }

        private void InitializeFields()
        {
            Groups = new List<GroupEntry>();
        }

        public string FullPath { get; set; }

        public List<GroupEntry> Groups { get; set; }
    }
}
