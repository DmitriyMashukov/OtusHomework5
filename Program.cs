namespace OtusHomework5;

class Program
{
    static void Main(string[] args)
    {
        ////Основное задание:
        var s = new Stack("a", "b", "c");
        Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");

        var deleted = s.Pop();

        Console.WriteLine($"Извлек верхний элемент '{deleted}' Size = {s.Size}");
        s.Add("d");
        Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");

        s.Pop();
        s.Pop();
        s.Pop();
        Console.WriteLine($"size = {s.Size}, Top = {(s.Top == null ? "null" : s.Top)}");
        s.Pop();

        ////Дополнительное задание 1:
        //var newStack = new Stack("a", "b", "c");
        //newStack.Merge(new Stack("1", "2", "3"));

        ////Дополнительное задание 2:
        //var concatenatedStack = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"), new Stack("А", "Б", "В"));

    }
}
