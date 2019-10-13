using System;

/// <summary>
/// Задание с семинара 2 по дисциплине "Программирование"
/// </summary>
/// <remarks>
/// <para>Автор: Шадрин Михаил</para>
/// <para>Группа: БПИ199(1)/БПИ199(2)/БПИ1910(1)</para>
/// <para>Дата: 14.09.2019</para>
/// </remarks>
public class Program
{
    /// <summary>
    /// Безопасно парсит вещественное число из консоли
    /// </summary>
    /// <param name="message">Сообщение выводимое пользователю на экран</param>
    /// <returns>Вещественное число, введенное пользователем в консоль</returns>
    public static double ReadDouble(string message)
    {
        double parsedValue;
        do
        {
            Console.WriteLine(message);
        } while (!double.TryParse(Console.ReadLine(), out parsedValue));

        return parsedValue;
    }

    /// <summary>
    /// Безопасно парсит вещественное число из консоли с дефолтным сообщением "Введите радиус:"
    /// </summary>
    /// <returns>Вещественное число, введенное пользователем в консоль</returns>
    public static double ReadDouble()
    {
        return ReadDouble("Введите радиус:");
    }

    /// <summary>
    /// Вычилсяет площадь круга
    /// </summary>
    /// <param name="radius">Радиус круга</param>
    /// <returns>Площадь круга</returns>
    static double getSquare(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    /// <summary>
    /// Вычисляет длину окружности
    /// </summary>
    /// <param name="radius">Радиус окружности</param>
    /// <returns>Длина окружности</returns>
    static double getLength(double radius)
    {
        return 2 * Math.PI * radius;
    }

    /// <summary>
    /// Вычисляет площадь круга и длину окружности
    /// </summary>
    /// <param name="radius">Радиус круга/окружности</param>
    /// <param name="square">Ссылка на переменную, сохраняющую значение площади круга</param>
    /// <param name="length">Ссылка на переменную, сохраняющую значение длины окружности</param>
    static void getSquareAndLength(double radius, out double square, out double length)
    {
        square = getSquare(radius);
        length = getLength(radius);
    }

    /// <summary>
    /// Точка входа программу
    /// </summary>
    public static void Main()
    {
        // ввод данных
        double r = ReadDouble();
        double x = ReadDouble("Введите X");
        double y = ReadDouble("Введите Y");

        r = (r <= 0) ? Double.Epsilon : r; // проверка на положительность радиуса

        getSquareAndLength(r, out double circleSquare, out double circleLength); // во входных параметрах метода сразу же объявляет переменные типа double,
                                                                                 // куда будут прихраниваться значения через модификатор out

        Console.WriteLine($"Длина окружности = {circleLength}, площадь круга = {circleSquare}"); // вывод вычисленных значений на экран
    }
}
