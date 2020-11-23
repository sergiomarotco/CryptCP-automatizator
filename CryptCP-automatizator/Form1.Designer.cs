namespace CryptCP_automatizator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button22 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.file_to_decrypt = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FileName_Decrypted = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Work_folder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button23 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.file_to_unsign = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.FileName_UnSigned = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button24 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.file_to_encrypt = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.FileName_Encrypted = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button25 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.file_to_sign = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.FileName_Signed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.My_Cert = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.CryptCP_folder = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button12 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Расшифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Decrypt);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.button30);
            this.panel1.Controls.Add(this.button26);
            this.panel1.Controls.Add(this.button22);
            this.panel1.Controls.Add(this.button17);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.file_to_decrypt);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.FileName_Decrypted);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 100);
            this.panel1.TabIndex = 1;
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel1_DragEnter);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(634, 41);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(96, 43);
            this.button22.TabIndex = 21;
            this.button22.Text = "Копировать конечный";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(540, 41);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(88, 43);
            this.button17.TabIndex = 20;
            this.button17.Text = "Показать конечный";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(322, 41);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(112, 43);
            this.button13.TabIndex = 19;
            this.button13.Text = "Показать исходный";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // file_to_decrypt
            // 
            this.file_to_decrypt.AutoSize = true;
            this.file_to_decrypt.Location = new System.Drawing.Point(188, 11);
            this.file_to_decrypt.Name = "file_to_decrypt";
            this.file_to_decrypt.Size = new System.Drawing.Size(0, 17);
            this.file_to_decrypt.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(837, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 7;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1046, 41);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(89, 42);
            this.button8.TabIndex = 6;
            this.button8.Text = "Очистить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя файла на выходе";
            // 
            // FileName_Decrypted
            // 
            this.FileName_Decrypted.Location = new System.Drawing.Point(6, 61);
            this.FileName_Decrypted.Name = "FileName_Decrypted";
            this.FileName_Decrypted.Size = new System.Drawing.Size(179, 22);
            this.FileName_Decrypted.TabIndex = 3;
            this.FileName_Decrypted.TextChanged += new System.EventHandler(this.FileName_Decrypted_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Расшифрование";
            // 
            // Work_folder
            // 
            this.Work_folder.Location = new System.Drawing.Point(168, 3);
            this.Work_folder.Name = "Work_folder";
            this.Work_folder.Size = new System.Drawing.Size(718, 22);
            this.Work_folder.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Рабочая папка";
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.button31);
            this.panel2.Controls.Add(this.button27);
            this.panel2.Controls.Add(this.button23);
            this.panel2.Controls.Add(this.button18);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Controls.Add(this.file_to_unsign);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.FileName_UnSigned);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(12, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1135, 100);
            this.panel2.TabIndex = 5;
            this.panel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel2_DragEnter);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(634, 40);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(96, 42);
            this.button23.TabIndex = 22;
            this.button23.Text = "Копировать конечный";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(540, 41);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(88, 43);
            this.button18.TabIndex = 21;
            this.button18.Text = "Показать конечный";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(322, 40);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(112, 42);
            this.button14.TabIndex = 20;
            this.button14.Text = "Показать исходный";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // file_to_unsign
            // 
            this.file_to_unsign.AutoSize = true;
            this.file_to_unsign.Location = new System.Drawing.Point(188, 11);
            this.file_to_unsign.Name = "file_to_unsign";
            this.file_to_unsign.Size = new System.Drawing.Size(0, 17);
            this.file_to_unsign.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(837, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 8;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1046, 41);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(89, 43);
            this.button9.TabIndex = 6;
            this.button9.Text = "Очистить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Имя файла на выходе";
            // 
            // FileName_UnSigned
            // 
            this.FileName_UnSigned.Location = new System.Drawing.Point(6, 61);
            this.FileName_UnSigned.Name = "FileName_UnSigned";
            this.FileName_UnSigned.Size = new System.Drawing.Size(179, 22);
            this.FileName_UnSigned.TabIndex = 3;
            this.FileName_UnSigned.TextChanged += new System.EventHandler(this.FileName_UnSigned_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Проверка подписи";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 43);
            this.button2.TabIndex = 0;
            this.button2.Text = "Проверить подпись";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Verify);
            // 
            // panel3
            // 
            this.panel3.AllowDrop = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.button32);
            this.panel3.Controls.Add(this.button28);
            this.panel3.Controls.Add(this.button24);
            this.panel3.Controls.Add(this.button19);
            this.panel3.Controls.Add(this.button15);
            this.panel3.Controls.Add(this.file_to_encrypt);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.FileName_Encrypted);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(12, 298);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1135, 100);
            this.panel3.TabIndex = 6;
            this.panel3.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel3_DragEnter);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(634, 40);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(96, 43);
            this.button24.TabIndex = 23;
            this.button24.Text = "Копировать конечный";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(540, 41);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(88, 43);
            this.button19.TabIndex = 22;
            this.button19.Text = "Показать конечный";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(322, 40);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(112, 43);
            this.button15.TabIndex = 21;
            this.button15.Text = "Показать исходный";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // file_to_encrypt
            // 
            this.file_to_encrypt.AutoSize = true;
            this.file_to_encrypt.Location = new System.Drawing.Point(188, 11);
            this.file_to_encrypt.Name = "file_to_encrypt";
            this.file_to_encrypt.Size = new System.Drawing.Size(0, 17);
            this.file_to_encrypt.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Location = new System.Drawing.Point(837, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 100);
            this.panel7.TabIndex = 8;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1043, 41);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(89, 42);
            this.button10.TabIndex = 6;
            this.button10.Text = "Очистить";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;
            this.button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Имя файла на выходе";
            // 
            // FileName_Encrypted
            // 
            this.FileName_Encrypted.Location = new System.Drawing.Point(6, 61);
            this.FileName_Encrypted.Name = "FileName_Encrypted";
            this.FileName_Encrypted.Size = new System.Drawing.Size(179, 22);
            this.FileName_Encrypted.TabIndex = 3;
            this.FileName_Encrypted.TextChanged += new System.EventHandler(this.FileName_Encrypted_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Шифрование";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(191, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 43);
            this.button3.TabIndex = 0;
            this.button3.Text = "Зашифровать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Encrypt);
            // 
            // panel4
            // 
            this.panel4.AllowDrop = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.button33);
            this.panel4.Controls.Add(this.button29);
            this.panel4.Controls.Add(this.button25);
            this.panel4.Controls.Add(this.button20);
            this.panel4.Controls.Add(this.button16);
            this.panel4.Controls.Add(this.file_to_sign);
            this.panel4.Controls.Add(this.button11);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.FileName_Signed);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Location = new System.Drawing.Point(12, 404);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1135, 100);
            this.panel4.TabIndex = 7;
            this.panel4.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel4_DragEnter);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(634, 40);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(96, 43);
            this.button25.TabIndex = 24;
            this.button25.Text = "Копировать конечный";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(540, 40);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(88, 42);
            this.button20.TabIndex = 23;
            this.button20.Text = "Показать конечный";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(322, 40);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(112, 42);
            this.button16.TabIndex = 22;
            this.button16.Text = "Показать исходный";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // file_to_sign
            // 
            this.file_to_sign.AutoSize = true;
            this.file_to_sign.Location = new System.Drawing.Point(188, 11);
            this.file_to_sign.Name = "file_to_sign";
            this.file_to_sign.Size = new System.Drawing.Size(0, 17);
            this.file_to_sign.TabIndex = 5;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(1043, 41);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(89, 42);
            this.button11.TabIndex = 6;
            this.button11.Text = "Очистить";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Visible = false;
            this.button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Имя файла на выходе";
            // 
            // FileName_Signed
            // 
            this.FileName_Signed.Location = new System.Drawing.Point(6, 61);
            this.FileName_Signed.Name = "FileName_Signed";
            this.FileName_Signed.Size = new System.Drawing.Size(179, 22);
            this.FileName_Signed.TabIndex = 3;
            this.FileName_Signed.TextChanged += new System.EventHandler(this.FileName_Signed_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Подписание";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(191, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 43);
            this.button4.TabIndex = 0;
            this.button4.Text = "Подписать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Sign);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Location = new System.Drawing.Point(849, 404);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 100);
            this.panel8.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(9, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Сертификат КПЭП";
            // 
            // My_Cert
            // 
            this.My_Cert.Location = new System.Drawing.Point(168, 58);
            this.My_Cert.Name = "My_Cert";
            this.My_Cert.Size = new System.Drawing.Size(718, 22);
            this.My_Cert.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(892, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Выбрать";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(892, 58);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Выбрать";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(9, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Путь до CryptCP";
            // 
            // CryptCP_folder
            // 
            this.CryptCP_folder.Location = new System.Drawing.Point(168, 30);
            this.CryptCP_folder.Name = "CryptCP_folder";
            this.CryptCP_folder.Size = new System.Drawing.Size(718, 22);
            this.CryptCP_folder.TabIndex = 3;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(892, 32);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "Выбрать";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1097, 6);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(50, 17);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Author";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(1000, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(91, 23);
            this.button12.TabIndex = 18;
            this.button12.Text = "Открыть";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Button12_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(1000, 32);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(91, 23);
            this.button21.TabIndex = 19;
            this.button21.Text = "Открыть";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(736, 41);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(89, 43);
            this.button26.TabIndex = 22;
            this.button26.Text = "Удалить конечный";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(736, 40);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(89, 43);
            this.button27.TabIndex = 23;
            this.button27.Text = "Удалить конечный";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(736, 41);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(89, 43);
            this.button28.TabIndex = 24;
            this.button28.Text = "Удалить конечный";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(736, 41);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(89, 43);
            this.button29.TabIndex = 25;
            this.button29.Text = "Удалить конечный";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(443, 41);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(89, 43);
            this.button30.TabIndex = 23;
            this.button30.Text = "Удалить исходный";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(443, 39);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(89, 43);
            this.button31.TabIndex = 24;
            this.button31.Text = "Удалить исходный";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(443, 41);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(89, 43);
            this.button32.TabIndex = 25;
            this.button32.Text = "Удалить исходный";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(443, 39);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(89, 43);
            this.button33.TabIndex = 26;
            this.button33.Text = "Удалить исходный";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 513);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CryptCP_folder);
            this.Controls.Add(this.My_Cert);
            this.Controls.Add(this.Work_folder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1177, 560);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CryptCP автоматизатор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FileName_Decrypted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Work_folder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FileName_UnSigned;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FileName_Encrypted;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox FileName_Signed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox My_Cert;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CryptCP_folder;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label file_to_sign;
        private System.Windows.Forms.Label file_to_unsign;
        private System.Windows.Forms.Label file_to_decrypt;
        private System.Windows.Forms.Label file_to_encrypt;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
    }
}

