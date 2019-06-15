using System;
using TypeLibrary;

namespace CustomLib {
    public class CustomClass : TypeLibrary.ILab4 {
        public double A, B, C, D, X, X2, X3;
        public int VARIANT = 14;

        public string[] GetAvailableVariables() {
            string[] VARIABLES = new string[] { "A", "B", "C", "D", "X", "X2", "X3" };
            return VARIABLES;
        }
        
        public void SetVariable(string variable, object val) {
            switch(variable) {
                case "A": A = (int)val; break;
                case "B": B = (int)val; break;
                case "C": C = (int)val; break;
                case "D": D = (int)val; break;
                case "X": X = (int)val; break;
                case "X2": X2 = (int)val; break;
                case "X3": X3 = (int)val; break;
            }
        }
        
        public double GetResult() {
            double RESULT = (A * X3 + B * X2 + C / X + D / X) / X;
            return RESULT;
        }
        
        public int GetVariant() {
            return VARIANT;
        }
    }
}