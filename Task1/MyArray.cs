using Task2;

namespace Task1;

public class MyArray : IOutput, IMath
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

    public int Max()
    {
        int max = Numbers[0];
        
        foreach (int number in Numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        return max;
    }
    
    public int Min()
    {
        int min = Numbers[0];
        
        foreach (int number in Numbers)
        {
            if (number < min)
            {
                min = number;
            }
        }

        return min;
    }

    public float Avg()
    {
        float sum = 0;

        foreach (int number in Numbers)
        {
            sum += number;
        }

        return sum / Numbers.Length;
    }

    public bool Search(int valueToSearch)
    {
        return Numbers.Contains(valueToSearch);
    }
}