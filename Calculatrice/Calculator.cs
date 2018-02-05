using System;
using System.Diagnostics;

namespace Calculatrice
{
    public class Calculator
    {
        int state = 0;

        string op = null;

        int second = 0;

        public Calculator()
        {
        }

        void MakeCalcul(string op)
        {
            Debug.WriteLine(op);
            switch (op)
            {
                case "+":
                    state = state + second;
                    break;
                case "-":
                    state = state - second;
                    break;
                case "/":
                    state = state / second;
                    break;
                case "x":
                    state = state * second;
                    break;
            }
            Debug.WriteLine(op);
            Debug.WriteLine(state.ToString());
            op = null;

        }


        void ManageCalcul(string pressed)
        {
            int nb;
            if (Int32.TryParse(pressed, out nb))
            {
                if (firstType == true) {
                    state = nb;
                    firstType = false;
                }
                else
                    second = nb;
                Debug.WriteLine("State");
                Debug.WriteLine(state);
                Debug.WriteLine("Second");
                Debug.WriteLine(second);
            }
            else if (pressed.Equals("="))
            {
                Debug.WriteLine("Equals");
                MakeCalcul(op);
            }
            else
            {
                Debug.WriteLine("Operator");
                Debug.WriteLine(pressed);
                op = pressed;
            }
        }

        void Reset() {
            
        }
    }
}
