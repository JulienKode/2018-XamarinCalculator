using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace Calculatrice
{
    public partial class CalculatricePage : ContentPage
    {
        public CalculatricePage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;

            string nb = Calculator.ManageCalcul(pressed);
            result.Text = nb;
        }

    }
}
