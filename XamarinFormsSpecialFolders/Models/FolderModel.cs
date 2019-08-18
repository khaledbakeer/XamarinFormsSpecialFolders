namespace XamarinFormsSpecialFolders.Models
{
    public class FolderModel
    {
        #region Properties
        public string FolderName { get; set; }
        #endregion

        #region Constructor
        public FolderModel(string folderName)
        {
            FolderName = folderName;
        }
        #endregion
    }
}
