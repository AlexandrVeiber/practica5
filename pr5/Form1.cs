using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using OfficeEquipmentApp;

namespace OfficeEquipmentAppWinForms
{
    public partial class Form1 : Form
    {
        private List<OfficeEquipment> equipmentList = new List<OfficeEquipment>();

        public Form1()
        {
            InitializeComponent();
            comboBoxDeviceType.Items.Add("Принтер");
            comboBoxDeviceType.Items.Add("Сканер");
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            int type = comboBoxDeviceType.SelectedIndex;
            string color = txtBoxColor.Text;

            // Проверка, что цвет состоит только из букв
            if (!IsAlphabetic(color))
            {
                MessageBox.Show("Цвет должен содержать только буквы.");
                return;
            }

            if (!int.TryParse(txtBoxPrice.Text, out int price) || price < 0)
            {
                MessageBox.Show("Некорректный ввод цены. Цена не может быть отрицательной.");
                return;
            }

            OfficeEquipment newDevice = null;

            if (type == 0) // Принтер
            {
                if (!int.TryParse(txtBoxPrintSpeedOrResolution.Text, out int printSpeed) || printSpeed < 0)
                {
                    MessageBox.Show("Некорректный ввод скорости печати. Скорость не может быть отрицательной.");
                    return;
                }
                newDevice = new Printer(color, price, printSpeed);
            }
            else if (type == 1) // Сканер
            {
                if (!int.TryParse(txtBoxPrintSpeedOrResolution.Text, out int resolution) || resolution < 0)
                {
                    MessageBox.Show("Некорректный ввод разрешения. Разрешение не может быть отрицательным.");
                    return;
                }
                newDevice = new Scanner(color, price, resolution);
            }
            else
            {
                MessageBox.Show("Неверный тип устройства.");
                return;
            }

            if (newDevice != null)
            {
                equipmentList.Add(newDevice);
                MessageBox.Show("Устройство добавлено в список.");
            }
        }

        private void btnShowDevices_Click(object sender, EventArgs e)
        {
            lstBoxDevices.Items.Clear();
            foreach (var device in equipmentList)
            {
                string additionalInfo = device is Printer ? $"Скорость печати: {((Printer)device).PrintSpeed}"
                                                            : $"Разрешение: {((Scanner)device).Resolution}";
                lstBoxDevices.Items.Add($"{device.GetType().Name}: Цвет: {device.Color}, Цена: {device.Price}, {additionalInfo}");
            }
        }

        private void txtBoxColor_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // Метод для проверки, что строка состоит только из букв
        private bool IsAlphabetic(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Zа-яА-ЯёЁ]+$");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}