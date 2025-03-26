namespace OtusHomework5;

class Program
{
    static void Main(string[] args)
    {
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
    }
}
