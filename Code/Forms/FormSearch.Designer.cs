namespace Hotel.Forms
{
    partial class FormSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearch));
            this.obs = new System.Windows.Forms.Button();
            this.amb = new System.Windows.Forms.Button();
            this.otchestvo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.famil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.data_obschee = new System.Windows.Forms.DataGridView();
            this.label35 = new System.Windows.Forms.Label();
            this.find_famil = new System.Windows.Forms.TextBox();
            this.pc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.find_name = new System.Windows.Forms.TextBox();
            this.find_surname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_obschee)).BeginInit();
            this.SuspendLayout();
            // 
            // obs
            // 
            this.obs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.obs.BackColor = System.Drawing.Color.Azure;
            this.obs.Enabled = false;
            this.obs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.obs.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.obs.Location = new System.Drawing.Point(20, 692);
            this.obs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.obs.Name = "obs";
            this.obs.Size = new System.Drawing.Size(434, 118);
            this.obs.TabIndex = 10;
            this.obs.Text = "Обследование";
            this.obs.UseVisualStyleBackColor = false;
            this.obs.Click += new System.EventHandler(this.obs_Click);
            // 
            // amb
            // 
            this.amb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.amb.BackColor = System.Drawing.Color.Azure;
            this.amb.Enabled = false;
            this.amb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.amb.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amb.Location = new System.Drawing.Point(650, 692);
            this.amb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amb.Name = "amb";
            this.amb.Size = new System.Drawing.Size(519, 118);
            this.amb.TabIndex = 9;
            this.amb.Text = "Амбулатория";
            this.amb.UseVisualStyleBackColor = false;
            this.amb.Click += new System.EventHandler(this.amb_Click);
            // 
            // otchestvo
            // 
            this.otchestvo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.otchestvo.AutoSize = true;
            this.otchestvo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.otchestvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otchestvo.Location = new System.Drawing.Point(783, 617);
            this.otchestvo.Name = "otchestvo";
            this.otchestvo.Size = new System.Drawing.Size(21, 29);
            this.otchestvo.TabIndex = 117;
            this.otchestvo.Text = "-";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(645, 618);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 29);
            this.label4.TabIndex = 116;
            this.label4.Text = "Отчество";
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(433, 617);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(21, 29);
            this.name.TabIndex = 115;
            this.name.Text = "-";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label3.Location = new System.Drawing.Point(363, 617);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 29);
            this.label3.TabIndex = 114;
            this.label3.Text = "Имя";
            // 
            // famil
            // 
            this.famil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.famil.AutoSize = true;
            this.famil.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.famil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.famil.Location = new System.Drawing.Point(145, 617);
            this.famil.Name = "famil";
            this.famil.Size = new System.Drawing.Size(21, 29);
            this.famil.TabIndex = 113;
            this.famil.Text = "-";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label1.Location = new System.Drawing.Point(13, 616);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 29);
            this.label1.TabIndex = 112;
            this.label1.Text = "Фамилия";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(1740, 34);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(67, 63);
            this.panel3.TabIndex = 111;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 63);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // data_obschee
            // 
            this.data_obschee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.data_obschee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_obschee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data_obschee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_obschee.Location = new System.Drawing.Point(9, 190);
            this.data_obschee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_obschee.MultiSelect = false;
            this.data_obschee.Name = "data_obschee";
            this.data_obschee.ReadOnly = true;
            this.data_obschee.RowHeadersWidth = 51;
            this.data_obschee.RowTemplate.Height = 24;
            this.data_obschee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_obschee.Size = new System.Drawing.Size(1792, 378);
            this.data_obschee.TabIndex = 110;
            this.data_obschee.Click += new System.EventHandler(this.data_obschee_Click);
            // 
            // label35
            // 
            this.label35.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label35.Location = new System.Drawing.Point(15, 97);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(119, 28);
            this.label35.TabIndex = 109;
            this.label35.Text = "Фамилия";
            // 
            // find_famil
            // 
            this.find_famil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.find_famil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find_famil.Location = new System.Drawing.Point(15, 133);
            this.find_famil.Margin = new System.Windows.Forms.Padding(4);
            this.find_famil.MaxLength = 20;
            this.find_famil.Name = "find_famil";
            this.find_famil.Size = new System.Drawing.Size(263, 30);
            this.find_famil.TabIndex = 1;
            this.find_famil.TextChanged += new System.EventHandler(this.find_famil_TextChanged);
            // 
            // pc
            // 
            this.pc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pc.BackColor = System.Drawing.Color.Azure;
            this.pc.Enabled = false;
            this.pc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pc.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pc.Location = new System.Drawing.Point(1302, 692);
            this.pc.Margin = new System.Windows.Forms.Padding(4);
            this.pc.Name = "pc";
            this.pc.Size = new System.Drawing.Size(471, 118);
            this.pc.TabIndex = 118;
            this.pc.Text = "Личная карточка";
            this.pc.UseVisualStyleBackColor = false;
            this.pc.Click += new System.EventHandler(this.pc_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1400, 826);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 42);
            this.label2.TabIndex = 119;
            this.label2.Text = "Нажмите для открытия личной\r\n карточки выбранного человека";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(71, 826);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(338, 42);
            this.label5.TabIndex = 120;
            this.label5.Text = "Нажмите для добавления/изменения\r\n информации о выбранном человеке\r\n";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(747, 826);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(333, 42);
            this.label6.TabIndex = 121;
            this.label6.Text = "Нажмите для добавления/изменения \r\nинформации о выбранном человеке";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(16, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(368, 21);
            this.label7.TabIndex = 122;
            this.label7.Text = "Введите параметры для поиска человека";
            // 
            // find_name
            // 
            this.find_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.find_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.find_name.Location = new System.Drawing.Point(320, 132);
            this.find_name.Margin = new System.Windows.Forms.Padding(4);
            this.find_name.MaxLength = 50;
            this.find_name.Multiline = true;
            this.find_name.Name = "find_name";
            this.find_name.Size = new System.Drawing.Size(263, 30);
            this.find_name.TabIndex = 2;
            this.find_name.TextChanged += new System.EventHandler(this.find_name_TextChanged);
            // 
            // find_surname
            // 
            this.find_surname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.find_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.find_surname.Location = new System.Drawing.Point(630, 132);
            this.find_surname.Margin = new System.Windows.Forms.Padding(4);
            this.find_surname.MaxLength = 30;
            this.find_surname.Multiline = true;
            this.find_surname.Name = "find_surname";
            this.find_surname.Size = new System.Drawing.Size(263, 30);
            this.find_surname.TabIndex = 3;
            this.find_surname.TextChanged += new System.EventHandler(this.find_surname_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(315, 98);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 28);
            this.label8.TabIndex = 125;
            this.label8.Text = "Имя";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(625, 101);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 28);
            this.label9.TabIndex = 126;
            this.label9.Text = "Отчество";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(861, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 40);
            this.label10.TabIndex = 127;
            this.label10.Text = "Поиск";
            // 
            // label42
            // 
            this.label42.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label42.Location = new System.Drawing.Point(1643, 11);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(163, 21);
            this.label42.TabIndex = 128;
            this.label42.Text = "Вернуться в меню";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 570);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(346, 38);
            this.label11.TabIndex = 129;
            this.label11.Text = "Выбранный пациент";
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1821, 945);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.find_surname);
            this.Controls.Add(this.find_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pc);
            this.Controls.Add(this.otchestvo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.famil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.data_obschee);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.find_famil);
            this.Controls.Add(this.obs);
            this.Controls.Add(this.amb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSearch_FormClosing);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_obschee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button obs;
        private System.Windows.Forms.Button amb;
        private System.Windows.Forms.Label otchestvo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label famil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView data_obschee;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox find_famil;
        private System.Windows.Forms.Button pc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox find_name;
        private System.Windows.Forms.TextBox find_surname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label11;
    }
}