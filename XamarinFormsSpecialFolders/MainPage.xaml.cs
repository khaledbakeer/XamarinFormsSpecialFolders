using System.ComponentModel;
using Xamarin.Forms;
using XamarinFormsSpecialFolders.ViewModels;

namespace XamarinFormsSpecialFolders
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new FolderViewModel();
        }
    }
}
