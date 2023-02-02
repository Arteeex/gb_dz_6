Console.Clear();

Console.Write("How many numbers do we enter? -> ");
int N = Convert.ToInt32(Console.ReadLine());
int [] arrayNumbers = new int [N];
int count = 0;

for (int i = 0; i < arrayNumbers.Length;i++ )
{
    arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
}
foreach (var item in arrayNumbers)
{
    Console.Write(item + " ");
}
for (int i = 0; i < arrayNumbers.Length; i++)
{
    if (arrayNumbers[i] > 0)
    {
    count++;
    }
}
Console.WriteLine("\nThe number of numbers greater than zero: " +count);