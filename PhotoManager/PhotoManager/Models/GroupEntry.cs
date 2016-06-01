using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhotoManager.Models
{
    public class GroupEntry
    {
        public GroupEntry()
        {
            
        }

        public GroupEntry(string name, string path)
        {
            Name = name;
            RelativePath = path;
        }

        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Path")]
        public string RelativePath { get; set; }
        public Keys Shortcut { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            GroupEntry entry = obj as GroupEntry;
            return entry != null && RelativePath == entry.RelativePath;
        }
    }
}
