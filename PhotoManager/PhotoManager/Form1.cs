using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using PhotoManager.Models;

namespace PhotoManager
{
    public partial class Form1 : Form
    {
        private PhotosManager _photosManager;


        string sourcePath = "";
        string copyPath = "";

        List<string> l_Photos = new List<string>();
        string[] l_Masks = { "*.JPG" };

        int curSelPhoto = 0;

        Dictionary<string, bool> dct_CheckedPhotos = new Dictionary<string, bool>();

        public Form1()
        {
            InitializeComponent();
            InitializeFields();
        }

        private void InitializeFields()
        {
            _photosManager = new PhotosManager();
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tbSource.Text))
            {
                sourcePath = tbSource.Text;
                copyPath = sourcePath + @"\Selected";

                //tbCopy.Text = copyPath;

                lvPhotos.Items.Clear();
                l_Photos.Clear();

                foreach(string mask in l_Masks)
                    l_Photos.AddRange(Directory.GetFiles(sourcePath, mask, SearchOption.TopDirectoryOnly));

                for (int i = 0; i < l_Photos.Count; i++)
                {
                    lvPhotos.Items.Add(l_Photos[i]);
                }

                lvPhotos.Columns[0].Text = String.Format("File (Count: {0})", lvPhotos.Items.Count);
            }
        }

        private void lvPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPhotos.SelectedItems.Count != 0)
            {
                pctbPhoto.ImageLocation = lvPhotos.SelectedItems[0].Text;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnRotateLeft_Click(object sender, EventArgs e)
        {
            pctbPhoto.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pctbPhoto.Invalidate();
        }

        private void btnRotateRight_Click(object sender, EventArgs e)
        {
            pctbPhoto.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pctbPhoto.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnRotateLeft.Enabled = false;
            btnRotateRight.Enabled = false;
        }

        private void pctbPhoto_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            btnRotateLeft.Enabled = true;
            btnRotateRight.Enabled = true;

            this.Text = "Photo Manager | " + pctbPhoto.ImageLocation;
        }

        private void cbCopy_CheckedChanged(object sender, EventArgs e)
        {
            if (pctbPhoto.Image != null)
            {
                lvPhotos.FindItemWithText(pctbPhoto.ImageLocation).Checked = true;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvPhotos.Items.Count; i++)
            {
                if (lvPhotos.Items[i].Checked)
                {
                    Directory.CreateDirectory(copyPath);
                    File.Copy(lvPhotos.Items[i].Text, copyPath + lvPhotos.Items[i].Text.Substring(lvPhotos.Items[i].Text.LastIndexOf('\\')), false);
                }
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (droppedFiles.Length > 0)
            {
                string folderPath = droppedFiles[0];

                if (Directory.Exists(folderPath))
                {
                    _photosManager.FolderPath = folderPath;
                    _photosManager.LoadFiles();
                }
                else
                {
                    Utils.ShowInfoBox("Please, drop folder.");
                }
            }
        }
    }
}
