using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using PhotoManager.Models;

namespace PhotoManager
{
    public partial class Form1 : Form
    {
        private PhotosManager _photosManager;
        private BindingSource _groupsBindingSource;
        private bool _waitHandle;




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
            InitializeBindings();
        }

        private void InitializeBindings()
        {
            _groupsBindingSource.DataSource = _photosManager.GroupsList;
            _groupsBindingSource.ListChanged += GroupsBindingSourceOnListChanged;
            dgvGroups.DataSource = _groupsBindingSource;
        }

        private void InitializeFields()
        {
            IPhotoStorage storage = new FileSystemStorage();
            _photosManager = new PhotosManager(storage);
            _photosManager.ImageChangeRequested += PhotosManagerOnImageChangeRequested;

            _waitHandle = false;

            _groupsBindingSource = new BindingSource();
        }

        private void GroupsBindingSourceOnListChanged(object sender, ListChangedEventArgs listChangedEventArgs)
        {
            //if (listChangedEventArgs.ListChangedType == ListChangedType.ItemDeleted)
            //{
            //    if (listChangedEventArgs.NewIndex < _photosManager.GroupsList.Count)
            //    {
            //        _photosManager.DeleteGroupFromPhotos(listChangedEventArgs.NewIndex);
            //    }
            //}

            UpdateGroupSelectorList();
        }


        private void PhotosManagerOnImageChangeRequested(PhotoEntry photoEntry)
        {
            if (photoEntry != null)
            {
                string photoPath = photoEntry.FullPath;
                LoadImage(photoPath);
                ShowGroupSelector();
            }
            else
            {
                if (_photosManager.PhotosList.Count == 0)
                {
                    Utils.ShowInfoBox("There are no photos to process.\nPlease load photos first.");
                }
                else
                {
                    DialogResult result = Utils.ShowQuestionBox("There are no photos left.\nStart photos saving?");

                    if (result == DialogResult.Yes)
                    {
                        CopyGroupedPhotos();
                    }
                    else if (result == DialogResult.No)
                    {
                        Utils.ShowInfoBox("Groups are still assigned to photos, you can modify or discard them if needed.");
                    }
                }
            }
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            SelectFolderAndProcess();

            /*if (Directory.Exists(tbSource.Text))
            {
                sourcePath = tbSource.Text;
                copyPath = sourcePath + @"\Selected";

                //tbCopy.Text = copyPath;

                lvPhotosList.Items.Clear();
                l_Photos.Clear();

                foreach (string mask in l_Masks)
                    l_Photos.AddRange(Directory.GetFiles(sourcePath, mask, SearchOption.TopDirectoryOnly));

                for (int i = 0; i < l_Photos.Count; i++)
                {
                    lvPhotosList.Items.Add(l_Photos[i]);
                }

                lvPhotosList.Columns[0].Text = String.Format("File (Count: {0})", lvPhotosList.Items.Count);
            }*/
        }

