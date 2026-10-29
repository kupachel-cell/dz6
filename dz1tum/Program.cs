using dz1tum.classes;
using dz1tum.enums;
using System;
using static dz1tum.classes.Bankacc;
class Program
{
    static void Ex1()
    {

        Console.WriteLine("Введите начальный баланс: ");
        string inputBalance = Console.ReadLine();
        decimal startBalance = Convert.ToDecimal(inputBalance);

        Console.WriteLine("Выберите тип банковского счета:\n1 - Current (Текущий)\n2 - Savings (Сберегательный)\n3 - Deposit (Депозитный)");
        Console.Write("Введите цифру от 1 до 3: ");
        string userChoice = Console.ReadLine();
        AccountType selectedType = AccountType.Current;
        if (userChoice == "1")
        {
            selectedType = AccountType.Current;
        }
        else if (userChoice == "2")
        {
            selectedType = AccountType.Savings;
        }
        else if (userChoice == "3")
        {
            selectedType = AccountType.Deposit;
        }
        else
        {
            Console.WriteLine("Неверный ввод. По умолчанию выбран счет: Current");
        }
        BankAccount ExampleAccount = new BankAccount(startBalance, selectedType);

        Console.WriteLine("\nСчет успешно создан:");
        ExampleAccount.PrintInfo();

        Console.Write("\nВведите сумму для снятия: ");
        string inputWithdraw = Console.ReadLine();
        decimal withdrawAmount = Convert.ToDecimal(inputWithdraw);
        ExampleAccount.IsWithdrawable(withdrawAmount);

        Console.Write("\nВведите сумму для пополнения: ");
        string inputDeposit = Console.ReadLine();
        decimal depositAmount = Convert.ToDecimal(inputDeposit);
        ExampleAccount.IsReplenishable(depositAmount);

        Console.WriteLine("\nИтоговое состояние счета:");
        ExampleAccount.PrintInfo();
    }
    static void Hw1()
    {
        Console.Write("Введите высоту здания (в метрах): ");
        if (!double.TryParse(Console.ReadLine(), out double height) || height <= 0)
        {
            Console.WriteLine("Ошибка: высота должна быть положительным числом.");
            Console.ReadLine();
            return;
        }

        Console.Write("Введите количество этажей: ");
        if (!int.TryParse(Console.ReadLine(), out int floors) || floors <= 0)
        {
            Console.WriteLine("Ошибка: количество этажей должно быть целым числом больше нуля.");
            Console.ReadLine();
            return;
        }

        Console.Write("Введите количество квартир: ");
        if (!int.TryParse(Console.ReadLine(), out int apartments) || apartments <= 0)
        {
            Console.WriteLine("Ошибка: количество квартир должно быть больше нуля.");
            Console.ReadLine();
            return;
        }

        Console.Write("Введите количество подъездов: ");
        if (!int.TryParse(Console.ReadLine(), out int entrances) || entrances <= 0)
        {
            Console.WriteLine("Ошибка: количество подъездов должно быть больше нуля.");
            Console.ReadLine();
            return;
        }
        Building building = new Building(height, floors, apartments, entrances);
        building.PrintInfo();
    }

static void Main(string[] args)
    {
        Console.WriteLine("Задания 7.1-7.3");
        Ex1();
        Console.ReadLine();
        Hw1();
        Console.ReadLine();
    }
}
