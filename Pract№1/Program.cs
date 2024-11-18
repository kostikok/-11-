namespace Pract_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
Start:
            Console.WriteLine("Выберите номер задания: \n" +
                "1. Разработайте программу, которая принимает четыре числа и находит среднее значение между ними \n" +
                "2. Разработайте программу-калькулятор, в которой можно выбрать действие для двух вводимых пользователем чисел: \n" +
                "3. Разработайте программу для конвертации температуры между градусами Цельсия, Кельвина, Фаренгейта \n" +
                "4. Разработайте программу, которая позволяет определить имя файла (с расширением) по введенному пути \n" +
                "5. Разработайте программу для нахождения самого длинного слова в предложении \n" +
                "6. Разработайте программу, которая может перемножить два массива значений \n" +
                "7. Разработайте программу, которая может найти максимальное и минимальное число из пяти введенных \n" +
                "8. Разработайте программу, которая выводит “пирамиду” из чисел из количества уровней, введенных пользователем \n" +
                "9. Напечатать полную таблицу умножения \n" +
                "10.“Пирамида” из чисел из количества уровней, введенных пользователем, с проверкой (11 вариант) \n");
            Console.WriteLine();
            string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                    int a1,a2,a3,a4, result;
                    string input1, input2, input3, input4;
                    Console.WriteLine("Введите первое число: ");
                    input1 = Console.ReadLine();
                    a1 = Convert.ToInt32(input1);
                    Console.WriteLine("Введите второе число: ");
                    input2 = Console.ReadLine();
                    a2 = Convert.ToInt32(input2);
                    Console.WriteLine("Введите третье число: ");
                    input3 = Console.ReadLine();
                    a3 = Convert.ToInt32(input3);
                    Console.WriteLine("Введите четвёртое число: ");
                    input4 = Console.ReadLine();
                    a4 = Convert.ToInt32(input4);
                    result = (a1 + a2 + a3 + a4) / 4;
                    Console.WriteLine("Среднее число чисел " + input1 + ", " + input2 + ", " + input3 + ", " + input4 + " = " + result);
                    Console.ReadLine();
                    Console.Clear();
                    goto Start;


                    case "2":
                    Console.WriteLine("Введите 2 числа");
                    input1 = Console.ReadLine();
                    input2 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Что будем делать? \n" +
                        "1. Сложение \n" +
                        "2. Вычитание \n" +
                        "3. Умножение \n" +
                        "4. Деление\n" +
                        "5. Остаток");
                    input3 = Console.ReadLine();
                    a1 = Convert.ToInt32(input1);
                    a2 = Convert.ToInt32(input2);
                    a3 = Convert.ToInt32(input3);
                    if (a3 == 1){Console.WriteLine(a1 + a2);}
                    else if (a3 == 2){Console.WriteLine(a1 - a2);}
                    else if (a3 == 3){ Console.WriteLine(a1 * a2); }
                    else if (a3 == 4) {Console.WriteLine(a1 / a2);}
                    else if (a3 == 5) { Console.WriteLine(a1 % a2); }
                    else { Console.WriteLine("Не то число :("); }
                    Console.ReadLine();
                    Console.Clear();
                    goto Start;


                    case "3":
                    double temp;
                    Console.WriteLine("Выберете шкалу вводимой температуры: \n" +
                        "1. Цельсий \n" +
                        "2. Кельвин \n" +
                        "3. Фаренгейт \n");
                    input1 = Console.ReadLine();
                    Console.WriteLine("Введите температуру: ");
                    input3 = Console.ReadLine();
                    temp = Convert.ToDouble(input3);
                    Console.WriteLine();
                    Console.WriteLine("Выберите шкалу для конвертации: \n" +
                        "1. Цельсий \n" +
                        "2. Кельвин\n" +
                        "3. Фаренгейт\n");
                    input2 = Console.ReadLine();
                    if (input1 == "1")
                    {
                        if (input2 == "1")  Console.WriteLine(temp);
                        else if (input2 == "2") Console.WriteLine(temp + 273.15);
                        else if (input2 == "3") Console.WriteLine((temp - 32) / 1.8);
                        else Console.WriteLine("Не то число :(");
                    }
                    else if (input1 == "2")
                    {
                        if (input2 == "1") Console.WriteLine(temp - 273.15);
                        else if (input2 == "2") Console.WriteLine(temp);
                        else if (input2 == "3") Console.WriteLine((temp - 273.15) * 1.8 + 32);
                        else Console.WriteLine("Не то число :(");

                    }
                    else if (input1 == "3")
                    {
                        if (input2 == "1") Console.WriteLine(temp * 1.8 + 32);
                        else if (input2 == "2") Console.WriteLine((temp - 32)*1.8 +273.15);
                        else if (input == "3") Console.WriteLine(temp);
                        else Console.WriteLine("Не то число :(");

                    }
                    Console.ReadLine();
                    Console.Clear();
                    goto Start;

                    case "4":
                    Console.WriteLine("Введите путь до файла: ");
                    input1 = Console.ReadLine();
                    string[] subs = input1.Split('\\');
                    a1 = subs.Length;
                    Console.WriteLine(subs[a1-1]);
                    Console.Clear();
                    goto Start;

                    case "5":
                    Console.Write("Введите строку: ");
                    input1 = Console.ReadLine();
                    string[] str = input1.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' });
                    int maxlen = 0;
                    int index = 0;
                    for (i = 0; i < str.Length; i++)
                    {
                        if (str[i].Length > maxlen)
                        {
                            maxlen = str[i].Length;
                            index = i;
                        }
                    }
                    Console.Write("Самое длинное слово: {0}", str[index]);
                    Console.ReadLine();
                    Console.Clear();
                    goto Start;

                    case "6":
                    Console.WriteLine("Введите значения для первого массива через пробел:");
                    string strr = Console.ReadLine();
                    string[] firstArrey = strr.Split(' ');
                    Console.WriteLine("Введите значения для второго массива через пробел:");
                    strr = Console.ReadLine();
                    string[] secondArrey = strr.Split(' ');
                    for (i = 0; i < firstArrey.Length; i++)
                    {
                        Console.WriteLine($"{Convert.ToInt32(firstArrey[i]) * Convert.ToInt32(secondArrey[i])} ");
                    }
                    Console.ReadLine();
                    Console.Clear();
                    goto Start;

                    case "7":
                    Console.WriteLine("Введите 5 чисел: ");
                    string strrr = Console.ReadLine();
                    string[] max = strrr.Split(' ');
                    string maxValue = max.Max();
                    string minValue = max.Min();
                    Console.WriteLine(maxValue + " " + minValue);
                    Console.ReadLine();
                    Console.Clear();
                    goto Start;

                    case "8":
                    Console.WriteLine("Введите количество ступеней: ");
                    input1 = Console.ReadLine();
                    a1 = Convert.ToInt32(input1);
                    for (i = 1; i <= a1; i++)
                    {
                        for (int j = 0; j < a1 - i; j++)
                        {
                            Console.Write(" ");
                        }

                        for (int k = 1; k <= i; k++)
                        {
                            Console.Write(k + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.ReadLine();
                    Console.Clear();
                    goto Start;

                    case "9":
                    int i1 = 1;
                    int i2 = 9;
                    for (i = 1; i < 10; i++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            Console.Write($"{1} x {j} = {i * j}\t");
                        }

                        Console.WriteLine();

                    }
                    Console.ReadLine();
                    Console.Clear();
                    goto Start;

                    case "10":
                    try
                    {
                        Console.WriteLine("Введите количество ступеней: ");
                        input1 = Console.ReadLine();
                        a1 = Convert.ToInt32(input1);
                        if (a1 > 0)
                        {
                            for (i = 1; i <= a1; i++)
                            {
                                for (int j = 0; j < a1 - i; j++)
                                {
                                    Console.Write(" ");
                                }

                                for (int k = 1; k <= i; k++)
                                {
                                    Console.Write(k + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                        else if (a1 <= 0)
                        {
                            Console.WriteLine("Ошибка, должно быть положительным!");
                        }
                        else if (a1 % 1 != 0)
                        {
                            Console.WriteLine("Ошибка, число должно быть челым!");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка, вводиться должно число!");
                    }
                    Console.ReadLine();
                    Console.Clear();
                    goto Start;

                default:
                    Console.WriteLine("Не то число :(");
                    Console.ReadLine();
                    Console.Clear();
                    goto Start;
            }
        }
    }
}