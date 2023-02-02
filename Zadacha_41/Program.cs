Console.Clear();

Console.Write("Введите числа, через пробел: ");
string value = Console.ReadLine();
string[] temp = value.Split(new Char[] {' '});
int count = 0;
foreach(string item in temp)
{
    int num = int.Parse(item);
    
    if(num > 0)
    {
        count++;
    }

}
Console.WriteLine("\nЧисел больше нуля: " +count);