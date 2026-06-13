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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void UpdateData()
        {
            if (double.TryParse(CreditSumText.Text, out double credit))
            {
                if (double.TryParse(TimeText.Text, out double time))
                {
                    double rate = rateSlider.Value / 100;
                    double monthlyRate = (rate) / (12);
                    double rateLabelValue = rateSlider.Value;

                    double monthly = credit * (monthlyRate * Math.Pow(1 + monthlyRate, time)) / (Math.Pow(1 + monthlyRate, time) - 1);
                    if (PickerItem.SelectedIndex == 0)
                    {
                        MonthlyPayment.IsVisible = true;
                        MonthlyPayment.Text = "Месячная плата: " + Math.Round(monthly,2).ToString();
                    }
                    else
                    {
                        MonthlyPayment.IsVisible = false;

                        
                    }
                    
                    WholeSumLabel.Text = $"Общая сумма: {Math.Round(monthly * time,2)}";
                    OverpayLabel.Text = $"Переплата: {Math.Round((monthly * time) - credit,2)}";
                    rateLabel.Text = $"{Math.Round(rateLabelValue,2)}%";
                }
            }
            
            
                
            
            
            

            
        }

        private void CreditSumText_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateData();
        }

        private void rateSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            UpdateData();
        }

        private void PickerItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void Label_DescendantAdded(object sender, ElementEventArgs e)
        {

        }
    }
}