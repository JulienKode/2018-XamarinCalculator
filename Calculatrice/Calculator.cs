using System;
using System.Diagnostics;

namespace Calculatrice
{
    public class Calculator
    {
        int state = 0;
        string first = "";

        public Calculator()
        {
        }
    

        public string ManageCalcul(string pressed)
        {
            Debug.WriteLine("TEST");
            Debug.WriteLine(pressed.Length);
            //  

            if (pressed.Equals("="))
                return new DataTable().Compute(first, null);
            else 
                first += pressed;
            return first;
        }

        public string Reset() {
            // Reset calculator

            first = "";
            return "";
        }

    }
}
