using SmartOffice.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SmartOffice.Views
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