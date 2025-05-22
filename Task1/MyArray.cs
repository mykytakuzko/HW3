namespace Task1;

public class MyArray : IOutput
{
    public int[] Numbers { get; set; } = new int[10];

    public MyArray()
    {
        Numbers = GetRandomValuesForArray();
    }

    private int[] GetRandomValuesForArray()
    {
        int[] result = new int[10];
        
        Random random = new Random();

        for(int i = 0; i < 10; i++)
        {
            result[i] = random.Next(0, 100);
        }
        
        return result;
    }

    public void Show()
    {
        for (int i = 0; i < Numbers.Length; i++)
        {
            if (i != Numbers.Length - 1)
            {
                Console.Write($"{Numbers[i]}, ");
            }
            else
            {
                Console.WriteLine(Numbers[i]);
            }
        }
    }

    public void Show(string info)
    {
        Console.Write(info);
        Show();
    }
}