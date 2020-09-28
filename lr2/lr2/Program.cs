 using System;

namespace lr2
{
    class Program
    {
        static void Main(string[] args)
        {
            // task1a();
            //task1b();
            //task1c();
            //task1d();
            //task1e();
            //task1f();
            //task2a();
            //task2b();
            //task2c();
            //task2d();
            //task3a();
            //task3b();
            //task3c();
            //task3d();
            //task4(); 
            //5
            //(int max, int min, int sum, char firstLetter) tuple;
            //int[] array = { 1, 2, 3, 4, 5, 81, 0, 738 };
            //string name = "elena";

            //tuple = task5(array, name);

            //Console.WriteLine($"Max num: {tuple.max}\n" +
            //                  $"Min num: {tuple.min}\n" +
            //                  $"Sum: {tuple.sum}\n" +
            //                  $"First letter: {tuple.firstLetter}");

          task6_checked();
        task6_unchecked();
        }
      
        static void task1a()
        {
            bool a = true;
            Console.WriteLine("bool a = " + a);

            byte b = 111;
            Console.WriteLine("byte b = " + b);

            sbyte c = -111;
            Console.WriteLine("sbyte c = " + c);

            char d = 'F';
            Console.WriteLine("char d = " + d);

            decimal e = 1111111;
            Console.WriteLine("decimal e = " + e);

            double f = 11.111111;
            Console.WriteLine("double f = " + f);

            float g = (float)1.1;
            Console.WriteLine("float g = " + g);

            int h = 111111111;
            Console.WriteLine("int h = " + h);

            uint i = 11111111;
            Console.WriteLine("uint i = " + i);

            long j = 91918191919;
            Console.WriteLine("long j = " + j);

            ulong k = 2584165894;
            Console.WriteLine("ulong k = " + k);

            short l = 16652;
            Console.WriteLine("short l = " + l);

            ushort m = 25845;
            Console.WriteLine("ushort m = " + m);

            Console.WriteLine("Введите строку:");
            string n = Console.ReadLine();
            Console.WriteLine("string n = " + n);
        }
        static void task1b()
        {
            byte a = 121;
            Console.WriteLine("Явные преобразования byte a = " + a + " в ");
            
            Console.WriteLine("int : " + (int)a);
            Console.WriteLine("short : " + (short)a);
            Console.WriteLine("long : " + (long)a);
            Console.WriteLine("float : " + (float)a);
            Console.WriteLine("double : " + (double)a);

            short b = 223;
            Console.WriteLine("Неявные преобразования short b = " + b + " в ");
           
            long c = b;
            Console.WriteLine("long : " + c);
            float d = b;
            Console.WriteLine("float : " + d);
            double e = b;
            Console.WriteLine("double : " + e);
            int f = b;
            Console.WriteLine("int : " + f);
            double i = e + f;
            Console.WriteLine("double e + f: " + i);

            bool j = System.Convert.ToBoolean(a);
            Console.WriteLine("Преобразование Convert.ToBoolean(a) : " + j);
            string h = System.Convert.ToString(e);
            Console.WriteLine("Преобразование Convert.ToString(i) : " + e);
        }

        static void task1c()
        {
            int a = 249;
            object b = a; 
            a = (int)b;
        }

        static void task1d()
        {
            var i = 12;     //инициал-ся целочисленным
            var d = 12.3;   //инициал-ся double
            var f = 0.34F;  //инициал-ся float
        }

        static void task1e()
        {
            int? a = null;

            string? name = null;
            Console.WriteLine(name ?? "aaaaaa");
        }

        static void task1f()
        {
            var a = 25;
            //a = 2.5;
        }

        static void task2a()
        {
            string a = "aaa";
            string b = "bbb";
            string c = "aaa";

            Console.WriteLine(a == c); 
            Console.WriteLine(a == b); 
        }

