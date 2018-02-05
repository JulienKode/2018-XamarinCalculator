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
            if (op == null) {
                return first;
            }

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
            Reset();
            return state.ToString();
        }


        public string ManageCalcul(string pressed)
        {
            Debug.WriteLine("TEST");
            Debug.WriteLine(pressed.Length);

            int nb;
            if (Int32.TryParse(pressed, out nb))
            {
                if (op == null)
                    first += pressed;
                else
                    second += pressed;
            }
            else if (pressed.Equals("="))
                return MakeCalcul(op);
            else if (first.Length == 0 && pressed.Equals("-"))
                first += "-";
            else if (op != null && (op.Equals("x") || op.Equals("/")) && second.Length == 0 && pressed.Equals("-"))
                second += "-";
            else
            {
                Debug.WriteLine("Operator");
                Debug.WriteLine(pressed);
                op = pressed;
            }

            if (op == null)
                return first;
            return second;
        }

        public string Reset() {
            // Reset calculator

            first = "";
            op = null;
            second = "";

            return "";
        }

    }
}
