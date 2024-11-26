using System;
using System.Windows.Forms;

namespace OfficeEquipmentAppWinForms
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxDeviceType = new System.Windows.Forms.ComboBox();
            this.txtBoxColor = new System.Windows.Forms.TextBox();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.txtBoxPrintSpeedOrResolution = new System.Windows.Forms.TextBox();
            this.btnAddDevice = new System.Windows.Forms.Button();
            this.btnShowDevices = new System.Windows.Forms.Button();
            this.lstBoxDevices = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxDeviceType
            // 
            this.comboBoxDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeviceType.FormattingEnabled = true;
            this.comboBoxDeviceType.Location = new System.Drawing.Point(16, 49);
            this.comboBoxDeviceType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDeviceType.Name = "comboBoxDeviceType";
            this.comboBoxDeviceType.Size = new System.Drawing.Size(265, 24);
            this.comboBoxDeviceType.TabIndex = 0;
            // 
            // txtBoxColor
            // 
            this.txtBoxColor.Location = new System.Drawing.Point(13, 106);
            this.txtBoxColor.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxColor.Name = "txtBoxColor";
            this.txtBoxColor.Size = new System.Drawing.Size(265, 22);
            this.txtBoxColor.TabIndex = 1;
            this.txtBoxColor.TextChanged += new System.EventHandler(this.txtBoxColor_TextChanged);
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(16, 152);
            this.txtBoxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(265, 22);
            this.txtBoxPrice.TabIndex = 2;
            // 
            // txtBoxPrintSpeedOrResolution
            // 
            this.txtBoxPrintSpeedOrResolution.Location = new System.Drawing.Point(16, 198);
            this.txtBoxPrintSpeedOrResolution.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPrintSpeedOrResolution.Name = "txtBoxPrintSpeedOrResolution";
            this.txtBoxPrintSpeedOrResolution.Size = new System.Drawing.Size(265, 22);
            this.txtBoxPrintSpeedOrResolution.TabIndex = 3;
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.Location = new System.Drawing.Point(18, 228);
            this.btnAddDevice.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(267, 28);
            this.btnAddDevice.TabIndex = 4;
            this.btnAddDevice.Text = "Добавить устройство";
            this.btnAddDevice.UseVisualStyleBackColor = true;
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // btnShowDevices
            // 
            this.btnShowDevices.Location = new System.Drawing.Point(18, 264);
            this.btnShowDevices.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowDevices.Name = "btnShowDevices";
            this.btnShowDevices.Size = new System.Drawing.Size(267, 28);
            this.btnShowDevices.TabIndex = 5;
            this.btnShowDevices.Text = "Показать устройства";
            this.btnShowDevices.UseVisualStyleBackColor = true;
            this.btnShowDevices.Click += new System.EventHandler(this.btnShowDevices_Click);
            // 
            // lstBoxDevices
            // 
            this.lstBoxDevices.FormattingEnabled = true;
            this.lstBoxDevices.ItemHeight = 16;
            this.lstBoxDevices.Location = new System.Drawing.Point(18, 300);
            this.lstBoxDevices.Margin = new System.Windows.Forms.Padding(4);
            this.lstBoxDevices.Name = "lstBoxDevices";
            this.lstBoxDevices.Size = new System.Drawing.Size(374, 164);
            this.lstBoxDevices.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Цвет";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Цена";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Скорость печати/разрешение";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Выберите устройство";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 511);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBoxDevices);
            this.Controls.Add(this.btnShowDevices);
            this.Controls.Add(this.btnAddDevice);
            this.Controls.Add(this.txtBoxPrintSpeedOrResolution);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.txtBoxColor);
            this.Controls.Add(this.comboBoxDeviceType);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Office Equipment App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.ComboBox comboBoxDeviceType;
        private System.Windows.Forms.TextBox txtBoxColor;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.TextBox txtBoxPrintSpeedOrResolution;
        private System.Windows.Forms.Button btnAddDevice;
        private System.Windows.Forms.Button btnShowDevices;
        private System.Windows.Forms.ListBox lstBoxDevices;

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}