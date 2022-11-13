using System;

namespace Delegates
{
    class ArithmeticEventArgs : EventArgs
    {
        public readonly string message;
        public ArithmeticEventArgs(string msg) => message = msg;
    }
}
