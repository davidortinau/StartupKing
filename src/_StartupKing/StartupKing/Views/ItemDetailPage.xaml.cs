using StartupKing.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace StartupKing.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}