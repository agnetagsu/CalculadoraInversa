using System;

namespace CalculadoraInversa
{
    class Program
    {
        static void Main(string[] args)
        {
            int X,Y;
            char signo;

            Console.WriteLine("Introduzca el primer operando:");
            X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo operando:");
            Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el signo aritmético:");
            signo = Convert.ToChar(Console.ReadLine());

            switch(signo)
            {
                case '+':

                    Console.WriteLine("El resultado {0}+{1} = {2}", X, Y, X + Y);
                    break;

                case '-':

                    Console.WriteLine("El resultado {0}-{1} = {2}", X, Y, X - Y);
                    break;

                case '*':

                    Console.WriteLine("El resultado {0}*{1} = {2}", X, Y, X * Y);
                    break;

                case '/':

                    Console.WriteLine("El resultado {0}/{1} = {2}", X, Y,(double) X / Y);
                    break;

                case '^':

                    Console.WriteLine("El resultado {0}^{1} = {2}", X, Y, Math.Pow(X,Y));
                    break;

                case '%':

                    Console.WriteLine("El resultado {0}%{1} = {2}", X, Y, X % Y);
                    break;

                default:

                    Console.WriteLine("Signo aritmético incorrecto");
                    break;

            }
        }
    }
}
