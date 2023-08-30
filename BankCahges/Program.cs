using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankCahges
{
    internal class Program
    {
        static void Main()
        {
            Bank bank = new Bank();

            while (true)
            {
                Console.WriteLine("Введите данные для банка:");
                Console.Write("Имя: ");
                bank.Name = Console.ReadLine();

                Console.Write("Деньги: ");
                if (int.TryParse(Console.ReadLine(), out int money))
                {
                    bank.Money = money;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод для денег.");
                }

                Console.Write("Процент: ");
                if (int.TryParse(Console.ReadLine(), out int percent))
                {
                    bank.Percent = percent;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод для процента.");
                }

                Console.WriteLine("\nТекущие данные банка:");
                Console.WriteLine($"Имя: {bank.Name}");
                Console.WriteLine($"Деньги: {bank.Money}");
                Console.WriteLine($"Процент: {bank.Percent}\n");
                Console.WriteLine("Выйти?");
                Console.WriteLine("Для выхода нажмите 1, для продолжения - любую другую клавишу");
                int choice;
                int.TryParse(Console.ReadLine(), out choice);
                if ( choice == 1)
                {
                    break;
                }
            }
            Thread thread = new Thread(new ThreadStart(bank.SaveData));
            thread.Start();
        }
    }
}