        static void task2b()
        {
            string a = "aaa aa ";
            string b = "bbb bb ";
            string c = "ccc";
            // сцепление
            a += b;
            Console.WriteLine(a);
            // копирование
            string d = a;
            Console.WriteLine(d); 
            // выделение подстроки и её копирование
            string e = a.Substring(0, 5);
            Console.WriteLine(e);
            // разделение строки на слова
            string[] f = b.Split(); 
            Console.WriteLine(f[0]);

            // вставка в определенную позицию
            a = "aaa aa ";
            Console.WriteLine(a.Insert(4, c));

            // удаление
            Console.WriteLine(a.Remove(0, 2));
        }

        static void task2c()
        {
            string a = null;
            string b = String.Empty;

            Console.WriteLine(String.IsNullOrEmpty(a)); //true
            Console.WriteLine(String.IsNullOrEmpty(b)); //true
        }

        static void task2d()
        {
            var a = new System.Text.StringBuilder("abdc cfghy rfgthyu");
            a.Append("!");
            a.Insert(5, "111111 ");
            Console.WriteLine(a);
            Console.WriteLine(a.Remove(0, 4));
        }

        static void task3a()
        {
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.Write("\n");
            }
        }

        static void task3b()
        {
            string[] str_array = { "Hi", "Hello", "Bye" };
            Console.WriteLine("Содержание массива:");
            for (int i = 0; i < str_array.Length; i++)
                Console.WriteLine($"[{i}]. {str_array[i]}");

            Console.WriteLine("Выберите номер строки, которую хотите заменить: ");
            int a = System.Convert.ToInt32(Console.ReadLine());

            if (a < str_array.Length)
            {
                Console.WriteLine("Напишите предложение: ");
                string answer = Console.ReadLine();
                str_array[a] = answer;
                for (int i = 0; i < str_array.Length; i++)
                    Console.WriteLine($"[{i}]. {str_array[i]}");
            }
            else Console.WriteLine("Вы ввели неправильное число");
        }

        static void task3c()
        {
            byte arraySize = 4;
            int[][] array = new int[arraySize][];

            for (int i = 0; i < arraySize; i++)
            {
                array[i] = new int[i + 1];
                Console.WriteLine($"заполните массив {i} из {arraySize - 1}");
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]}\t");
                }
                Console.Write("\n");
            }
        }

        static void task3d()
        {
            var array = new[] { 1, 2, 3, 4 }; // неявно типизированный массив чисел
            var str = "lol"; // неявно типизированная строка
        }

        static void task4()
        {
            // a 
            (int, string, char, string, ulong) tuple = (18, "STR", 'm', "ASDASDASD", 888888);
            // b 
            Console.WriteLine(tuple);
            Console.WriteLine($"{tuple.Item1} {tuple.Item2} {tuple.Item4}");
            // c 
            string name;
            int age;

            (string name, ushort age) b = ("Elena", 17);

            name = b.name;
            age = b.age;

            var (_,c) = b;
            Console.WriteLine(c);

            Console.WriteLine(b == ("Elena", 17)); // true
            Console.WriteLine(b == ("Elena", 18)); // false
        }


        static (int max, int min, int sum, char firstLetter) task5(int[] a, string str)
        {

            if (((a is null || a.Length == 0) || (str is null || str.Length == 0)) == false)
            {

                int min = int.MaxValue;
                int max = int.MinValue;
                int sum = 0;

                foreach (int i in a)
                {
                    sum += i;

                    if (i < min)
                    {
                        min = i;
                    }

                    if (i > max)
                    {
                        max = i;
                    }
                }
                
                char letter = str[0];

                return (max, min, sum, letter);
            }
            else return (0, 0, 0, '0');
        }

        static void task6_checked()
        {
            checked
            {
                int i = int.MaxValue;
                Console.WriteLine(i);
            }
        }

        static void task6_unchecked()
        {
            unchecked
            {
                int i = int.MaxValue;
                Console.WriteLine(i);
            }
        }
    }
}
