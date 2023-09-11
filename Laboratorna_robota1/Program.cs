public class Numbers
{
    private int a, b; // Поля

    // Конструктор з 2 параметрами
    public Numbers(int x, int y)
    {
        a = x;
        b = y;
    }

    // Метод, що перевіряє, чи є числа натуральними
    public bool Correct()
    {
        return a > 0 && b > 0;
    }

    // Метод для обчислення НСД чисел a і b
    public int Nod()
    {
        int a1 = a;
        int b1 = b;
        while (b1 != 0)
        {
            int temp = b1;
            b1 = a1 % b1;
            a1 = temp;
        }
        return a1;
    }

    // Метод для обчислення НСК чисел a і b
    public int Nok()
    {
        return (a * b) / Nod();
    }

    // Метод для виведення значень полів a і b на екран
    public void Print()
    {
        Console.WriteLine($"a = {a}, b = {b}");
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int x, y;
        try
        {
            Console.Write("Введіть x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Введіть y: ");
            y = int.Parse(Console.ReadLine());

            // Створення об'єкту
            Numbers n = new Numbers(x, y);
            // Виведення значення полів на екран
            n.Print();
            // Перевірка існування об'єкту
            if (n.Correct()) // Об'єкт існує
            {
                // Виводимо на екран НСД та НСК
                Console.WriteLine($"Найбільший спільний дільник: {n.Nod()}");
                Console.WriteLine($"Найменше спільне кратне: {n.Nok()}");
            }
            else // Об'єкт не існує
            {
                Console.WriteLine("Об'єкт не існує, тому що одне або обидва числа не натуральні.");
            }
        }
        catch // Усі інші випадки
        {
            Console.WriteLine("Помилка!!!");
        }
        Console.ReadKey();
    }
}