using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class Arithmetic
    {
        public int FirstOperand { get; set; }
        public int SecondOperand { get; set; }
        public int AddingResult { get; set; }
        public int SubtractingnResult { get; set; }
        public int MultiplyingResult { get; set; }
        public int DividingResult { get; set; }

        public bool isOverflow;

        public delegate void ArithmeticHandler(object sender, ArithmeticEventArgs args);
        public event ArithmeticHandler BitGridOverflow;

        DelegateFunctions functions = new DelegateFunctions();

        public Arithmetic(int firstOperand, int secondOperand)
        {
            FirstOperand = firstOperand;
            SecondOperand = secondOperand;

            isOverflow = false;

            BitGridOverflow += functions.BitGridOverflow;
        }

        public void Calculate()
        {
            if (isOverflow == false)
            {
                long addingResult = (long)FirstOperand + SecondOperand;
                if (addingResult > int.MaxValue)
                    BitGridOverflow?.Invoke(this, new ArithmeticEventArgs("Overflow during adding"));
                else
                    AddingResult = (int)addingResult;

                long subtractingResult = (long)FirstOperand - SecondOperand;
                if (subtractingResult > int.MaxValue)
                    BitGridOverflow?.Invoke(this, new ArithmeticEventArgs("Overflow during subtracting"));
                else
                    SubtractingnResult = (int)subtractingResult;

                long multiplyingResult = (long)FirstOperand * SecondOperand;
                if (multiplyingResult >= int.MaxValue)
                    BitGridOverflow?.Invoke(this, new ArithmeticEventArgs("Overflow during multiplying"));
                else
                    MultiplyingResult = (int)multiplyingResult;

                long dividingResult = (long)FirstOperand / SecondOperand;
                if (dividingResult > int.MaxValue)
                    BitGridOverflow?.Invoke(this, new ArithmeticEventArgs("Overflow during dividing"));
                else
                    DividingResult = (int)dividingResult;

            }
        }
    }
}
