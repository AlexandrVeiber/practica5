using System;

namespace OfficeEquipmentApp
{
    public class Printer : OfficeEquipment
    {
        // Поле
        private int printSpeed; // Скорость печати

        // Свойство
        public int PrintSpeed
        {
            get { return printSpeed; }
            set { printSpeed = (value < 0) ? 0 : value; }
        }

        // Конструктор
        public Printer(string color = "", int price = 0, int printSpeed = 0) : base(color, price)
        {
            PrintSpeed = printSpeed;
        }

        // Метод для вывода информации
        public override void PrintInfo()
        {
            Console.WriteLine("Информация о принтере:");
            base.PrintInfo();
            Console.WriteLine($"Скорость печати (строк в минуту): {PrintSpeed}");
        }
    }
}
