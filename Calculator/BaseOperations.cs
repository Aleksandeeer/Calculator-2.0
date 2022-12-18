using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public enum Operation
    {
        None,
        Plus,
        Minus,
        Multiply,
        Division,
        Pow
    }
    public class BaseOperations : IOperation
    {
        public Operation Operation { get; private set; }
        delegate double Exec(double a, double b);
        private Exec execute;
        public double Execute(double a, double b)
        {
            return execute.Invoke(a, b);
        }
        public void ChangeOperation(Operation operation)
        {
            this.Operation = operation;
            switch (operation)
            {
                case Operation.Plus:
                    execute = (double a, double b) => (a + b);
                    break;
                case Operation.Minus:
                    execute = (double a, double b) => (a - b);
                    break;
                case Operation.Multiply:
                    execute = (double a, double b) => (a * b);
                    break;
                case Operation.Division:
                    execute = (double a, double b) => (a / b);
                    break;
                case Operation.Pow:
                    execute = (double a, double b) => (Math.Pow(a, b));
                    break;
                default:
                    execute = null;
                    break;
            }
        }

    }
}
