using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Access_Individual_PropertyApp.ViewModels;


namespace Access_Individual_PropertyApp
{
    public partial class MainPage : ContentPage
    {
        MyViewModel myViewModel;

        public MainPage()
        {
            InitializeComponent();

            myViewModel = new MyViewModel();
            BindingContext = myViewModel;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            UpdateUIItemStatusMessage("123");
        }

        private void UpdateUIItemStatusMessage(string uniqueMessage)
        {
            myViewModel.MyItems[1].ItemStatus = $"Completed !!!";
        }

        public void OnClickShowItemPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ItemViewPage());
        }


    }
}
