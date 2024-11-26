using System;
using OfficeEquipmentApp;

namespace OfficeEquipmentApp
{
    public class Scanner : OfficeEquipment
    {
        // Поле для разрешения
        private int resolution;

        // Свойство для разрешения
        public int Resolution
        {
            get { return resolution; }
            set { resolution = (value < 0) ? 0 : value; }
        }

        // Конструктор
        public Scanner(string color = "", int price = 0, int resolution = 0) : base(color, price)
        {
            Resolution = resolution;
        }

        // Метод для вывода информации
        public override void PrintInfo()
        {
            Console.WriteLine("Информация о сканере:");
            base.PrintInfo();
            Console.WriteLine($"Разрешение (dpi): {Resolution}");
        }
    }
}
