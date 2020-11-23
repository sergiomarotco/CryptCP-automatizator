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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button30 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.file_to_decrypt = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.Work_folder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button31 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.file_to_unsign = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button32 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.file_to_encrypt = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button33 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.file_to_sign = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.My_Cert = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.CryptCP_folder = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip9 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip10 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip11 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip12 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip13 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 42);
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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 71);
            this.panel1.TabIndex = 1;
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel1_DragEnter);
            // 
            // button30
            // 
            this.button30.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button30.BackgroundImage")));
            this.button30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button30.Location = new System.Drawing.Point(57, 8);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(32, 32);
            this.button30.TabIndex = 23;
            this.toolTip3.SetToolTip(this.button30, "Удалить исходный файл");
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button26
            // 
            this.button26.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button26.BackgroundImage")));
            this.button26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button26.Location = new System.Drawing.Point(313, 9);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(32, 32);
            this.button26.TabIndex = 22;
            this.toolTip5.SetToolTip(this.button26, "Удалить конечный файл");
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button22
            // 
            this.button22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button22.BackgroundImage")));
            this.button22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button22.Location = new System.Drawing.Point(275, 9);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(32, 32);
            this.button22.TabIndex = 21;
            this.toolTip4.SetToolTip(this.button22, "Копировать конечный файл в буфер обмена");
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button17
            // 
            this.button17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button17.BackgroundImage")));
            this.button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button17.Location = new System.Drawing.Point(237, 9);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(32, 32);
            this.button17.TabIndex = 20;
            this.toolTip1.SetToolTip(this.button17, "Открыть папку с конечным файлом");
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button13
            // 
            this.button13.AccessibleDescription = "Открыть исходный файл";
            this.button13.Image = global::CryptCP_automatizator.Properties.Resources.open;
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(19, 9);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(32, 32);
            this.button13.TabIndex = 19;
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip2.SetToolTip(this.button13, "Открыть папку с исходным файлом");
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // file_to_decrypt
            // 
            this.file_to_decrypt.AutoSize = true;
            this.file_to_decrypt.Location = new System.Drawing.Point(10, 45);
            this.file_to_decrypt.Name = "file_to_decrypt";
            this.file_to_decrypt.Size = new System.Drawing.Size(0, 17);
            this.file_to_decrypt.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(748, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 71);
            this.panel5.TabIndex = 7;
            this.toolTip13.SetToolTip(this.panel5, "Перетащите сюда файл для обработки");
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Location = new System.Drawing.Point(978, 32);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(32, 32);
            this.button8.TabIndex = 6;
            this.toolTip11.SetToolTip(this.button8, "Очистить пути до конечных файлов");
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Work_folder
            // 
            this.Work_folder.Location = new System.Drawing.Point(168, 8);
            this.Work_folder.Name = "Work_folder";
            this.Work_folder.Size = new System.Drawing.Size(718, 22);
            this.Work_folder.TabIndex = 3;
            this.Work_folder.TextChanged += new System.EventHandler(this.Work_folder_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 11);
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
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(12, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 71);
            this.panel2.TabIndex = 5;
            this.panel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel2_DragEnter);
            // 
            // button31
            // 
            this.button31.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button31.BackgroundImage")));
            this.button31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button31.Location = new System.Drawing.Point(57, 8);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(32, 32);
            this.button31.TabIndex = 24;
            this.toolTip3.SetToolTip(this.button31, "Удалить исходный файл");
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button27
            // 
            this.button27.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button27.BackgroundImage")));
            this.button27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button27.Location = new System.Drawing.Point(313, 7);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(32, 32);
            this.button27.TabIndex = 23;
            this.toolTip5.SetToolTip(this.button27, "Удалить конечный файл");
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button23
            // 
            this.button23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button23.BackgroundImage")));
            this.button23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button23.Location = new System.Drawing.Point(275, 7);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(32, 32);
            this.button23.TabIndex = 22;
            this.toolTip4.SetToolTip(this.button23, "Копировать конечный файл в буфер обмена");
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button18
            // 
            this.button18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button18.BackgroundImage")));
            this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button18.Location = new System.Drawing.Point(237, 8);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(32, 32);
            this.button18.TabIndex = 21;
            this.toolTip1.SetToolTip(this.button18, "Открыть папку с конечным файлом");
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button14
            // 
            this.button14.AccessibleDescription = "Открыть исходный файл";
            this.button14.Image = ((System.Drawing.Image)(resources.GetObject("button14.Image")));
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(19, 8);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(32, 32);
            this.button14.TabIndex = 20;
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip2.SetToolTip(this.button14, "Открыть папку с исходным файлом");
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // file_to_unsign
            // 
            this.file_to_unsign.AutoSize = true;
            this.file_to_unsign.Location = new System.Drawing.Point(10, 45);
            this.file_to_unsign.Name = "file_to_unsign";
            this.file_to_unsign.Size = new System.Drawing.Size(0, 17);
            this.file_to_unsign.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(748, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 71);
            this.panel6.TabIndex = 8;
            this.toolTip13.SetToolTip(this.panel6, "Перетащите сюда файл для обработки");
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 3);
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
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(12, 250);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(998, 71);
            this.panel3.TabIndex = 6;
            this.panel3.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel3_DragEnter);
            // 
            // button32
            // 
            this.button32.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button32.BackgroundImage")));
            this.button32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button32.Location = new System.Drawing.Point(57, 8);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(32, 32);
            this.button32.TabIndex = 25;
            this.toolTip3.SetToolTip(this.button32, "Удалить исходный файл");
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button28
            // 
            this.button28.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button28.BackgroundImage")));
            this.button28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button28.Location = new System.Drawing.Point(313, 8);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(32, 32);
            this.button28.TabIndex = 24;
            this.toolTip5.SetToolTip(this.button28, "Удалить конечный файл");
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button24
            // 
            this.button24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button24.BackgroundImage")));
            this.button24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button24.Location = new System.Drawing.Point(275, 7);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(32, 32);
            this.button24.TabIndex = 23;
            this.toolTip4.SetToolTip(this.button24, "Копировать конечный файл в буфер обмена");
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button19
            // 
            this.button19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button19.BackgroundImage")));
            this.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button19.Location = new System.Drawing.Point(237, 8);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(32, 32);
            this.button19.TabIndex = 22;
            this.toolTip1.SetToolTip(this.button19, "Открыть папку с конечным файлом");
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button15
            // 
            this.button15.AccessibleDescription = "Открыть исходный файл";
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.Location = new System.Drawing.Point(19, 8);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(32, 32);
            this.button15.TabIndex = 21;
            this.button15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip2.SetToolTip(this.button15, "Открыть папку с исходным файлом");
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // file_to_encrypt
            // 
            this.file_to_encrypt.AutoSize = true;
            this.file_to_encrypt.Location = new System.Drawing.Point(10, 47);
            this.file_to_encrypt.Name = "file_to_encrypt";
            this.file_to_encrypt.Size = new System.Drawing.Size(0, 17);
            this.file_to_encrypt.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Location = new System.Drawing.Point(748, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 71);
            this.panel7.TabIndex = 8;
            this.toolTip13.SetToolTip(this.panel7, "Перетащите сюда файл для обработки");
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(101, 3);
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
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.button20);
            this.panel4.Controls.Add(this.button16);
            this.panel4.Controls.Add(this.file_to_sign);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Location = new System.Drawing.Point(12, 327);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(998, 71);
            this.panel4.TabIndex = 7;
            this.panel4.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel4_DragEnter);
            // 
            // button33
            // 
            this.button33.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button33.BackgroundImage")));
            this.button33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button33.Location = new System.Drawing.Point(57, 8);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(32, 32);
            this.button33.TabIndex = 26;
            this.toolTip3.SetToolTip(this.button33, "Удалить исходный файл");
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button29
            // 
            this.button29.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button29.BackgroundImage")));
            this.button29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button29.Location = new System.Drawing.Point(313, 9);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(32, 32);
            this.button29.TabIndex = 25;
            this.toolTip5.SetToolTip(this.button29, "Удалить конечный файл");
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button25
            // 
            this.button25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button25.BackgroundImage")));
            this.button25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button25.Location = new System.Drawing.Point(275, 8);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(32, 32);
            this.button25.TabIndex = 24;
            this.toolTip4.SetToolTip(this.button25, "Копировать конечный файл в буфер обмена");
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button20
            // 
            this.button20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button20.BackgroundImage")));
            this.button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button20.Location = new System.Drawing.Point(237, 8);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(32, 32);
            this.button20.TabIndex = 23;
            this.toolTip1.SetToolTip(this.button20, "Открыть папку с конечным файлом");
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button16
            // 
            this.button16.AccessibleDescription = "Открыть исходный файл";
            this.button16.Image = ((System.Drawing.Image)(resources.GetObject("button16.Image")));
            this.button16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button16.Location = new System.Drawing.Point(19, 8);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(32, 32);
            this.button16.TabIndex = 22;
            this.button16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip2.SetToolTip(this.button16, "Открыть папку с исходным файлом");
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // file_to_sign
            // 
            this.file_to_sign.AutoSize = true;
            this.file_to_sign.Location = new System.Drawing.Point(10, 46);
            this.file_to_sign.Name = "file_to_sign";
            this.file_to_sign.Size = new System.Drawing.Size(0, 17);
            this.file_to_sign.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(101, 3);
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
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Location = new System.Drawing.Point(748, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 71);
            this.panel8.TabIndex = 8;
            this.toolTip13.SetToolTip(this.panel8, "Перетащите сюда файл для обработки");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(9, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Сертификат КПЭП";
            // 
            // My_Cert
            // 
            this.My_Cert.Location = new System.Drawing.Point(168, 68);
            this.My_Cert.Name = "My_Cert";
            this.My_Cert.Size = new System.Drawing.Size(718, 22);
            this.My_Cert.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(892, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 32);
            this.button5.TabIndex = 9;
            this.toolTip6.SetToolTip(this.button5, "Выбрать папку с рабочими файлами программыы");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::CryptCP_automatizator.Properties.Resources.magnifying_glass;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(892, 62);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 32);
            this.button6.TabIndex = 10;
            this.toolTip8.SetToolTip(this.button6, "Выбрать свой сертификат электронной подписи и расшифрования файлов");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(9, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Путь до CryptCP";
            // 
            // CryptCP_folder
            // 
            this.CryptCP_folder.Location = new System.Drawing.Point(168, 37);
            this.CryptCP_folder.Name = "CryptCP_folder";
            this.CryptCP_folder.Size = new System.Drawing.Size(718, 22);
            this.CryptCP_folder.TabIndex = 3;
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::CryptCP_automatizator.Properties.Resources.select_file;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(892, 32);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(32, 32);
            this.button7.TabIndex = 11;
            this.toolTip7.SetToolTip(this.button7, "Выбрать полный путь до файла с программой КриптоПро cryptcp");
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button12
            // 
            this.button12.BackgroundImage = global::CryptCP_automatizator.Properties.Resources.open;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.Location = new System.Drawing.Point(930, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(32, 32);
            this.button12.TabIndex = 18;
            this.toolTip9.SetToolTip(this.button12, "Открыть папку с рабочими файлами программы");
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Button12_Click);
            // 
            // button21
            // 
            this.button21.BackgroundImage = global::CryptCP_automatizator.Properties.Resources.open;
            this.button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button21.Location = new System.Drawing.Point(930, 32);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(32, 32);
            this.button21.TabIndex = 19;
            this.toolTip10.SetToolTip(this.button21, "Открыть папку с файлом программы КриптоПро cryptcp");
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button34
            // 
            this.button34.BackgroundImage = global::CryptCP_automatizator.Properties.Resources.about;
            this.button34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button34.Location = new System.Drawing.Point(978, 3);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(32, 32);
            this.button34.TabIndex = 20;
            this.toolTip12.SetToolTip(this.button34, "Окно \"О программе\"");
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // toolTip2
            // 
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip2.ToolTipTitle = "Подсказка";
            // 
            // toolTip3
            // 
            this.toolTip3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip3.ToolTipTitle = "Подсказка";
            // 
            // toolTip4
            // 
            this.toolTip4.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip4.ToolTipTitle = "Подсказка";
            // 
            // toolTip5
            // 
            this.toolTip5.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip5.ToolTipTitle = "Подсказка";
            // 
            // toolTip6
            // 
            this.toolTip6.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip6.ToolTipTitle = "Подсказка";
            // 
            // toolTip7
            // 
            this.toolTip7.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip7.ToolTipTitle = "Подсказка";
            // 
            // toolTip8
            // 
            this.toolTip8.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip8.ToolTipTitle = "Подсказка";
            // 
            // toolTip9
            // 
            this.toolTip9.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip9.ToolTipTitle = "Подсказка";
            // 
            // toolTip10
            // 
            this.toolTip10.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip10.ToolTipTitle = "Подсказка";
            // 
            // toolTip11
            // 
            this.toolTip11.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip11.ToolTipTitle = "Подсказка";
            // 
            // toolTip12
            // 
            this.toolTip12.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip12.ToolTipTitle = "Подсказка";
            // 
            // toolTip13
            // 
            this.toolTip13.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip13.ToolTipTitle = "Подсказка";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 405);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button8);
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
            this.MaximumSize = new System.Drawing.Size(1039, 452);
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
        private System.Windows.Forms.TextBox Work_folder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
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
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.ToolTip toolTip12;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.ToolTip toolTip8;
        private System.Windows.Forms.ToolTip toolTip9;
        private System.Windows.Forms.ToolTip toolTip10;
        private System.Windows.Forms.ToolTip toolTip11;
        private System.Windows.Forms.ToolTip toolTip13;
    }
}

