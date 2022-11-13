using System;

namespace Delegates
{
    class DelegateFunctions
    {
        public void BitGridOverflow(object sender, ArithmeticEventArgs e)
        {
            Arithmetic procedure = (Arithmetic)sender;
            procedure.isOverflow = true; 
            Console.WriteLine(e.message);
        }
    }
}
