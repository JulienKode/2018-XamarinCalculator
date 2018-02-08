using System;
using System.Data;
using System.Diagnostics;

namespace Calculator
{
    public class CalculEngine
    {
        public CalculEngine()
        {
        }

        string first = "";

        public string ManageCalcul(string pressed)
        {
            Debug.WriteLine("TEST");
            Debug.WriteLine(pressed.Length);

            if (pressed.Equals("C")) {
                Reset();
            }
            else if (pressed.Equals("=")) {
                string result = ""; 
                try {
                    result = new DataTable().Compute(first, null).ToString();
                } catch (SyntaxErrorException e) {  
                    Debug.WriteLine(e);
                } catch (EvaluateException e) {
                    Debug.WriteLine(e);
                }

                Reset();
                return result;
            }
            else if (pressed.Equals("x")) {
                first += "*";
            }
            else {
                first += pressed;
            }
            return first;
        }

        public string Reset()
        {
            // Reset calculator

            first = "";
            return "";
        }
    }
}
