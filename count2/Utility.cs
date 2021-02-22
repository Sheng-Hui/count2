using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace count2
{
    public class Utility
    {
        //public double Operate(double num1, double num2, string oper)
        public string Operate(double num1, double num2, string oper)
        {
            //var result = 0d;
            var result = "";
            switch (oper)
            {
                case "+":
                    /*var test = new Test();
                    var addOp = test as IAddOperator;*/

                    //Addition addition = new Addition();
                    var addition = new Addition();
                    result = addition.Operate(num1, num2);
                    //result = num1 + num2;
                    break;
                case "-":
                    var subtraction = new Subtraction();
                    result = subtraction.Operate(num1, num2);
                    //result = num1 - num2;
                    break;
                case "*":
                    var multiplication = new Multiplication();
                    result = multiplication.Operate(num1, num2);
                    //result = num1 * num2;
                    break;
                case "/":
                    var division = new Division();
                    if (num2 != 0)
                    {
                        result = division.Operate(num1, num2);
                    }
                    else
                        //Console.WriteLine("數值2不得為0");
                        result = "除數不得為0";
                    break;
            }
            return result;

        }
        private class Addition
        {
            //public double Operate(double n1, double n2)
            public string Operate(double n1, double n2)
            {
                double d = n1 + n2;
                return Convert.ToString(d);
                // reutrn n1 + n2;
            }
        }
        private class Subtraction
        {
            //public double Operate(double n1, double n2)
            public string Operate(double n1, double n2)
            {
                double d = n1 - n2;
                return Convert.ToString(d);
                //return n1 - n2;
            }
        }
        private class Multiplication
        {
            //public double Operate(double n1, double n2)
            public string Operate(double n1, double n2)
            {
                double d = n1 * n2;
                return Convert.ToString(d);
                //return n1 * n2;
            }
        }
        private class Division
        {
            //public double Operate(double n1, double n2)
            public string Operate(double n1, double n2)
            {
                if (n2 != 0)
                {
                    double d = (n1 / n2);
                    return Convert.ToString(d);
                }
                else
                    //Console.WriteLine("數值2不得為0");
                    return null;
            }
        }
    }


    /*public interface IAddOperator
    {
        double Add(double n1, double n2);
    }
    public interface IMinusOperator
    {
        double Minus(double n1, double n2);
    }

    public class Test : IAddOperator, IMinusOperator
    {
        public double Minus(double n1, double n2)
        {
            throw new NotImplementedException();
        }

        double IAddOperator.Add(double n1, double n2)
        {
            throw new NotImplementedException();
        }
    }*/
    /*private class Addition : Operator
    {
        //public double Operate(double n1, double n2)
        //{
        //    throw new NotImplementedException();
        //}
        public double Operate(double n1, double n2)
        /*public override double Operate(double n1, double n2)
        {
            throw new NotImplementedException();
        }
    }*/


    /*public abstract class Operator
        {
            public abstract double Operate(double n1, double n2);
        }*/


        /*private double Addition(double num1, double num2, double result);
        {
            var result = 0d;
        result = num1 + num2;
            return result;*/

    //private double Subtraction;
    //private double Multiplicaion;
    //private double Division;

    //private double Subtraction(double num1, double num2)
    //{
    //    result = num1 - num2;
    //}
    //private double Multiplicaion(double num1, double num2)
    //{
    //    result = num1 * num2;
    //}
    //private double Division(double num1, double num2)
    //{
    //    if (num2 != 0)
    //    {
    //        result = num1 / num2;

    //    }
    //    break;
    //}
}

