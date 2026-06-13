using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd4_Romanov
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            DatePickerNow.Date = DateTime.Today;

            DollarText.Text = "USD: 80 руб.";
            EuroText.Text = "EUR: 86 руб.";
        }
    }
}