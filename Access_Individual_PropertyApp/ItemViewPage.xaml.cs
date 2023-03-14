using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Access_Individual_PropertyApp.ViewModels;
using System.Diagnostics;

namespace Access_Individual_PropertyApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemViewPage : ContentPage
    {
        MyViewModel myViewModel;

        public ItemViewPage()
        {
            InitializeComponent();

            myViewModel = new MyViewModel();
            BindingContext = myViewModel;
        }

        private void OnButton_Clicked2(object sender, EventArgs e)
        {
            Debug.WriteLine("BEFORE:" + myViewModel.MyItems[1].ItemStatus);

            UpdateUIItemStatusMessage("123");

            Debug.WriteLine("AFTER:" + myViewModel.MyItems[1].ItemStatus);
        }

        private void UpdateUIItemStatusMessage(string uniqueMessage)
        {
            myViewModel.MyItems[1].ItemStatus = $"Completed 123 !!!";
        }
    }
}