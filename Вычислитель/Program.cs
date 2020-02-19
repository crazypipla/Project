using System;

namespace Вычислитель
{
    public class Program
    {
        public static string A (double a, string c, double b)
        {
            string str;
            double d;
            switch (c)
            {
                case "+":
                    d = (a + b);
                    str = d.ToString();
                    break;

                case "-":
                    d = (a - b);
                    str = d.ToString();
                    break;

                case "*":
                    d = (a * b);
                    str = d.ToString();                   
                    break;

                case "/":
                    if (b == 0) //если b=0, то программа выдаст сообщение, что на него делить нельзя
                    {
                        str = ("На ноль делить нельзя!");                       
                    }
                    else        //если в переменную b помещено любое другое значение, кроме 0, то программа поделит их
                    {
                        d = (a / b);
                        str = d.ToString();                        
                    }


                    break;

                default:
                    str = ("Ошибка, выберите указанную операцию");
                    //Console.WriteLine("Ошибка, выберите указанную операцию");
                    break;
            }

            return str;
        }

        public static void Main(string[] args)
        {
            while (true)        //бесконечный цикл
            {
                Console.Clear();    //очищает консоль от предыдущих решений
                Double a, b, d;
                string c, str;

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

                var e = Program.A(a, c, b); //результат равен return, который мы считаем в методе А
                Console.WriteLine(e);              
                Console.ReadLine();
            }
            

        }
    }
}
