namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        IOutput arr = new MyArray();
        arr.Show();
        arr.Show("Array contains next values: ");
    }
}