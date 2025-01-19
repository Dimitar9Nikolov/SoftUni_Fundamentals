namespace _04_DataAndTypes;
class Program
{
    static void Main(string[] args)
    {
        int numberOfLines = int.Parse(Console.ReadLine());
        int sum = 0;
        while (numberOfLines > 0)
        {
            char letter = char.Parse(Console.ReadLine());
            numberOfLines--;
            int ascii = (int)letter;
            sum += ascii;
        }
        Console.WriteLine(sum);
    }
}

