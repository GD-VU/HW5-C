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

void GetCount (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0) count = count +1;
    }
    System.Console.WriteLine(count);
}
int a = Num("Enter array Length: ");
int b = Num("Enter min value for random numbers: ");
int c = Num("Enter max value for random numbers: ");

int [] arr = CreateArray(a,b,c);
PrintArray(arr);
GetCount(arr);
