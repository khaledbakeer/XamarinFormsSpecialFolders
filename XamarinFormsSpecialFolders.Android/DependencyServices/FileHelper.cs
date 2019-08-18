using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamarinFormsSpecialFolders.Droid.DependencyServices;
using XamarinFormsSpecialFolders.Interfaces;

[assembly: Dependency(typeof(FileHelper))]
namespace XamarinFormsSpecialFolders.Droid.DependencyServices
{
    public class FileHelper : IFileHelper
    {
        public List<string> GetSpecialFolders()
        {
            List<string> folders = new List<string>();

            foreach (var folder in Enum.GetValues(typeof(Environment.SpecialFolder)))
            {
                if (!string.IsNullOrEmpty(Environment.GetFolderPath((Environment.SpecialFolder)folder)))
                {
                    folders.Add($"{folder}={Environment.GetFolderPath((Environment.SpecialFolder)folder)}");
                }
            }

            return folders;
        }
    }
}
