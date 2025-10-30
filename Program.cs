using System;

namespace Bookstore
{
    class Program
    {



        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("===Вітаємо у Бібліотеці===");
            Console.WriteLine("\n===Каталог===");
            Console.WriteLine("\nГарі Потер-300 грн");
            Console.WriteLine("Відьмак-450 грн");
            Console.WriteLine("Мистецтво війни-500 грн");
            Console.WriteLine("Декстер-1500 грн");
            Console.ResetColor();

            double price1 = 300, price2 = 450, price3 = 500, price4 = 1500;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nКількість книг (Гарі Потер) (шт)");
            int book1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кількість книг (Відьмак) (шт)");
            int book2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кількість книг (Мистецтво війни) (шт)");
            int book3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кількість книг (Декстер) (шт)");
            int book4 = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();

            double sum1 = price1 * book1;
            double sum2 = price2 * book2;
            double sum3 = price3 * book3;
            double sum4 = price4 * book4;
            double total = sum1 + sum2 + sum3 + sum4;

            Random rnd = new Random();
            double discount = Math.Round(rnd.NextDouble() * 10, 2);
            double discountAmount = total * discount / 100;
            double finalTotal = total - discountAmount;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n=== Рахунок покупця ===");
            Console.ResetColor();

            Console.WriteLine($"Гарі Потер: {book1} шт × {price1} грн = {sum1} грн");
            Console.WriteLine($"Відьмак: {book2} шт × {price2} грн = {sum2} грн");
            Console.WriteLine($"Мистецтво війни: {book3} шт × {price3} грн = {sum3} грн");
            Console.WriteLine($"Декстер: {book4} шт × {price4} грн = {sum4} грн");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nЗагальна сума: {Math.Round(total, 2)} грн");
            Console.WriteLine($"Знижка: {discount}% (-{Math.Round(discountAmount, 2)} грн)");
            Console.WriteLine($"До оплати: {Math.Round(finalTotal, 2)} грн");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nДякуємо за покупку!");
            Console.ResetColor();

        }
    }
}

