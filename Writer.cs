using System;

namespace lab1 {
    /// <summary>
    /// Класс работающий с входными и выходными данными
    /// </summary>
    public class Writer {
        /// <summary>
        /// Функция информации о том что может делать программа
        /// </summary>
        public void Info () {
            System.Console.WriteLine ("I can :\n" +
                "1.Plus\n" +
                "2.Minus\n" +
                "3.Multiplication\n" +
                "4.Division\n" +
                "5.Mod\n" +
                "6.Info\n" +
                "0.Exit\n" +
                "What to do?\n");
        }
/// <summary>
/// Функция ввода и проверки на корректность первого числа
/// </summary>
/// <returns>Первое число </returns>
        public double input_first () {
            double x = 0;
            System.Console.WriteLine ("Write first number");
            while (!double.TryParse (Console.ReadLine (), out x)) {
                System.Console.WriteLine ("Please write correct number");
            }

            return x;
        }
/// <summary>
/// Функция ввода и проверки коректности ввода второго числа
/// </summary>
/// <returns>Второе число</returns>
        public double input_second () {
            System.Console.WriteLine ("Write second number");
            double y = 0;
            while (!double.TryParse (Console.ReadLine (), out y)) {
                System.Console.WriteLine ("Please write correct number");
            }
            return y;
        }
/// <summary>
/// Функция вывода результата на экран пользователя
/// </summary>
/// <param name="result">Результат вычислений </param>
        public void Write (double result) {
            System.Console.WriteLine ("Your resalt " + result.ToString ());
        }
    }
}