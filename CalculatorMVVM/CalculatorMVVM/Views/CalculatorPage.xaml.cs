using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CalculatorMVVM.ViewModels;

namespace CalculatorMVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculatorPage : ContentPage
    {
        public CalculatorPage()
        {
            InitializeComponent();
            BindingContext = new CalculatorViewModel();
            Divide.Clicked += AlertButton_Clicked; 
        }

        private void AlertButton_Clicked(object sender, EventArgs e)
        {
            if(Num2.Text == "0")
            {
                DisplayAlert("Уведомление", "Делить на ноль нельзя!", "ОK");
            }
        }
    }
}