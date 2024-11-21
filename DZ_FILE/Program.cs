namespace std
{
    class DZ_FILE
    {
        static void Main()
        {
            TASK1();
            TASK2();
            TASK3();
            TASK4();
        }
        static void TASK1()
        {
            /*1. Вывести на экран массив из 20 случайных чисел. Ввести два числа из этого массива,
            которые нужно поменять местами. Вывести на экран получившийся массив.*/
            Console.WriteLine("Задание 1. Создать массив со случайными числами, поменять два числа местами и вывести массив на экран");
            Random Rand_Num = new Random();
            int[] IntAr = new int[20];
            for (int i = 0; i < IntAr.Length; i++)
            {
                IntAr[i] = Rand_Num.Next(1, 100);
            }
            foreach (int i in IntAr)
            {
                Console.Write($"{i}, ");
            }
            int Swap = IntAr[4];
            IntAr[4] = IntAr[9];
            IntAr[9] = Swap;
            foreach (int i in IntAr)
            {
                Console.Write($"{i}, ");
            }
        }
        static void TASK2()
        {
            /*2. Написать метод, где в качества аргумента будет передан массив (ключевое слово
            params). Вывести сумму элементов массива (вернуть). Вывести (ref) произведение
            массива. Вывести (out) среднее арифметическое в массиве.*/
            Console.WriteLine("Задание 2. Написать метод, куда будет передан массив. Вычислить сумму, произведение и среднее арифметическое элементов в массиве");
            int Multi = 1;
            double Average;
            int[] Array = { 11, 23, 45, 67, 89, 13, 14, 15, 16, 17, 18, 32 };
            int Sum = Array1(ref Multi, out Average, Array);
            Console.WriteLine($"Сумма элементов массива - {Sum}\nПроизведение элементов массива - {Multi}\nСреднее арифметическое элементов массива - {Average}");
        }
        static void TASK3()
        {
            /*3. Пользователь вводит числа. Если числа от 0 до 9, то необходимо в консоли нарисовать
            изображение цифры в виде символа #.Если число больше 9 или меньше 0, то консоль
            должна окраситься в красный цвет на 3 секунды и вывести сообщение об ошибке. Если
            пользователь ввёл не цифру, то программа должна выпасть в исключение. Программа
            завершает работу, если пользователь введёт слово: exit или закрыть (оба варианта
            должны сработать) - консоль закроется.*/
            Console.WriteLine("Задание 3. Нарисовать в консоли изображение цифры в виде символа #");
            bool Flag = true;
            while (Flag)
            {
                Console.Write("Введите цифру(от 0 до 9):");
                string String = Console.ReadLine();
                switch (String)
                {
                    case "0":
                        Console.WriteLine("####\n#  #\n#  #\n#  #\n#  #\n####");
                        break;
                    case "1":
                        Console.WriteLine("  ##\n ###\n# ##\n  ##\n  ##");
                        break;
                    case "2":
                        Console.WriteLine("####\n#  #\n ###\n##  \n####");
                        break;
                    case "3":
                        Console.WriteLine("####\n  ##\n ###\n  ##\n####");
                        break;
                    case "4":
                        Console.WriteLine("## ##\n## ##\n#####\n   ##\n   ##");
                        break;
                    case "5":
                        Console.WriteLine("####\n##  \n####\n  ##\n####");
                        break;
                    case "6":
                        Console.WriteLine("#####\n##  \n#####\n## ##\n#####");
                        break;
                    case "7":
                        Console.WriteLine("####\n  ##\n ###\n  ##\n  ##");
                        break;
                    case "8":
                        Console.WriteLine("#####\n## ##\n#####\n## ##\n#####");
                        break;
                    case "9":
                        Console.WriteLine("#####\n## ##\n#####\n   ##\n#####");
                        break;
                    case "exit":
                        Flag = false;
                        break;
                    case "закрыть":
                        Flag = false;
                        break;
                    default:
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Thread.Sleep(3000);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.WriteLine("Ошибка");
                        break;
                }
            }
        }
        static void TASK4()
        {
            /*4. Создать структуру Дед. У деда есть имя, уровень ворчливости (перечисление), массив
            фраз для ворчания (прим.: “Проститутки!”, “Гады!”), количество синяков от ударов
            бабки = 0 по умолчанию. Создать 5 дедов. У каждого деда - разное количество фраз для
            ворчания. Напишите метод (внутри структуры), который на вход принимает деда,
            список матерных слов (params). Если дед содержит в своей лексике матерные слова из
            списка, то бабка ставит фингал за каждое слово. Вернуть количество фингалов.*/
            Console.WriteLine("Задание 4. Создать дедов и узнать сколько они получат синяков");
            Deds Ded1 = new Deds();
            Ded1.Name = "Юрий";
            Ded1.Grumb = TierOfGrumb.Medium;
            Ded1.Phrase = new string[] { "Дебил", "Придурок", "Паскуда", "Наркоман" };
            Deds Ded2 = new Deds();
            Ded2.Name = "Владимир";
            Ded2.Grumb = TierOfGrumb.High;
            Ded2.Phrase = new string[] { "Недоношенный", "Мусор", "Как тебя земля носит", "Гад", "Проститутка" };
            Deds Ded3 = new Deds();
            Ded3.Name = "Прохор";
            Ded3.Grumb = TierOfGrumb.Medium;
            Ded3.Phrase = new string[] { "Придурок", "Дебилоид", "Проститутка", "Выпердыш", "Дегроид" };
            Deds Ded4 = new Deds();
            Ded4.Name = "Всеволод";
            Ded4.Grumb = TierOfGrumb.SSS;
            Ded4.Phrase = new string[] { "Гад", "Тварь", "Недостойный жить", "Сталина на тебя не хватает", "Наркоман", "Проститутка", "Я твою маму в кино водил"};
            Deds Ded5 = new Deds();
            Ded5.Name = "Анатолий";
            Ded5.Grumb = TierOfGrumb.Low;
            Ded5.Phrase = new string[] { "Дурак" };

            string[] CheckArray = { "Гад", "Тварь", "Недостойный жить", "Сталина на тебя не хватает", "Наркоман", "Проститутка", "Я твою маму в кино водил" };
            Ded1.Count = Ded1.Injury(Ded1, CheckArray);
            Ded2.Count = Ded2.Injury(Ded2, CheckArray);
            Ded3.Count = Ded3.Injury(Ded3, CheckArray);
            Ded4.Count = Ded4.Injury(Ded4, CheckArray);
            Ded5.Count = Ded5.Injury(Ded5, CheckArray);

            Console.WriteLine($"{Ded1.Name} получил синяков: {Ded1.Count}\n" +
                $"{Ded2.Name} получил синяков: {Ded2.Count}\n" +
                $"{Ded3.Name} получил синяков: {Ded3.Count}\n" +
                $"{Ded4.Name} получил синяков: {Ded4.Count}\n" +
                $"{Ded5.Name} получил синяков: {Ded5.Count}\n");
        }
        static int Array1(ref int Multi, out double Average, params int[] MyArray)
        {
            int Sum = 0;
            foreach (int i in MyArray)
            {
                Sum += i;
                Multi *= i;
            }
            Average = Sum / MyArray.Length;
            return Sum;
        }
        enum TierOfGrumb
        {
            Low,
            Medium,
            High,
            SSS
        }

        struct Deds
        {
            public string Name;
            public TierOfGrumb Grumb;
            public string[] Phrase;
            public uint Count;
            public uint Injury(Deds Ded, params string[] array)
            {
                uint Count = 0;
                foreach (string s in Ded.Phrase)
                {
                    if (array.Contains(s))
                    {
                        Count++;
                    }
                }
                return Count;
            }
        }

    }
}