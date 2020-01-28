using System;

namespace Вычислитель
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)        //бесконечный цикл
            {
                Console.Clear();    //очищает консоль от предыдущих решений
                Double a, b;
                string c;

                try
                {
                    Console.WriteLine("Введите число 1");
                    a = double.Parse(Console.ReadLine());   //в переменную a считываем данные с консоли с помощью метода Parse, в который будем передавать результат работы метода ReadLine класса Console

                }
                catch (Exception)
                {
                    Console.WriteLine("Вы ввели неверные символы");
                    Console.ReadLine();
                    continue;
                }

                
                Console.WriteLine("Выберите операцию: '+','-','*','/'");
                c = Console.ReadLine();

                try
                {
                    Console.WriteLine("Введите число 2");
                    b = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Вы ввели неверные символы");
                    Console.ReadLine();
                    continue;       //в случае ошибки дальнейший код выполняться не будет
                }
                
                switch (c)
                {
                    case "+":
                        Console.WriteLine(a + b);
                        break;

                    case "-":
                        Console.WriteLine(a - b);
                        break;

                    case "*":
                        Console.WriteLine(a * b);
                        break;

                    case "/":
                        if (b == 0) //если b=0, то программа выдаст сообщение, что на него делить нельзя
                        {
                            Console.WriteLine("На ноль делить нельзя!");
                        }
                        else        //если в переменную b помещено любое другое значение, кроме 0, то программа поделит их
                        {
                            Console.WriteLine(a / b);
                        }


                        break;

                    default:
                        Console.WriteLine("Ошибка, выберите указанную операцию");
                        break;
                                        }
                Console.ReadLine();
            }
            

        }
    }
}
