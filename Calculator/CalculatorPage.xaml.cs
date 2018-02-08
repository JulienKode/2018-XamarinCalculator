using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Calculator
{
    public partial class CalculatorPage : ContentPage
    {
        CalculEngine calculator = new CalculEngine();

        public CalculatorPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;

            string nb = calculator.ManageCalcul(pressed);
            result.Text = nb;
        }
    }
}
