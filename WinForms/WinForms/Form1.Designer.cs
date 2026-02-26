namespace WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox_T_L = new TextBox();
            textBox_T_B = new TextBox();
            label4 = new Label();
            textBox_BPLA_B = new TextBox();
            label5 = new Label();
            textBox_BPLA_L = new TextBox();
            textBox_Input_OO2_L = new TextBox();
            textBox_Input_OO2_B = new TextBox();
            label6 = new Label();
            textBox_Input_OO1_L = new TextBox();
            textBox_Input_OO1_B = new TextBox();
            label7 = new Label();
            textBox_Input_L1 = new TextBox();
            label8 = new Label();
            textBox_Input_L2 = new TextBox();
            label9 = new Label();
            textBox_Input_L3 = new TextBox();
            label10 = new Label();
            textBox_Input_a = new TextBox();
            label11 = new Label();
            textBox_Input_aa = new TextBox();
            label12 = new Label();
            label13 = new Label();
            buttonMath = new Button();
            label14 = new Label();
            textBox_Rez_BPLA_Z = new TextBox();
            textBox_Rez_BPLA_L = new TextBox();
            textBox_Rez_T_L = new TextBox();
            textBox_Rez_T_B = new TextBox();
            label15 = new Label();
            textBox_Rez_BPLA_B = new TextBox();
            label16 = new Label();
            textBox_Input_сс = new TextBox();
            label17 = new Label();
            textBox_Rez_BPLA = new TextBox();
            label26 = new Label();
            label27 = new Label();
            textBox_Rez_T = new TextBox();
            textBox_Input_bb = new TextBox();
            label18 = new Label();
            textBox_Input_b = new TextBox();
            label19 = new Label();
            textBox_Rez_T_Z = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, 1);
            label1.Name = "label1";
            label1.Size = new Size(259, 17);
            label1.TabIndex = 0;
            label1.Text = "Действительные координаты по ГНСС:";
            // 
            // textBox_T_L
            // 
            textBox_T_L.Location = new Point(305, 51);
            textBox_T_L.Margin = new Padding(3, 2, 3, 2);
            textBox_T_L.Name = "textBox_T_L";
            textBox_T_L.PlaceholderText = "Долгота°";
            textBox_T_L.Size = new Size(169, 23);
            textBox_T_L.TabIndex = 12;
            // 
            // textBox_T_B
            // 
            textBox_T_B.Location = new Point(67, 51);
            textBox_T_B.Margin = new Padding(3, 2, 3, 2);
            textBox_T_B.Name = "textBox_T_B";
            textBox_T_B.PlaceholderText = "Широта°";
            textBox_T_B.Size = new Size(184, 23);
            textBox_T_B.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point(4, 54);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 10;
            label4.Text = "ОБЪЕКТ:";
            label4.Click += label4_Click;
            // 
            // textBox_BPLA_B
            // 
            textBox_BPLA_B.Location = new Point(66, 24);
            textBox_BPLA_B.Margin = new Padding(3, 2, 3, 2);
            textBox_BPLA_B.Name = "textBox_BPLA_B";
            textBox_BPLA_B.PlaceholderText = "Широта°";
            textBox_BPLA_B.Size = new Size(185, 23);
            textBox_BPLA_B.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point(5, 27);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 7;
            label5.Text = "БПЛА:";
            label5.Click += label5_Click;
            // 
            // textBox_BPLA_L
            // 
            textBox_BPLA_L.Location = new Point(305, 24);
            textBox_BPLA_L.Margin = new Padding(3, 2, 3, 2);
            textBox_BPLA_L.Name = "textBox_BPLA_L";
            textBox_BPLA_L.PlaceholderText = "Долгота°";
            textBox_BPLA_L.Size = new Size(169, 23);
            textBox_BPLA_L.TabIndex = 13;
            // 
            // textBox_Input_OO2_L
            // 
            textBox_Input_OO2_L.Location = new Point(305, 130);
            textBox_Input_OO2_L.Margin = new Padding(3, 2, 3, 2);
            textBox_Input_OO2_L.Name = "textBox_Input_OO2_L";
            textBox_Input_OO2_L.PlaceholderText = "Долгота°";
            textBox_Input_OO2_L.Size = new Size(169, 23);
            textBox_Input_OO2_L.TabIndex = 21;
            // 
            // textBox_Input_OO2_B
            // 
            textBox_Input_OO2_B.Location = new Point(66, 127);
            textBox_Input_OO2_B.Margin = new Padding(3, 2, 3, 2);
            textBox_Input_OO2_B.Name = "textBox_Input_OO2_B";
            textBox_Input_OO2_B.PlaceholderText = "Широта°";
            textBox_Input_OO2_B.Size = new Size(185, 23);
            textBox_Input_OO2_B.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label6.Location = new Point(10, 130);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 19;
            label6.Text = "ОО2:";
            label6.Click += label6_Click;
            // 
            // textBox_Input_OO1_L
            // 
            textBox_Input_OO1_L.Location = new Point(305, 101);
            textBox_Input_OO1_L.Margin = new Padding(3, 2, 3, 2);
            textBox_Input_OO1_L.Name = "textBox_Input_OO1_L";
            textBox_Input_OO1_L.PlaceholderText = "Долгота°";
            textBox_Input_OO1_L.Size = new Size(169, 23);
            textBox_Input_OO1_L.TabIndex = 18;
            // 
            // textBox_Input_OO1_B
            // 
            textBox_Input_OO1_B.Location = new Point(66, 100);
            textBox_Input_OO1_B.Margin = new Padding(3, 2, 3, 2);
            textBox_Input_OO1_B.Name = "textBox_Input_OO1_B";
            textBox_Input_OO1_B.PlaceholderText = "Широта°";
            textBox_Input_OO1_B.Size = new Size(185, 23);
            textBox_Input_OO1_B.TabIndex = 17;
            textBox_Input_OO1_B.Tag = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label7.Location = new Point(11, 104);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 16;
            label7.Text = "ОО1:";
            label7.Click += label7_Click;
            // 
            // textBox_Input_L1
            // 
            textBox_Input_L1.Location = new Point(66, 178);
            textBox_Input_L1.Margin = new Padding(3, 2, 3, 2);
            textBox_Input_L1.Name = "textBox_Input_L1";
            textBox_Input_L1.PlaceholderText = "метры";
            textBox_Input_L1.Size = new Size(185, 23);
            textBox_Input_L1.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label8.Location = new Point(14, 181);
            label8.Name = "label8";
            label8.Size = new Size(22, 15);
            label8.TabIndex = 22;
            label8.Text = "L1:";
            label8.Click += label8_Click;
            // 
            // textBox_Input_L2
            // 
            textBox_Input_L2.Location = new Point(67, 207);
            textBox_Input_L2.Margin = new Padding(3, 2, 3, 2);
            textBox_Input_L2.Name = "textBox_Input_L2";
            textBox_Input_L2.PlaceholderText = "метры";
            textBox_Input_L2.Size = new Size(184, 23);
            textBox_Input_L2.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label9.Location = new Point(14, 208);
            label9.Name = "label9";
            label9.Size = new Size(22, 15);
            label9.TabIndex = 24;
            label9.Text = "L2:";
            label9.Click += label9_Click;
            // 
            // textBox_Input_L3
            // 
            textBox_Input_L3.Location = new Point(66, 234);
            textBox_Input_L3.Margin = new Padding(3, 2, 3, 2);
            textBox_Input_L3.Name = "textBox_Input_L3";
            textBox_Input_L3.PlaceholderText = "метры";
            textBox_Input_L3.Size = new Size(185, 23);
            textBox_Input_L3.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label10.Location = new Point(14, 234);
            label10.Name = "label10";
            label10.Size = new Size(22, 15);
            label10.TabIndex = 26;
            label10.Text = "L3:";
            label10.Click += label10_Click;
            // 
            // textBox_Input_a
            // 
            textBox_Input_a.Location = new Point(66, 261);
            textBox_Input_a.Margin = new Padding(3, 2, 3, 2);
            textBox_Input_a.Name = "textBox_Input_a";
            textBox_Input_a.PlaceholderText = "градусы";
            textBox_Input_a.Size = new Size(185, 23);
            textBox_Input_a.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label11.Location = new Point(12, 264);
            label11.Name = "label11";
            label11.Size = new Size(33, 15);
            label11.TabIndex = 28;
            label11.Text = "∠φ1:";
            label11.Click += label11_Click;
            // 
            // textBox_Input_aa
            // 
            textBox_Input_aa.Location = new Point(305, 181);
            textBox_Input_aa.Margin = new Padding(3, 2, 3, 2);
            textBox_Input_aa.Name = "textBox_Input_aa";
            textBox_Input_aa.PlaceholderText = "градусы";
            textBox_Input_aa.Size = new Size(169, 23);
            textBox_Input_aa.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label12.Location = new Point(268, 184);
            label12.Name = "label12";
            label12.Size = new Size(31, 15);
            label12.TabIndex = 30;
            label12.Text = "∠α1:";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(7, 81);
            label13.Name = "label13";
            label13.Size = new Size(275, 17);
            label13.TabIndex = 32;
            label13.Text = "Координаты опорных объектов по ГНСС:";
            // 
            // buttonMath
            // 
            buttonMath.Location = new Point(4, 291);
            buttonMath.Margin = new Padding(3, 2, 3, 2);
            buttonMath.Name = "buttonMath";
            buttonMath.Size = new Size(470, 22);
            buttonMath.TabIndex = 33;
            buttonMath.Text = "Найти";
            buttonMath.UseVisualStyleBackColor = true;
            buttonMath.Click += button2_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(7, 315);
            label14.Name = "label14";
            label14.Size = new Size(292, 17);
            label14.TabIndex = 34;
            label14.Text = "Рассчитанные координаты БПЛА и объекта:";
            // 
            // textBox_Rez_BPLA_Z
            // 
            textBox_Rez_BPLA_Z.Location = new Point(342, 334);
            textBox_Rez_BPLA_Z.Margin = new Padding(3, 2, 3, 2);
            textBox_Rez_BPLA_Z.Name = "textBox_Rez_BPLA_Z";
            textBox_Rez_BPLA_Z.PlaceholderText = "М";
            textBox_Rez_BPLA_Z.ReadOnly = true;
            textBox_Rez_BPLA_Z.Size = new Size(132, 23);
            textBox_Rez_BPLA_Z.TabIndex = 42;
            // 
            // textBox_Rez_BPLA_L
            // 
            textBox_Rez_BPLA_L.Location = new Point(205, 334);
            textBox_Rez_BPLA_L.Margin = new Padding(3, 2, 3, 2);
            textBox_Rez_BPLA_L.Name = "textBox_Rez_BPLA_L";
            textBox_Rez_BPLA_L.PlaceholderText = "Долгота°";
            textBox_Rez_BPLA_L.ReadOnly = true;
            textBox_Rez_BPLA_L.Size = new Size(132, 23);
            textBox_Rez_BPLA_L.TabIndex = 41;
            // 
            // textBox_Rez_T_L
            // 
            textBox_Rez_T_L.Location = new Point(205, 361);
            textBox_Rez_T_L.Margin = new Padding(3, 2, 3, 2);
            textBox_Rez_T_L.Name = "textBox_Rez_T_L";
            textBox_Rez_T_L.PlaceholderText = "Долгота°";
            textBox_Rez_T_L.ReadOnly = true;
            textBox_Rez_T_L.Size = new Size(132, 23);
            textBox_Rez_T_L.TabIndex = 40;
            // 
            // textBox_Rez_T_B
            // 
            textBox_Rez_T_B.Location = new Point(69, 361);
            textBox_Rez_T_B.Margin = new Padding(3, 2, 3, 2);
            textBox_Rez_T_B.Name = "textBox_Rez_T_B";
            textBox_Rez_T_B.PlaceholderText = "Широта°";
            textBox_Rez_T_B.ReadOnly = true;
            textBox_Rez_T_B.Size = new Size(132, 23);
            textBox_Rez_T_B.TabIndex = 39;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(7, 361);
            label15.Name = "label15";
            label15.Size = new Size(54, 15);
            label15.TabIndex = 38;
            label15.Text = "ОБЪЕКТ:";
            // 
            // textBox_Rez_BPLA_B
            // 
            textBox_Rez_BPLA_B.Location = new Point(69, 334);
            textBox_Rez_BPLA_B.Margin = new Padding(3, 2, 3, 2);
            textBox_Rez_BPLA_B.Name = "textBox_Rez_BPLA_B";
            textBox_Rez_BPLA_B.PlaceholderText = "Широта°";
            textBox_Rez_BPLA_B.ReadOnly = true;
            textBox_Rez_BPLA_B.Size = new Size(132, 23);
            textBox_Rez_BPLA_B.TabIndex = 36;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(5, 337);
            label16.Name = "label16";
            label16.Size = new Size(42, 15);
            label16.TabIndex = 35;
            label16.Text = "БПЛА:";
            // 
            // textBox_Input_сс
            // 
            textBox_Input_сс.Location = new Point(305, 235);
            textBox_Input_сс.Margin = new Padding(3, 2, 3, 2);
            textBox_Input_сс.Name = "textBox_Input_сс";
            textBox_Input_сс.PlaceholderText = "градусы";
            textBox_Input_сс.Size = new Size(169, 23);
            textBox_Input_сс.TabIndex = 43;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label17.Location = new Point(267, 238);
            label17.Name = "label17";
            label17.Size = new Size(32, 15);
            label17.TabIndex = 44;
            label17.Text = "∠αT:";
            label17.Click += label17_Click;
            // 
            // textBox_Rez_BPLA
            // 
            textBox_Rez_BPLA.Location = new Point(10, 431);
            textBox_Rez_BPLA.Margin = new Padding(3, 2, 3, 2);
            textBox_Rez_BPLA.Name = "textBox_Rez_BPLA";
            textBox_Rez_BPLA.PlaceholderText = "РАССТОЯНИЕ";
            textBox_Rez_BPLA.ReadOnly = true;
            textBox_Rez_BPLA.Size = new Size(464, 23);
            textBox_Rez_BPLA.TabIndex = 65;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(10, 414);
            label26.Name = "label26";
            label26.Size = new Size(168, 15);
            label26.TabIndex = 66;
            label26.Text = "Погрешность БПЛА в метрах";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(10, 459);
            label27.Name = "label27";
            label27.Size = new Size(180, 15);
            label27.TabIndex = 68;
            label27.Text = "Погрешность объекта в метрах";
            // 
            // textBox_Rez_T
            // 
            textBox_Rez_T.Location = new Point(10, 476);
            textBox_Rez_T.Margin = new Padding(3, 2, 3, 2);
            textBox_Rez_T.Name = "textBox_Rez_T";
            textBox_Rez_T.PlaceholderText = "РАССТОЯНИЕ";
            textBox_Rez_T.ReadOnly = true;
            textBox_Rez_T.Size = new Size(464, 23);
            textBox_Rez_T.TabIndex = 67;
            // 
            // textBox_Input_bb
            // 
            textBox_Input_bb.Location = new Point(305, 208);
            textBox_Input_bb.Margin = new Padding(3, 2, 3, 2);
            textBox_Input_bb.Name = "textBox_Input_bb";
            textBox_Input_bb.PlaceholderText = "градусы";
            textBox_Input_bb.Size = new Size(169, 23);
            textBox_Input_bb.TabIndex = 98;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label18.Location = new Point(268, 211);
            label18.Name = "label18";
            label18.Size = new Size(31, 15);
            label18.TabIndex = 97;
            label18.Text = "∠α2:";
            label18.Click += label18_Click;
            // 
            // textBox_Input_b
            // 
            textBox_Input_b.Location = new Point(305, 264);
            textBox_Input_b.Margin = new Padding(3, 2, 3, 2);
            textBox_Input_b.Name = "textBox_Input_b";
            textBox_Input_b.PlaceholderText = "градусы";
            textBox_Input_b.Size = new Size(169, 23);
            textBox_Input_b.TabIndex = 96;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label19.Location = new Point(266, 269);
            label19.Name = "label19";
            label19.Size = new Size(33, 15);
            label19.TabIndex = 95;
            label19.Text = "∠φ2:";
            label19.Click += label19_Click;
            // 
            // textBox_Rez_T_Z
            // 
            textBox_Rez_T_Z.Location = new Point(342, 361);
            textBox_Rez_T_Z.Margin = new Padding(3, 2, 3, 2);
            textBox_Rez_T_Z.Name = "textBox_Rez_T_Z";
            textBox_Rez_T_Z.PlaceholderText = "М";
            textBox_Rez_T_Z.ReadOnly = true;
            textBox_Rez_T_Z.Size = new Size(132, 23);
            textBox_Rez_T_Z.TabIndex = 101;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(7, 162);
            label2.Name = "label2";
            label2.Size = new Size(158, 17);
            label2.TabIndex = 102;
            label2.Text = "Результаты измерений:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(7, 386);
            label3.Name = "label3";
            label3.Size = new Size(363, 17);
            label3.TabIndex = 103;
            label3.Text = "Погрешность определения координат БПЛА и объекта:\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 515);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox_Rez_T_Z);
            Controls.Add(textBox_Input_bb);
            Controls.Add(label18);
            Controls.Add(textBox_Input_b);
            Controls.Add(label19);
            Controls.Add(label27);
            Controls.Add(textBox_Rez_T);
            Controls.Add(label26);
            Controls.Add(textBox_Rez_BPLA);
            Controls.Add(label17);
            Controls.Add(textBox_Input_сс);
            Controls.Add(textBox_Rez_BPLA_Z);
            Controls.Add(textBox_Rez_BPLA_L);
            Controls.Add(textBox_Rez_T_L);
            Controls.Add(textBox_Rez_T_B);
            Controls.Add(label15);
            Controls.Add(textBox_Rez_BPLA_B);
            Controls.Add(label16);
            Controls.Add(label14);
            Controls.Add(buttonMath);
            Controls.Add(label13);
            Controls.Add(textBox_Input_aa);
            Controls.Add(label12);
            Controls.Add(textBox_Input_a);
            Controls.Add(label11);
            Controls.Add(textBox_Input_L3);
            Controls.Add(label10);
            Controls.Add(textBox_Input_L2);
            Controls.Add(label9);
            Controls.Add(textBox_Input_L1);
            Controls.Add(label8);
            Controls.Add(textBox_Input_OO2_L);
            Controls.Add(textBox_Input_OO2_B);
            Controls.Add(label6);
            Controls.Add(textBox_Input_OO1_L);
            Controls.Add(textBox_Input_OO1_B);
            Controls.Add(label7);
            Controls.Add(textBox_BPLA_L);
            Controls.Add(textBox_T_L);
            Controls.Add(textBox_T_B);
            Controls.Add(label4);
            Controls.Add(textBox_BPLA_B);
            Controls.Add(label5);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Форма для тестирования";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox_T_L;
        private TextBox textBox_T_B;
        private Label label4;
        private TextBox textBox_BPLA_B;
        private Label label5;
        private TextBox textBox_BPLA_L;
        private TextBox textBox_Input_OO2_L;
        private TextBox textBox_Input_OO2_B;
        private Label label6;
        private TextBox textBox_Input_OO1_L;
        private TextBox textBox_Input_OO1_B;
        private Label label7;
        private TextBox textBox_Input_L1;
        private Label label8;
        private TextBox textBox_Input_L2;
        private Label label9;
        private TextBox textBox_Input_L3;
        private Label label10;
        private TextBox textBox_Input_a;
        private Label label11;
        private TextBox textBox_Input_aa;
        private Label label12;
        private Label label13;
        private Button buttonMath;
        private Label label14;
        private TextBox textBox_Rez_BPLA_Z;
        private TextBox textBox_Rez_BPLA_L;
        private TextBox textBox_Rez_T_L;
        private TextBox textBox_Rez_T_B;
        private Label label15;
        private TextBox textBox_Rez_BPLA_B;
        private Label label16;
        private TextBox textBox_Input_сс;
        private Label label17;
        private TextBox textBox_Rez_BPLA;
        private Label label26;
        private Label label27;
        private TextBox textBox_Rez_T;
        private TextBox textBox_Input_bb;
        private Label label18;
        private TextBox textBox_Input_b;
        private Label label19;
        private TextBox textBox_Rez_T_Z;
        private Label label2;
        private Label label3;
    }
}