using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace PhotoManager.Models
{
    public delegate void ImageChangeRequestedDelegate(PhotoEntry path);

    public class PhotosManager
    {
        public event ImageChangeRequestedDelegate ImageChangeRequested;

        //private Timer _timer;
        private int _imageIndex;

        public PhotosManager(IPhotoStorage storage)
        {
            InitializeFields(storage);
        }

        private void InitializeFields(IPhotoStorage storage)
        {
            GroupsList = new List<GroupEntry>();
            PhotoStorage = storage;

            //_timer = null;

            PhotosList = new List<PhotoEntry>();
            SearchPatterns = new List<string>();
            SearchPatterns.Add("*.jpg");
            SearchPatterns.Add("*.jpeg");

            FolderPath = "";

            ImageChangeRequested = null;

            GroupingFinished = false;

            _imageIndex = 0;
        }

        private void ChangeImage()
        {
            if (ImageChangeRequested != null)
            {
                if (_imageIndex >= 0 && _imageIndex < PhotosList.Count)
                {
                    ImageChangeRequested(PhotosList[_imageIndex]);
                }
                else
                {
                    ImageChangeRequested(null);
                    GroupingFinished = true;
                    _imageIndex = -1;
                }
            }
        }

        public void LoadFiles()
        {
            List<string> photoPaths = new List<string>();
            foreach (string pattern in SearchPatterns)
            {
                photoPaths.AddRange(Directory.GetFiles(FolderPath, pattern, SearchOption.TopDirectoryOnly));
            }

            PhotosList.Clear();
            foreach (string photoPath in photoPaths)
            {
                PhotoEntry photoEntry = new PhotoEntry();
                photoEntry.FullPath = photoPath;

                PhotosList.Add(photoEntry);
            }
        }

        public void CopyFiles()
        {
            Dictionary<GroupEntry, string> outputPaths = new Dictionary<GroupEntry, string>();

            foreach (GroupEntry groupEntry in GroupsList)
            {
                outputPaths.Add(groupEntry, Path.Combine(FolderPath, groupEntry.RelativePath));
            }

            foreach (PhotoEntry photoEntry in PhotosList)
            {
                foreach (GroupEntry photoGroup in photoEntry.Groups)
                {
                    if (outputPaths.ContainsKey(photoGroup))
                    {
                        PhotoStorage.CopyPhoto(photoEntry.FullPath, Path.Combine(outputPaths[photoGroup], Path.GetFileName(photoEntry.FullPath)));
                    }
                }
            }
        }

        public void StartAutoGrouping()
        {
            _imageIndex = 0;

            foreach (PhotoEntry photoEntry in PhotosList)
            {
                photoEntry.Groups.Clear();
            }

            ChangeImage();
            //_timer = new Timer(TimerCallback);
            //_timer.Change(1000, 1000);
        }

        public void UpdateGroups(GroupEntry[] groups)
        {
            if (_imageIndex >= 0 && _imageIndex < PhotosList.Count)
            {
                PhotosList[_imageIndex].Groups.AddRange(groups);
                _imageIndex++;
            }
            ChangeImage();
        }

        public void UpdateGroups(int[] indices)
        {
            List<GroupEntry> entries = new List<GroupEntry>();

            foreach (int i in indices)
            {
                entries.Add(GroupsList[i]);
            }

            UpdateGroups(entries.ToArray());
        }

        public int[] GetPhotoGroupsIndices(int photoIndex)
        {
            var groups = PhotosList[photoIndex].Groups;
            List<int> indices = new List<int>();

            foreach (GroupEntry groupEntry in groups)
            {
                int index = GroupsList.IndexOf(groupEntry);
                indices.Add(index);
            }

            return indices.ToArray();
        }

        public void DiscardGroups()
        {
            foreach (PhotoEntry photoEntry in PhotosList)
            {
                photoEntry.Groups.Clear();
            }

            GroupingFinished = false;
        }

        public void StopAutoGrouping()
        {
            if (ImageChangeRequested != null)
            {
                ImageChangeRequested(null);
                GroupingFinished = true;
                _imageIndex = -1;
            }
        }

        public string FolderPath { get; set; }
        public List<string> SearchPatterns { get; set; }

        public List<PhotoEntry> PhotosList { get; private set; }
        public List<GroupEntry> GroupsList { get; set; }
        public bool GroupingFinished { get; set; }

        public IPhotoStorage PhotoStorage { get; set; }

        public void DeleteGroupFromPhotos(int i)
        {
            GroupEntry group = GroupsList[i];

            foreach (PhotoEntry photoEntry in PhotosList)
            {
                photoEntry.Groups.Remove(group);
            }
        }
    }
}
