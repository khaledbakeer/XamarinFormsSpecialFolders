using System.Collections.Generic;
using XamarinFormsSpecialFolders.Models;

namespace XamarinFormsSpecialFolders.ViewModels
{
    public class FolderViewModel
    {
        #region Fields
        private List<FolderModel> availableFolders = new List<FolderModel>();
        #endregion

        #region Properties
        public List<FolderModel> AvailableFolders { get => availableFolders; set => availableFolders = value; }
        #endregion

        #region Constructor
        public FolderViewModel()
        {
            List<string> stringFolders = Helpers.StorageHelper.GetSpecialFolders();

            foreach (var folder in stringFolders)
            {
                availableFolders.Add(new FolderModel(folder));
            }
        }
        #endregion
    }
}
