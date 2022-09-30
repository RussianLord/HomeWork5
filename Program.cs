void HW1()
{
    Console.WriteLine("Программа создаёт массив длинной от 5 до 10 и заполняет его случайными трёхзначными числами...");
    Console.WriteLine("...введите ЧЁТНОЕ или НЕЧЁТНОЕ число, чтобы увидеть их количество в массиве...");
    int changer = Convert.ToInt32(Console.ReadLine());
    Random random = new Random();
    int size = random.Next(5, 11);
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    ChangerTask(numbers, changer); 
}

void FillArray(int[] numbers)
{
    Random random = new Random();
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(100, 1000);
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

void ChangerTask(int[] numbers, int changer)
{
    if(changer % 2 == 0)
    {
        CheckArray(numbers);
    }
    else
    {
        OtherArray(numbers);
    }
    
}

void CheckArray(int[] numbers)
{
    int check = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] % 2 == 0)
        {
            check++;
        }
    }
    Console.WriteLine("Чётных чисел в массиве = " + check);

}

void OtherArray(int[] numbers)
{
    int check = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] % 2 != 0)
        {
            check++;
        }
    }
    Console.WriteLine("Нечётных чисел в массиве = " + check);

}

////////////////////////////////////////////////////////////////////////////////////

void HW2()
{
    Console.WriteLine("Программа создаёт массив длинной от 5 до 10 и заполняет его случайными числами...");
    Console.WriteLine("...введите ЧЁТНОЕ или НЕЧЁТНОЕ число, чтобы посчитать сумму элементов с ЧЁТНЫМИ или НЕЧЁТНЫМИ индексами...");
    int changer = Convert.ToInt32(Console.ReadLine());
    Random random = new Random();
    int size = random.Next(5, 11);
    int[] numbers = new int[size];
    FillArray2(numbers);
    PrintArray(numbers);
    ChangerTask2(numbers, changer); 
}

void FillArray2(int[] numbers)
{
    Random random = new Random();
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(0, 1000);
    }
}

void ChangerTask2(int[] numbers, int changer)
{
    if(changer % 2 == 0)
    {
        CheckArray2(numbers);
    }
    else
    {
        OtherArray2(numbers);
    }
    
}

void CheckArray2(int[] numbers)
{
    int sum = 0;
    for(int i = 0; i < numbers.Length - 1; i++)
    {
        if(i % 2 == 0)
        {
            sum = sum + numbers[i];
            Console.WriteLine(sum + " + " + numbers[i]);
        }
    }
    Console.WriteLine("Сумма элементов чётных индексов = " + sum);

}

void OtherArray2(int[] numbers)
{
    int sum = 0;
    for(int i = 0; i < numbers.Length - 1; i++)
    {
        if(i % 2 != 0)
        {
            sum = sum + numbers[i];
            Console.WriteLine(sum + " + " + numbers[i]);
        }
    }
    Console.WriteLine("Сумма элементов нечётных индексов = " + sum);

}

////////////////////////////////////////////////////////////////////////////////////

void HW3()
{
    Console.WriteLine("Программа создаёт массив длинной от 5 до 10 и заполняет его случайными двухначными вещественными числами с двумя значениями после запятой...");
    Console.WriteLine("Нажмите ENTER, чтобы получить разницу между Максимальным и Минимальным числами...");
    Console.ReadLine();
    Random random = new Random();
    int size = random.Next(5, 11);
    double[] numbers = new double[size];
    double maxValue = 0;
    double minValue = 100;
    FillArray3(numbers);
    PrintArray2(numbers);
    MaxNumber(numbers, maxValue, minValue);
}

void FillArray3(double[] numbers)
{
    Random random = new Random();
    
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Math.Round(random.NextDouble() * (100) , 2);
    }
}

void MaxNumber(double[] numbers, double maxValue, double minValue)
{
    for(int i = 0; i < numbers.Length;i++)
    {
        if(maxValue < numbers[i])
        {
            maxValue = numbers[i];     
        }

        if(minValue > numbers[i])
        {
            minValue = numbers[i];         
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Разница между максимальным числом массива {maxValue} и минимальным {minValue} равняется {Math.Round(maxValue - minValue , 2)}");
    
}

void PrintArray2(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
}

////////////////////////////////////////////////////////////////////////////////////

// HW1();
// HW2();
HW3();

