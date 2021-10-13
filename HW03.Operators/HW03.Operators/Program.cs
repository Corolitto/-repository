using System;

namespace HW03.Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //AskNumber();
            //ShowAlphabet();
            ShowMovement();
        }

        public static void AskNumber()
        {
            double num1, num2, UserNum, amount = default;
            string operIn;

            Console.WriteLine("Введите число a");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Ошибка ввода! Введите число a");
            }

            Console.WriteLine("Введите число b");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Ошибка ввода! Введите число b");
            }

            Console.WriteLine("Что сделать с числом а, если прибавить, введите +, если отнять -, если умножить *, делить / ");
            operIn = Console.ReadLine();

            if (operIn == "-")
            {
                amount = num1 - num2;
            }
            if (operIn == "+")
            {
                amount = num1 + num2;
                //Console.WriteLine(amount);
            }
            if (operIn == "/")
            {
                amount = num1 / num2;
               // Console.WriteLine(amount);
            }
            if (operIn == "*" )
            {
                amount = num1 * num2;
               // Console.WriteLine(amount);
            }

            Console.WriteLine("введите результат вычисления");
            while (!double.TryParse(Console.ReadLine(), out UserNum))
            {
                Console.WriteLine("ошибка ввода! введите числовое значение");
            }

            if (amount > UserNum)
            {
                Console.WriteLine("неправильно. ожидается число больше");
            }
            else if (amount < UserNum)
            {
                Console.WriteLine("неправильно. ожидается число меньше");
            }
            else
            {
                Console.WriteLine("правильно");

            }
        }
        public static void ShowAlphabet()
        { 
            for (int i = 90; i >= 65; i-- )
            {
                Console.WriteLine(Convert.ToChar(i));
            }
        }

        public static void ShowMovement()
        {
            //запросить пользователя ввести ввести анправление движения
            //при этом использоваться должны только wsad, при использовании других символов
            //просьба ввести именно эти.  также нужна кнопка выхода из цикла, когда все перемещения сделаны
            //все движения дожны быть после преращения цикла выведены на экран
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string input = default,
                output = default;
            char right = '\u2192', left = '\u2190', forward = '\u2191', backward = '\u2193';
           
            do
            {
                Console.WriteLine("Enter W S A D");
                input = Console.ReadLine().ToUpper();
                if (input == "W")
                {
                    output += forward;
                }
                if (input == "S")
                {
                    output += backward;
                }
                if (input == "A")
                {
                    output += left;
                }
                if (input == "D")
                {
                    output += right;
                }
            }
            while (input == "W" || input == "S" || input == "D" || input == "A");

            Console.WriteLine(output);
        }
    }
}

