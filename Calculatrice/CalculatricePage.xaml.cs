using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace Calculatrice
{
    public partial class CalculatricePage : ContentPage
    {
        int state = 0;
        int lastNb = 0;

        public CalculatricePage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;

            Debug.WriteLine(pressed);

            if (Int32.TryParse(pressed, out lastNb))
                Debug.WriteLine(lastNb);
            else
                Debug.WriteLine("String could not be parsed.");

            switch (pressed) 
            {
                case "+":
                    state += lastNb;
                    result.Text = state.ToString();

                    break;
                case "-":
                    state -= lastNb;
                    break;
                case "/":
                    state = state / lastNb;
                    break;
                case "x":
                    state = state * lastNb;
                    result.Text = state.ToString();
                    break;
            }

            //throw new NotImplementedException();
        }

    }
}
