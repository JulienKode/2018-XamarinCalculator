using System;
using System.Diagnostics;

namespace Calculatrice
{
    public class Calculator
    {
        int state = 0;
        string first = "";
        string op = null;
        string second = "";

        public Calculator()
        {
        }

        private string MakeCalcul(string op)
        {
            Debug.WriteLine(op);

            int fst;
            int snd;
            Int32.TryParse(first, out fst);
            Int32.TryParse(second, out snd);
            switch (op)
            {
                case "+":
                    state = fst + snd;
                    break;
                case "-":
                    state = fst - snd;
                    break;
                case "/":
                    state = fst / snd;
                    break;
                case "x":
                    state = fst * snd;
                    break;
            }

            Debug.WriteLine(op);
            Debug.WriteLine(state.ToString());
            return state.ToString();
            op = null;

        }


        public string ManageCalcul(string pressed)
        {
            int nb;
            if (Int32.TryParse(pressed, out nb))
            {
                if (op == null)
                {
                    first += pressed;
                    return first;
                }
                else
                {
                    second += pressed;
                    return second;
                }
            }
            else if (pressed.Equals("="))
                return MakeCalcul(op);
            else if (int.TryParse(first, out int n) == false)
            {
                Debug.WriteLine("Operator");
                Debug.WriteLine(pressed);
                op = pressed;
            }
            else if (int.TryParse(first, out int m))
            {
                Debug.WriteLine("Operator");
                Debug.WriteLine(pressed);
                op = pressed;
            }
            return pressed;
        }

        public string Reset() {
            // Reset calculator

            state = 0;
            first = "";
            op = null;
            second = "";

            return "";
        }

    }
}
