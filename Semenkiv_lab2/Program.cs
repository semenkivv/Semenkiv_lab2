using System;

namespace Laba_2_V_11
{
    class Program
    {
        /// <summary>
        /// Variant 11
        /// 123, 130, 149, 186, 37, 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 123:-------------------------------------------------------------------------------------");
            Task_123();

            Console.WriteLine("Задание 130:-------------------------------------------------------------------------------------");
            Task_130();

            Console.WriteLine("Задание 149:-------------------------------------------------------------------------------------");
            Task_149();

            Console.WriteLine("Задание 186:-------------------------------------------------------------------------------------");
            Task_186();

            Console.WriteLine("Задание 37:-------------------------------------------------------------------------------------");
            Task_37();
        }
        /// <summary>
        /// Дана последовательность целых положительных чисел. Найти произведение только тех из них, которые больше заданного числа М. 
        /// Если таких чисел нет, то выдать сообщение об этом.
        /// </summary>
        private static void Task_123()
        {

            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(100)+1;
            }
            Console.WriteLine("Массив:");
            Console.WriteLine(String.Join(" ; ", array));
            int m = new Random().Next(100)+1;
            Console.WriteLine("M="+m);
            double value = 1;
            bool showErore = true;
            foreach (int number in array)
            {
                if (number > m)
                {
                    value *= number;
                    showErore = false;
                }
            }
            if (showErore)
            {
                Console.WriteLine("В данном массиве нет чисел больше M!");
            }
            else
            {
                Console.WriteLine($"Произведение чисел, которые больше  М({m}): {value}");
            }
        }
        /// <summary>
        /// Даны целые положительные числа а1, а2, ..., an. Найти среди них те, которые являются квадратами некоторого числа m.
        /// </summary>
        private static void Task_130()
        {
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(100) + 1;
            }
            Console.WriteLine("Массив:");
            Console.WriteLine(String.Join(" ; ", array));
            int m = new Random().Next(10) + 1;
            Console.WriteLine("M=" + m);
            int index = 0;
            int[] resultArr = new int[array.Length];
            foreach (int number in array)
            {
                if (number == m *m)
                {
                    resultArr[index] = number;
                    index++;
                }
            }
            Array.Resize(ref resultArr, index);
            Console.WriteLine("Числа ,которые являются квадратами  числа M:");
            if(resultArr.Length != 0)
            {
                Console.WriteLine(String.Join(" ; ", resultArr));
            }
            else
            {
                Console.WriteLine("не найдено");
            }
        }
        /// <summary>
        /// Даны две последовательности а1, а2, ..., an и b1, b2, ..., bm (m < n). В каждой из них члены различны. 
        /// Верно ли, что все члены второй последовательности входят в первую последовательность?
        /// </summary>
        private static void Task_149()
        {
            int n = new Random().Next(20) + 1;
            int m = 0;
            bool corectValue = false;
            while (!corectValue)
            {
                m = new Random().Next(20) + 1;
                if (m < n)
                {
                    corectValue = true;
                }
            }
            Console.WriteLine("n="+n+"; m="+m);
            int[] firstArray = generateUniqArray(n);
            Console.WriteLine("Первый массив с длинной n("+n+"):");
            Console.WriteLine(String.Join(" ; ", firstArray));
            int[] secondtArray = generateUniqArray(m);
            Console.WriteLine("Второй массив с длинной n(" + m + "):");
            Console.WriteLine(String.Join(" ; ", secondtArray));
            int countNumberRetryInFirstArr = 0;
            for (int i = 0; i < secondtArray.Length; i++)
            {
                for (int j = 0; j < firstArray.Length; j++)
                {
                    if(secondtArray[i]== firstArray[j])
                    {
                        countNumberRetryInFirstArr++;
                        break;
                    }
                }
            }
            if(countNumberRetryInFirstArr == secondtArray.Length)
            {
                Console.WriteLine("Все члены второго массива входят в первый иассив");
            }
            else {
                Console.WriteLine("Некоторые члены второго массива не входят в первый иассив");
            }

            static int[] generateUniqArray(int size)
            {
                int[] array = new int[size];
                for (int i = 0; i < array.Length; i++)
                {
                    bool isCorectValue = false;

                    while (!isCorectValue)
                    {
                        int randomValue = new Random().Next(100) + 1;
                        bool isRetryNumber = false;
                        foreach (int number in array)
                        {
                            if (randomValue == number)
                            {
                                isRetryNumber = true;
                                break;
                            }
                        }
                        if (!isRetryNumber)
                        {
                            isCorectValue = true;
                            array[i] = randomValue;
                        }
                    }
                }
                return array;
            }
        }
        /// <summary>
        /// В одномерном массиве все отрицательные элементы переместить в начало массива, а остальные — в конец с сохранением порядка следования. 
        /// Дополнительный массив использовать не разрешается.
        /// </summary>
        private static void Task_186()
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(-10,10);
            }
            Console.WriteLine("Массив :");
            Console.WriteLine(String.Join(" ; ", array));

            int indexFromleft = 0;
            int indexFromRight = array.Length - 1;
            while (indexFromleft <= indexFromRight)
            {
                if (array[indexFromleft] < 0)
                {
                    indexFromleft++; 
                }
                else if (array[indexFromRight] >= 0)
                {
                    indexFromRight--; 
                }
                else
                {
                    int temp = array[indexFromleft];
                    array[indexFromleft] = array[indexFromRight];
                    array[indexFromRight] = temp;
                    indexFromleft++;
                    indexFromRight--;
                }
            }
            Console.WriteLine("Массив после перемещения отрицательных елементов в начало массива :");
            Console.WriteLine(String.Join(" ; ", array));
        }
        /// <summary>
        /// Даны натуральные числа а1, а2, ..., an. Указать те из них, у кот. остаток от деления на М равен L (0 ≤ L ≤ M – 1).
        /// </summary>
        private static void Task_37()
        {
            int m = new Random().Next(20) + 1;
            int l =0;
            bool corectValue = false;
            while (!corectValue)
            {
                l = new Random().Next(20) + 1;
                if (0 <= l && l<=m-1 )
                {
                    corectValue = true;
                }
            }
            Console.WriteLine("M=" + m + "; L=" + l);
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(100) + 1;
            }
            Console.WriteLine("Массив:");
            Console.WriteLine(String.Join(" ; ", array));
            int index = 0;
            int[] resultArr = new int[array.Length];
            foreach (int number in array)
            {
                if (number % m ==l)
                {
                    resultArr[index] = number;
                    index++;
                }
            }
            Array.Resize(ref resultArr, index);
            Console.WriteLine($"Елементы из массива , у которых остаток от деления на М({m}) равен L({l})");
            Console.WriteLine(String.Join(" ; ", resultArr));
        }
    }
}
