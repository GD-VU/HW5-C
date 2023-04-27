Console.Clear();

int [] CreateArray(int Length, int min, int max)
{
    int [] numbers = new int [Length];
    for (int i = 0; i<numbers.Length; i++)
    {
        numbers[i]=new Random().Next(min,max+1);
    }
    return numbers;
}

void PrintArray(int [] numbers)
{
    System.Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write(numbers[i]+ " ");
    }
    System.Console.WriteLine(" ]");
}

int Num (string arg)
{
    System.Console.WriteLine($"Введите {arg} ");
    return int.Parse(System.Console.ReadLine());
}

void SumNechet (int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (!(i%2==0)) sum = sum + array[i];
    }
    System.Console.WriteLine(sum);
}

int a = Num("Enter array Length: ");
int b = Num("Enter min value for random numbers: ");
int c = Num("Enter max value for random numbers: ");

int [] arr = CreateArray(a,b,c);
PrintArray(arr);
SumNechet(arr);
