internal class Program
{
    private static void Main(string[] args)
    {
        // Создаём объект класса Car
        Car car = new Car();

        // Задаём значения
        car.Marka = "Жигули";
        car.Nomer = "Т144ТО";
        car.Probeg = 10350;

        // Выводим данные об автомобиле
        car.Show();

        // Считаем среднегодовой пробег при возрасте 2 года
        double sredniyProbeg = car.SrednGodovoyProbeg(2);
        Console.WriteLine($"Среднегодовой пробег: {sredniyProbeg} км/год");

        Console.ReadKey();
    }
}

class Car
{
    // Открытые поля
    public string? Marka;
    public string? Nomer;
    public int Probeg;

    // Метод — показать данные об автомобиле
    public void Show()
    {
        Console.WriteLine($"Марка: {Marka}");
        Console.WriteLine($"Гос. номер: {Nomer}");
        Console.WriteLine($"Пробег: {Probeg} км");
    }

    // Метод — расчёт среднегодового пробега
    // age — возраст автомобиля в годах (передаётся как параметр)
    public double SrednGodovoyProbeg(int age)
    {
        if (age <= 0)
            return 0;
        return (double)Probeg / age;
    }
}
    
