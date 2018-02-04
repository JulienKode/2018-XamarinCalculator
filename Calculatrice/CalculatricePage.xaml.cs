using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace Calculatrice
{
    public partial class CalculatricePage : ContentPage
    {
        int state = 0;
        int first = 0;
        string op = null;
        int second = 0;

        public CalculatricePage()
        {
            InitializeComponent();
        }

        void ManageCalcul(string pressed)
        {
            int nb;
            if (Int32.TryParse(pressed, out nb))
            {
                Debug.WriteLine(nb);
                if (op == null)
                    first = nb;
                else
                    second = nb;
            } else if (string.ReferenceEquals(pressed, "="))
            {
                MakeCalcul();
            } else {
                op = pressed;
            }
        }

        void MakeCalcul() {
            switch (op)
            {
                case "+":
                    state = first + second;
                    break;
                case "-":
                    state = first - second;
                    break;
                case "/":
                    state = first / second;
                    break;
                case "x":
                    state = first * second;
                    break;
            }
            Debug.WriteLine(state.ToString());
            result.Text = state.ToString();
            op = null;

        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;

            ManageCalcul(pressed);

        }

    }
}
