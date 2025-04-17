namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttnRectangle = new System.Windows.Forms.Button();
            this.bttnLine = new System.Windows.Forms.Button();
            this.bttnEllipse = new System.Windows.Forms.Button();
            this.bttnPolygon = new System.Windows.Forms.Button();
            this.bttnPolylines = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttnSaveToFile = new System.Windows.Forms.Button();
            this.bttnLoadFromFile = new System.Windows.Forms.Button();
            this.bttnForward = new System.Windows.Forms.Button();
            this.bttnBack = new System.Windows.Forms.Button();
            this.bttnAddPlugins = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numUDWidth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBoxFillColor = new System.Windows.Forms.ComboBox();
            this.cmbBoxLineColor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWidth)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnRectangle
            // 
            this.bttnRectangle.Location = new System.Drawing.Point(6, 18);
            this.bttnRectangle.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.bttnRectangle.Name = "bttnRectangle";
            this.bttnRectangle.Size = new System.Drawing.Size(126, 49);
            this.bttnRectangle.TabIndex = 0;
            this.bttnRectangle.Text = "Прямоугольник";
            this.bttnRectangle.UseVisualStyleBackColor = true;
            // 
            // bttnLine
            // 
            this.bttnLine.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnLine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttnLine.Location = new System.Drawing.Point(138, 21);
            this.bttnLine.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.bttnLine.Name = "bttnLine";
            this.bttnLine.Size = new System.Drawing.Size(126, 49);
            this.bttnLine.TabIndex = 1;
            this.bttnLine.Text = "Отрезок";
            this.bttnLine.UseVisualStyleBackColor = false;
            // 
            // bttnEllipse
            // 
            this.bttnEllipse.Location = new System.Drawing.Point(270, 22);
            this.bttnEllipse.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.bttnEllipse.Name = "bttnEllipse";
            this.bttnEllipse.Size = new System.Drawing.Size(126, 49);
            this.bttnEllipse.TabIndex = 2;
            this.bttnEllipse.Text = "Эллипс";
            this.bttnEllipse.UseVisualStyleBackColor = true;
            // 
            // bttnPolygon
            // 
            this.bttnPolygon.Location = new System.Drawing.Point(402, 22);
            this.bttnPolygon.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.bttnPolygon.Name = "bttnPolygon";
            this.bttnPolygon.Size = new System.Drawing.Size(126, 49);
            this.bttnPolygon.TabIndex = 3;
            this.bttnPolygon.Text = "Многоугольник";
            this.bttnPolygon.UseVisualStyleBackColor = true;
            // 
            // bttnPolylines
            // 
            this.bttnPolylines.Location = new System.Drawing.Point(534, 22);
            this.bttnPolylines.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.bttnPolylines.Name = "bttnPolylines";
            this.bttnPolylines.Size = new System.Drawing.Size(126, 49);
            this.bttnPolylines.TabIndex = 4;
            this.bttnPolylines.Text = "Ломаная";
            this.bttnPolylines.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.bttnSaveToFile);
            this.groupBox1.Controls.Add(this.bttnLoadFromFile);
            this.groupBox1.Controls.Add(this.bttnForward);
            this.groupBox1.Controls.Add(this.bttnBack);
            this.groupBox1.Controls.Add(this.bttnRectangle);
            this.groupBox1.Controls.Add(this.bttnPolylines);
            this.groupBox1.Controls.Add(this.bttnPolygon);
            this.groupBox1.Controls.Add(this.bttnLine);
            this.groupBox1.Controls.Add(this.bttnEllipse);
            this.groupBox1.Location = new System.Drawing.Point(34, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.groupBox1.Size = new System.Drawing.Size(694, 182);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // bttnSaveToFile
            // 
            this.bttnSaveToFile.Location = new System.Drawing.Point(162, 77);
            this.bttnSaveToFile.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.bttnSaveToFile.Name = "bttnSaveToFile";
            this.bttnSaveToFile.Size = new System.Drawing.Size(101, 58);
            this.bttnSaveToFile.TabIndex = 9;
            this.bttnSaveToFile.Text = "Сохранить";
            this.bttnSaveToFile.UseVisualStyleBackColor = true;
            this.bttnSaveToFile.Click += new System.EventHandler(this.bttnSaveToFile_Click);
            // 
            // bttnLoadFromFile
            // 
            this.bttnLoadFromFile.Location = new System.Drawing.Point(32, 77);
            this.bttnLoadFromFile.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.bttnLoadFromFile.Name = "bttnLoadFromFile";
            this.bttnLoadFromFile.Size = new System.Drawing.Size(89, 58);
            this.bttnLoadFromFile.TabIndex = 8;
            this.bttnLoadFromFile.Text = "Загрузить";
            this.bttnLoadFromFile.UseVisualStyleBackColor = true;
            this.bttnLoadFromFile.Click += new System.EventHandler(this.bttnLoadFromFile_Click);
            // 
            // bttnForward
            // 
            this.bttnForward.Location = new System.Drawing.Point(543, 81);
            this.bttnForward.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.bttnForward.Name = "bttnForward";
            this.bttnForward.Size = new System.Drawing.Size(74, 49);
            this.bttnForward.TabIndex = 7;
            this.bttnForward.Text = "Вперед";
            this.bttnForward.UseVisualStyleBackColor = true;
            this.bttnForward.Click += new System.EventHandler(this.bttnForward_Click);
            // 
            // bttnBack
            // 
            this.bttnBack.Location = new System.Drawing.Point(471, 81);
            this.bttnBack.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.bttnBack.Name = "bttnBack";
            this.bttnBack.Size = new System.Drawing.Size(66, 49);
            this.bttnBack.TabIndex = 6;
            this.bttnBack.Text = "Назад";
            this.bttnBack.UseVisualStyleBackColor = true;
            this.bttnBack.Click += new System.EventHandler(this.bttnBack_Click);
            // 
            // bttnAddPlugins
            // 
            this.bttnAddPlugins.Location = new System.Drawing.Point(212, 11);
            this.bttnAddPlugins.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.bttnAddPlugins.Name = "bttnAddPlugins";
            this.bttnAddPlugins.Size = new System.Drawing.Size(53, 41);
            this.bttnAddPlugins.TabIndex = 5;
            this.bttnAddPlugins.Text = "+";
            this.bttnAddPlugins.UseVisualStyleBackColor = true;
            this.bttnAddPlugins.Click += new System.EventHandler(this.bttnAddPlugins_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(34, 238);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 426);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1048, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Параметры рисования";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.numUDWidth);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbBoxFillColor);
            this.groupBox2.Controls.Add(this.cmbBoxLineColor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(1051, 47);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.groupBox2.Size = new System.Drawing.Size(309, 119);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // numUDWidth
            // 
            this.numUDWidth.Location = new System.Drawing.Point(9, 37);
            this.numUDWidth.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.numUDWidth.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUDWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDWidth.Name = "numUDWidth";
            this.numUDWidth.Size = new System.Drawing.Size(89, 22);
            this.numUDWidth.TabIndex = 6;
            this.numUDWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUDWidth.ValueChanged += new System.EventHandler(this.numUDWidth_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Цвет заливки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цвет линии";
            // 
            // cmbBoxFillColor
            // 
            this.cmbBoxFillColor.FormattingEnabled = true;
            this.cmbBoxFillColor.Items.AddRange(new object[] {
            "Красный",
            "Желтый",
            "Зеленый",
            "Синий",
            "Фиолетовый",
            "Желтый",
            "Белый"});
            this.cmbBoxFillColor.Location = new System.Drawing.Point(168, 73);
            this.cmbBoxFillColor.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.cmbBoxFillColor.Name = "cmbBoxFillColor";
            this.cmbBoxFillColor.Size = new System.Drawing.Size(121, 24);
            this.cmbBoxFillColor.TabIndex = 3;
            this.cmbBoxFillColor.Text = "Красный";
            this.cmbBoxFillColor.SelectedIndexChanged += new System.EventHandler(this.cmbBoxFillColor_SelectedIndexChanged);
            // 
            // cmbBoxLineColor
            // 
            this.cmbBoxLineColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbBoxLineColor.FormattingEnabled = true;
            this.cmbBoxLineColor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbBoxLineColor.Items.AddRange(new object[] {
            "Красный",
            "Желтый",
            "Зеленый",
            "Синий",
            "Фиолетовый",
            "Желтый"});
            this.cmbBoxLineColor.Location = new System.Drawing.Point(168, 29);
            this.cmbBoxLineColor.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.cmbBoxLineColor.Name = "cmbBoxLineColor";
            this.cmbBoxLineColor.Size = new System.Drawing.Size(121, 24);
            this.cmbBoxLineColor.TabIndex = 2;
            this.cmbBoxLineColor.Text = "Красный";
            this.cmbBoxLineColor.SelectedIndexChanged += new System.EventHandler(this.cmbBoxLineColor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Толщина";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bttnAddPlugins);
            this.groupBox3.Location = new System.Drawing.Point(747, 29);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.groupBox3.Size = new System.Drawing.Size(275, 182);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Фигуры для рисования";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(744, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Плагины";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1382, 713);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1400, 1000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1300, 47);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWidth)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnRectangle;
        private System.Windows.Forms.Button bttnLine;
        private System.Windows.Forms.Button bttnEllipse;
        private System.Windows.Forms.Button bttnPolygon;
        private System.Windows.Forms.Button bttnPolylines;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttnAddPlugins;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbBoxFillColor;
        private System.Windows.Forms.ComboBox cmbBoxLineColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnForward;
        private System.Windows.Forms.Button bttnBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numUDWidth;
        private System.Windows.Forms.Button bttnLoadFromFile;
        private System.Windows.Forms.Button bttnSaveToFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

