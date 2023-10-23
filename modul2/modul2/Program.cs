using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul2
{
    class Program
    {
        static void task1()
        {
            char input;
            int spaceCount = 0;

            Console.WriteLine("Любые буквы (для завершения ставим точку):");

            do
            {
                input = Console.ReadKey().KeyChar;
                if (input == ' ')
                {
                    spaceCount++;
                }
            }
            while (input != '.');

            Console.WriteLine($"\nКоличество введенных пробелов: {spaceCount}");
        }

        static void task2()
        {

            Console.WriteLine("Введите номер трамвайного билета (6-значное число):");
            string ticketNumber = Console.ReadLine();

            if (IsLuckyTicket(ticketNumber))
            {
                Console.WriteLine("Этот билет - счастливый!");
            }
            else
            {
                Console.WriteLine("Этот билет не счастливый.");
            }
        }

        static bool IsLuckyTicket(string ticketNumber)
        {
            if (ticketNumber.Length != 6)
            {
                return false; 
            }

            int sumFirstHalf = 0;
            int sumSecondHalf = 0;

            for (int i = 0; i < 3; i++)
            {
                sumFirstHalf += int.Parse(ticketNumber[i].ToString());
                sumSecondHalf += int.Parse(ticketNumber[i + 3].ToString());
            }

            return sumFirstHalf == sumSecondHalf;
        }
        static void task3()
        {
           Console.WriteLine("Введите текст для конвертации:");
           string inputText = Console.ReadLine();
           string convertedText = ConvertCase(inputText);

           Console.WriteLine($"Текст после конвертации: {convertedText}");
            }

            static string ConvertCase(string text)
            {
                char[] charArray = text.ToCharArray();

                for (int i = 0; i < charArray.Length; i++)
                {
                    if (char.IsUpper(charArray[i]))
                    {
                        charArray[i] = char.ToLower(charArray[i]);
                    }
                    else if (char.IsLower(charArray[i]))
                    {
                        charArray[i] = char.ToUpper(charArray[i]);
                    }
                }

                return new string(charArray);
            }
  
        static void task4()
        {
            int A = 3;
            int B = 7;

            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
        static void task5()
        {
            Console.Write("Введите целое число N: ");
            int N = int.Parse(Console.ReadLine());

            int reversedNumber = ReverseNumber(N);

            Console.WriteLine($"Число, полученное при прочтении справа налево: {reversedNumber}");
        }

        static int ReverseNumber(int number)
        {
            int reversed = 0;

            while (number > 0)
            {
                int remainder = number % 10;
                reversed = reversed * 10 + remainder;
                number /= 10;
            }

            return reversed;
        }
        static void task6()
        {
            int number1 = 42;
            int number2 = 87;
            int number3 = 123;

            Console.WriteLine($"{number1}  {number2}  {number3}");
        }
        static void task7()
        {
            Console.WriteLine(5);
            Console.WriteLine(10);
            Console.WriteLine(21);
        }
        static void task8()
        {
            Console.Write("Введите расстояние в сантиметрах: ");
            int distanceInCentimeters = int.Parse(Console.ReadLine());

            int fullMeters = distanceInCentimeters / 100; // 1 метр = 100 сантиметров

            Console.WriteLine($"Число полных метров: {fullMeters}");
        }
        static void task9()
        {
            int totalDays = 234;
            int daysInAWeek = 7;

            int fullWeeks = totalDays / daysInAWeek;

            Console.WriteLine($"За {totalDays} дней прошло {fullWeeks} полных недель.");
        }
        static void task10()
        {
            int number = 67; 

            int tens = number / 10;

            int ones = number % 10;

            int sum = tens + ones;

            int product = tens * ones;

            Console.WriteLine($"Число десятков: {tens}");
            Console.WriteLine($"Число единиц: {ones}");
            Console.WriteLine($"Сумма цифр: {sum}");
            Console.WriteLine($"Произведение цифр: {product}");
        }
        static void task11()
        {
            bool A = true;
            bool B = false;
            bool C = false;

            // a. Вычислить A или B
            bool resultA = A || B;

            // b. Вычислить A и B
            bool resultB = A && B;

            // c. Вычислить B или C
            bool resultC = B || C;

            Console.WriteLine($"A или B: {resultA}");
            Console.WriteLine($"A и B: {resultB}");
            Console.WriteLine($"B или C: {resultC}");
        }
        static void task12()
        {
            double radius = 5.0; 
            double sideLength = 4.0; 
                       
            double circleArea = Math.PI * Math.Pow(radius, 2);
            double squareArea = Math.Pow(sideLength, 2);
                        
            if (circleArea > squareArea)
            {
                Console.WriteLine("Площадь круга больше.");
            }
            else if (circleArea < squareArea)
            {
                Console.WriteLine("Площадь квадрата больше.");
            }
            else
            {
                Console.WriteLine("Площади равны.");
            }
        }
        static void task13()
        {            
            double mass1 = 100.0; 
            double volume1 = 50.0; 

            double mass2 = 80.0; 
            double volume2 = 40.0; 

            double density1 = mass1 / volume1;
            double density2 = mass2 / volume2;

            if (density1 > density2)
            {
                Console.WriteLine("Материал первого тела имеет большую плотность.");
            }
            else if (density1 < density2)
            {
                Console.WriteLine("Материал второго тела имеет большую плотность.");
            }
            else
            {
                Console.WriteLine("Плотности равны.");
            }
        }
        static void task14()
        {
           
            double voltage1 = 12.0; 
            double resistance1 = 4.0; 

            double voltage2 = 12.0; 
            double resistance2 = 6.0; 

            double current1 = voltage1 / resistance1;
            double current2 = voltage2 / resistance2;

            if (current1 < current2)
            {
                Console.WriteLine("На первом участке цепи протекает меньший ток.");
            }
            else if (current1 > current2)
            {
                Console.WriteLine("На втором участке цепи протекает меньший ток.");
            }
            else
            {
                Console.WriteLine("Токи на обоих участках цепи равны.");
            }
        }
        static void task15()
        {
            double x = 2.5;
            double y = 7 * Math.Pow(x, 2) - 3 * x + 6;

            Console.WriteLine($"При x = {x}, y = {y}");
        }
        static void task16()
        {
            double a = 3.0; 
            double x = 12 * Math.Pow(a, 2) + 7 * a - 16;

            Console.WriteLine($"При a = {a}, x = {x}");
        }
        static void task17()
        {
            Console.Write("Введите длину стороны квадрата: ");
            double sideLength = double.Parse(Console.ReadLine());

            double perimeter = 4 * sideLength;

            Console.WriteLine($"Периметр квадрата: {perimeter}");
        }
        static void task18()
        {
            Console.Write("Введите радиус окружности: ");
            double radius = double.Parse(Console.ReadLine());

            double diameter = 2 * radius;

            Console.WriteLine($"Диаметр окружности: {diameter}");
        }
        static void task19()
        {
            double radiusOfEarth = 6350; 
            Console.Write("Введите высоту над Землей (в километрах): ");
            double heightAboveEarth = double.Parse(Console.ReadLine());

            double distanceToHorizon = Math.Sqrt(Math.Pow(radiusOfEarth, 2) + Math.Pow(radiusOfEarth + heightAboveEarth, 2));

            Console.WriteLine($"Расстояние до линии горизонта: {distanceToHorizon} км");
        }
        static void task20()
        {
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите значение y: ");
            double y = double.Parse(Console.ReadLine());

            double z = x * x * x - 2.5 * x * y + 1.78 * x * x - 2.5 * y + 1;

            Console.WriteLine($"Значение функции z = {z}");
        }
    

    static void Main(string[] args)
        {
            task20();
            Console.ReadLine();
        }
    }
}