        private void lvPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPhotosList.SelectedItems.Count != 0)
            {
                int selectedIndex = lvPhotosList.SelectedIndices[0];
                string photoPath = _photosManager.PhotosList[selectedIndex].FullPath;
                LoadImage(photoPath);

                if (_photosManager.GroupingFinished)
                {
                    pGroups.Visible = true;
                    UpdateGroupListSelectionByPhoto(selectedIndex);
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            rotate90LeftToolStripMenuItem.Enabled = false;
            rotate90RightToolStripMenuItem.Enabled = false;
        }

        private void pctbPhoto_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            rotate90LeftToolStripMenuItem.Enabled = true;
            rotate90RightToolStripMenuItem.Enabled = true;

            this.Text = "Photo Manager | " + pctbPhoto.ImageLocation;
        }

        private void cbCopy_CheckedChanged(object sender, EventArgs e)
        {
            if (pctbPhoto.Image != null)
            {
                lvPhotosList.FindItemWithText(pctbPhoto.ImageLocation).Checked = true;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvPhotosList.Items.Count; i++)
            {
                if (lvPhotosList.Items[i].Checked)
                {
                    Directory.CreateDirectory(copyPath);
                    File.Copy(lvPhotosList.Items[i].Text, copyPath + lvPhotosList.Items[i].Text.Substring(lvPhotosList.Items[i].Text.LastIndexOf('\\')), false);
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
                    ProcessFiles(folderPath);
                }
                else
                {
                    Utils.ShowInfoBox("Please, drop folder.");
                }
            }
        }

        private void selectFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectFolderAndProcess();
        }

        private void chbShowSideMenu_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = !chbShowSideMenu.Checked;
        }

        private void dgvGroups_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    dgvGroups.Rows[e.RowIndex].Cells[1].Value = $"For{dgvGroups.Rows[e.RowIndex].Cells[0].Value}";
                    dgvGroups.Rows[e.RowIndex].Cells[2].Value = dgvGroups.Rows[e.RowIndex].Cells[0].Value.ToString()[0];
                }
            }
            catch (Exception ex)
            {
                Utils.ShowInfoBox(ex.Message);
            }
        }

        private void startAutogroupingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartAutoGrouping();
        }

        private void lbGroupsSelector_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UpdateGroupsOfShownPhoto();
                e.Handled = true;
            }
            else
            {
                if (e.Control && e.KeyCode == Keys.A)
                {
                    CheckGroupsList();
                }
                else
                {
                    CheckGroupByShortcut(e.KeyCode);
                }
            }
        }

        private void btnNextPhoto_Click(object sender, EventArgs e)
        {
            UpdateGroupsOfShownPhoto();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                UpdateStatistics();
            }
        }


        private void copyGroupedPhotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyGroupedPhotos();
        }

        private void stopAutogroupingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopAutoGrouping();
        }

        ////////////////////////////////////// Local methods /////////////////////////////////


        private void CheckGroupsList()
        {
            for (int i = 0; i < lbGroupsSelector.Items.Count; i++)
            {
                lbGroupsSelector.SetItemCheckState(i, CheckState.Checked);
            }
        }


        private void StopAutoGrouping()
        {
            _photosManager.StopAutoGrouping();
        }

        private void CopyGroupedPhotos()
        {
            _photosManager.CopyFiles();
            Utils.ShowInfoBox("Files are saved!");
        }

        private void UpdateStatistics()
        {
            if (_photosManager.GroupingFinished)
            {
                dgvStatistics.Rows.Clear();

                int noGroupCount = 0;

                foreach (var groupEntry in _photosManager.GroupsList)
                {
                    int groupCount = 0;
                    noGroupCount = 0;
                    foreach (PhotoEntry photoEntry in _photosManager.PhotosList)
                    {
                        if (photoEntry.Groups.Contains(groupEntry))
                        {
                            groupCount++;
                        }

                        if (photoEntry.Groups.Count == 0)
                        {
                            noGroupCount++;
                        }
                    }

                    dgvStatistics.Rows.Add(groupEntry.Name, groupEntry.RelativePath, groupCount);
                }

                dgvStatistics.Rows.Add("No group", "", noGroupCount);
            }
            else
            {
                Utils.ShowInfoBox("There is no statistic information yet.");
            }
        }

        private void CheckGroupByShortcut(Keys key)
        {
            GroupEntry groupToCheck = _photosManager.GroupsList.FirstOrDefault(x => x.Shortcut == key);

            if (groupToCheck != null)
            {
                int index = _photosManager.GroupsList.IndexOf(groupToCheck);

                lbGroupsSelector.SetItemCheckState(index, lbGroupsSelector.GetItemCheckState(index) == CheckState.Checked ? CheckState.Unchecked : CheckState.Checked);
            }
        }

        private void UpdateGroupListSelectionByPhoto(int selectedIndex)
        {
            int[] indicesToCheck = _photosManager.GetPhotoGroupsIndices(selectedIndex);

            CheckGroupsList(indicesToCheck);
        }

        private void UpdateGroupsOfShownPhoto()
        {
            CheckedListBox.CheckedIndexCollection checkedIndexCollection = lbGroupsSelector.CheckedIndices;

            List<int> indices = new List<int>();

            foreach (var selectedIndex in checkedIndexCollection)
            {
                indices.Add((int)selectedIndex);
            }

            _photosManager.UpdateGroups(indices.ToArray());
        }

        private void UncheckGroupsList()
        {
            for (int i = 0; i < lbGroupsSelector.Items.Count; i++)
            {
                lbGroupsSelector.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void CheckGroupsList(int[] indces)
        {
            for (int i = 0; i < lbGroupsSelector.Items.Count; i++)
            {
                if (indces.Contains(i))
                {
                    lbGroupsSelector.SetItemCheckState(i, CheckState.Checked);
                }
                else
                {
                    lbGroupsSelector.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        private void ShowGroupSelector()
        {
            if (lbGroupsSelector.Items.Count != _photosManager.GroupsList.Count)
            {
                UpdateGroupSelectorList();
            }

            UncheckGroupsList();

            pGroups.Visible = true;
        }

        private void UpdateGroupSelectorList()
        {
            lbGroupsSelector.Items.Clear();

            foreach (GroupEntry entry in _photosManager.GroupsList)
            {
                if (entry.Name != null)
                {
                    lbGroupsSelector.Items.Add($"({entry.Shortcut}) {entry.Name}");
                }
            }
        }

        private void LoadImage(string path)
        {
            pctbPhoto.ImageLocation = path;
            GC.Collect();
        }

        private void StartAutoGrouping()
        {
            if (_photosManager.GroupsList.Count > 0)
            {
                _photosManager.StartAutoGrouping();
                btnNextPhoto.Enabled = true;
            }
            else
            {
                Utils.ShowInfoBox("Please add groups before beginning.");
                tabControl1.SelectTab(1);
            }
        }

        private void SelectFolderAndProcess()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string folderName = fbd.SelectedPath;

                ProcessFiles(folderName);
            }
        }

        private void ProcessFiles(string folder)
        {
            _photosManager.FolderPath = folder;
            _photosManager.LoadFiles();

            tbSource.Text = folder;

            UpdatePhotosListView();

            lblStatus.Text = $"Photos count: {_photosManager.PhotosList.Count}";
        }

        private void UpdatePhotosListView()
        {
            lvPhotosList.Items.Clear();
            foreach (PhotoEntry photoEntry in _photosManager.PhotosList)
            {
                string fileName = Path.GetFileName(photoEntry.FullPath);
                lvPhotosList.Items.Add(fileName);
            }

            if (_photosManager.PhotosList.Count > 0)
            {
                LoadImage(_photosManager.PhotosList[0].FullPath);
            }
        }

        private void rotate90RightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pctbPhoto.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pctbPhoto.Invalidate();
        }

        private void rotate90LeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pctbPhoto.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pctbPhoto.Invalidate();
        }

        private void discardGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_photosManager.GroupingFinished)
            {
                if (Utils.ShowQuestionBox("Do you really want to discard all groups from all photos?") ==
                    DialogResult.Yes)
                {
                    _photosManager.DiscardGroups();
                    pGroups.Visible = false;
                    dgvStatistics.Rows.Clear();
                }
            }
            else
            {
                Utils.ShowInfoBox("No groups are assigned to photos.");
            }
        }
    }
}
