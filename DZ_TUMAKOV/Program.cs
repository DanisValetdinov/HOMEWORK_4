namespace std
{
    class DZ_TUMAKOV
    {
        static void Main()
        {
            TASK1();
            TASK2();
            TASK3();
            TASK4();
            TASK5();
            TASK6();
        }
        static void TASK1()
        {
            /*/*Упражнение 5.1 Написать метод, возвращающий наибольшее из двух чисел. Входные
            параметры метода – два целых числа. Протестировать метод.*/
            Console.WriteLine("Упражнение 5.1. Создать и протестировать метод, возвращающий наибольшее из двух чисел");
            Console.Write("Введите первое число: ");
            bool IsNum = int.TryParse(Console.ReadLine(), out int a);
            Console.Write("Введите второе число: ");
            bool IsNum2 = int.TryParse(Console.ReadLine(), out int b);
            if (IsNum && IsNum2)
            {
                Maximum(a, b);
            }
            else
            {
                Console.WriteLine("Вы ввели не числа");
            }
        }
        static void TASK2()
        {
            /*Упражнение 5.2 Написать метод, который меняет местами значения двух передаваемых
            параметров. Параметры передавать по ссылке. Протестировать метод.*/
            Console.WriteLine("Упражнение 5.2. Поменять местами значения двух переменных в методе");
            string str1 = "вет";
            string str2 = "При";
            Swap(ref str1, ref str2);
            Console.WriteLine($"Первая строка - {str1}, Вторая строка - {str2}");
        }
        static void TASK3()
        {
            /*Упражнение 5.3 Написать метод вычисления факториала числа, результат вычислений
            передавать в выходном параметре. Если метод отработал успешно, то вернуть значение true;
            если в процессе вычисления возникло переполнение, то вернуть значение false. Для
            отслеживания переполнения значения использовать блок checked.*/
            Console.WriteLine("Уражнение 5.3. Написать метод и вычислить факториал");
            Console.Write("Введите число:");
            bool IsNum = long.TryParse(Console.ReadLine(), out long Input);
            bool IsFactor = Factor(ref Input);
            if (IsNum)
            {
                if (IsFactor)
                {
                    Console.WriteLine($"Факториал числа - {Input}");
                }
                else
                {
                    Console.WriteLine("Факториал слишком большой");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели не число");
            }
        }
        static void TASK4()
        {
            /*Упражнение 5.4 Написать рекурсивный метод вычисления факториала числа.*/
            Console.WriteLine("Упражнение 5.4. Вычислить факториал с помощью рекурсии");
            Console.Write("Введите число факториал которого хотите вычислить:");
            bool IsNum = long.TryParse(Console.ReadLine(), out long Input);
            if (IsNum)
            {
                long Factor = FactorRecursion(Input);
                if (!(Factor == 0))
                {
                    Console.WriteLine($"Факториал заданного числа = {Factor}");
                }

            }

        }
        static void TASK5()
        {
            /*Домашнее задание 5.1 Написать метод, который вычисляет НОД двух натуральных чисел
            (алгоритм Евклида). Написать метод с тем же именем, который вычисляет НОД трех
            натуральных чисел.*/
            Console.WriteLine("Домашнее задание 5.1. Создать метод, вычисляющий НОД двух и трех чисел");
            Console.Write("Введите первое число:");
            bool IsInt = int.TryParse(Console.ReadLine(), out int Int);
            Console.Write("Введите второе число:");
            bool IsInt2 = int.TryParse(Console.ReadLine(), out int Int2);
            if (IsInt && IsInt2)
            {
                if (Int > Int2)
                {
                    Console.WriteLine($"НОД этих чисел - {NOD(Int, Int2)}");
                }
                else
                {
                    Console.WriteLine($"НОД этих чисел - {NOD(Int2, Int)}");
                }
            }
            else
            {
                Console.WriteLine("Нужно было ввести число");
            }
            Console.Write("Введите первое число:");
            bool IsInt3 = int.TryParse(Console.ReadLine(), out int Int3);
            Console.Write("Введите второе число:");
            bool IsInt4 = int.TryParse(Console.ReadLine(), out int Int4);
            Console.Write("Введите третье число:");
            bool IsInt5 = int.TryParse(Console.ReadLine(), out int Int5);
            if (IsInt3 && IsInt4 && IsInt5)
            {
                int[] Ints_AR = { Int3, Int4, Int5 };
                Array.Sort(Ints_AR);
                Console.WriteLine($"НОД этих чисел - {NOD(Ints_AR[0], Ints_AR[1], Ints_AR[2])}");
            }
            else
            {
                Console.WriteLine("Вы ввели не число");
            }
        }
        static void TASK6()
        {
            /*Домашнее задание 5.2 Написать рекурсивный метод, вычисляющий значение n-го числа
            ряда Фибоначчи. Ряд Фибоначчи – последовательность натуральных чисел 1, 1, 2, 3, 5, 8,
            13... Для таких чисел верно соотношение Fk = Fk-1 + Fk-2 .*/
            Console.WriteLine("Домашнее задание 5.2. Создать рекурсивный метод, вычисляющий значение n-го числа ряда Фибоначчи");
            Console.Write("Введите номер необходимого числа Фибоначчи:");
            bool IsInt = int.TryParse(Console.ReadLine(), out int n);
            if (IsInt)
            {
                Console.WriteLine($"Номер - {n}. Число - {Fib(n)}");
            }
            else
            {
                Console.WriteLine("Вы ввели не число");
            }

        }
        static void Maximum(int a, int b)
        {
            Console.WriteLine($"Максимальное число - {Math.Max(a, b)}");
        }
        static void Swap(ref string str1, ref string str2)
        {
            string strSwap = str1;
            str1 = str2;
            str2 = strSwap;

        }
        static bool Factor(ref long a)
        {
            long res = 1;
            for (int i = 1; i <= a; i++)
            {
                try
                {
                    checked
                    {
                        res *= i;
                    }
                }
                catch (OverflowException)
                {
                    return false;
                }
            }
            a = res;
            return true;
        }
        static long FactorRecursion(long a)
        {
            try
            {
                checked
                {
                    if (a == 0)
                    {
                        return 1;
                    }
                    return a * FactorRecursion(a - 1);
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Факториал слишком большой");
                return 0;
            }
        }
        static int NOD(int a, int b)
        {
            int result = b;
            while (!(a % b == 0))
            {
                result = a % b;
                int Num = a;
                a = b;
                b = Num % b;
            }

            return result;
        }
        static int NOD(int a, int b, int c)
        {
            return NOD(NOD(a, b), c);
        }
        static int Fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }

        }
    }
}
