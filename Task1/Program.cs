namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        MyArray arr = new MyArray();
        
        //Task1
        arr.Show();
        arr.Show("Array contains next values: ");
        
        //Task2
        Random random = new Random();
        int randomNumber = random.Next(0, 100);
        
        int max = arr.Max();
        int min = arr.Min();
        float avg = arr.Avg();
        bool doesContain = arr.Search(randomNumber);
        
        Console.WriteLine($"Max number: {max}\nMin number: {min}\nAverage number: {avg}\nDoes arr contain {randomNumber}: {doesContain}");
    }
}