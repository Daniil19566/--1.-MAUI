using Microsoft.Maui.Controls;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnIncomeButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IncomePage());
        }

        private async void OnExpenseButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExpensePage());
        }

        private async void OnReportButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReportPage());
        }
    }

}
