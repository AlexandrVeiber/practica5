using System;

namespace OfficeEquipmentApp
{
    public class OfficeEquipment
    {
        private int price; // Поле для хранения цены
        public string Color { get; set; } // Свойство для цвета

        public int Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Цена не может быть отрицательной.");
                price = value;
            }
        }

        public OfficeEquipment(string color = "", int price = 0)
        {
            Color = color;
            Price = price; // Здесь будет проверка
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Цвет: {Color}");
            Console.WriteLine($"Цена (Руб.): {Price}");
        }
    }
}

