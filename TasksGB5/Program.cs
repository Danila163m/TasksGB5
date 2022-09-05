int programm;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("------");
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
    Console.WriteLine("1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
    Console.WriteLine("2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму четных элементов, стоящих на нечётных позициях (позиция - индекс элемента в массиве).");
    Console.WriteLine("3. Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
    programm = Convert.ToInt32(Console.ReadLine());
    
    switch (programm)
    {
        case 1:
            Console.WriteLine("Введите размер массива");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            FillArrayRandomNumbers(numbers);
            Console.WriteLine("Вот наш массив: ");
            PrintArray(numbers);
            int count = 0;

            for (int z = 0; z < numbers.Length; z++)
            if (numbers[z] % 2 == 0)
            count++;

            Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

            void FillArrayRandomNumbers(int[] numbers)
            {
                for(int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = new Random().Next(100,1000);
                }
            }
            void PrintArray(int[] numbers)
            {
                Console.Write("[ ");
                for(int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
                Console.Write("]");
                Console.WriteLine();
            }
            break;

        case 2:
            Console.WriteLine("Введите размер массива");
            int size1 = Convert.ToInt32(Console.ReadLine());
            int[] numbers1 = new int[size1];
            FillArrayRandomNumbers1(numbers1);
            Console.WriteLine("Вот наш массив: ");
            PrintArray1(numbers1);
            int sum = 0;

            for (int i = 0; z < numbers1.Length; i+=2)
                   if (numbers1[i] % 2 == 0) && (i % 2 > 0) {
                sum = sum + numbers1[i]
            }

                Console.WriteLine($"всего {numbers1.Length} чисел, сумма элементов на нечётных позициях = {sum}");

            void FillArrayRandomNumbers1(int[] numbers1)
            {
                for(int i = 0; i < numbers1.Length; i++)
                    {
                        numbers1[i] = new Random().Next(1,10);
                    }
            }
            void PrintArray1(int[] numbers)
            {
                Console.Write("[ ");
                for(int i = 0; i < numbers1.Length; i++)
                    {
                        Console.Write(numbers1[i] + " ");
                    }
                Console.Write("]");
                Console.WriteLine();
            }
            break;

            case 3:
                Console.WriteLine("Введите размер массива");
                int size2 = Convert.ToInt32(Console.ReadLine());
                int[] numbers2 = new int[size2];
                FillArrayRandomNumbers2(numbers2);
                Console.WriteLine("Вот наш массив: ");
                PrintArray2(numbers2);
                int min = Int32.MaxValue;
                int max = Int32.MinValue;

                for (int z = 0; z < numbers2.Length; z++)
                {
                    if (numbers2[z] > max)
                        {
                            max = numbers2[z];
                        }
                    if (numbers2[z] < min)
                        {
                            min = numbers2[z];
                        }
                }

                Console.WriteLine($"всего {numbers2.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
                Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

                void FillArrayRandomNumbers2(int[] numbers)
                {
                    for(int i = 0; i < numbers2.Length; i++)
                        {
                            numbers2[i] = Convert.ToInt32(new Random().Next(100,1000)) / 100;
                        }
                }
                void PrintArray2(int[] numbers)
                {
                    Console.Write("[ ");
                    for(int i = 0; i < numbers2.Length; i++)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    Console.Write("]");
                    Console.WriteLine();
                }
            break;
    }
}
