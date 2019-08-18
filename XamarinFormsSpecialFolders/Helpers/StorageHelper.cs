using System.Collections.Generic;
using XamarinFormsSpecialFolders.Interfaces;

namespace XamarinFormsSpecialFolders.Helpers
{
    public static class StorageHelper
    {
        public static List<string> GetSpecialFolders()
        {
            return Xamarin.Forms.DependencyService.Get<IFileHelper>().GetSpecialFolders();
        }
    }
}
