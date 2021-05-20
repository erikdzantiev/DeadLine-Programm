
namespace DeadLine_Programm
{
    partial class FormDeadLines
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
            this.buttonAddEvent = new System.Windows.Forms.Button();
            this.buttonCloseProgramm = new System.Windows.Forms.Button();
            this.buttonDay = new System.Windows.Forms.Button();
            this.listBoxShowDeadline = new System.Windows.Forms.ListBox();
            this.buttonTomorrow = new System.Windows.Forms.Button();
            this.buttonWeek = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddEvent
            // 
            this.buttonAddEvent.BackColor = System.Drawing.SystemColors.Info;
            this.buttonAddEvent.Location = new System.Drawing.Point(63, 529);
            this.buttonAddEvent.Name = "buttonAddEvent";
            this.buttonAddEvent.Size = new System.Drawing.Size(133, 23);
            this.buttonAddEvent.TabIndex = 0;
            this.buttonAddEvent.Text = "добавить Дедлайн";
            this.buttonAddEvent.UseVisualStyleBackColor = false;
            this.buttonAddEvent.Click += new System.EventHandler(this.buttonAddEvent_Click);
            // 
            // buttonCloseProgramm
            // 
            this.buttonCloseProgramm.BackColor = System.Drawing.SystemColors.Info;
            this.buttonCloseProgramm.Location = new System.Drawing.Point(815, 529);
            this.buttonCloseProgramm.Name = "buttonCloseProgramm";
            this.buttonCloseProgramm.Size = new System.Drawing.Size(121, 23);
            this.buttonCloseProgramm.TabIndex = 1;
            this.buttonCloseProgramm.Text = "закрыть программу";
            this.buttonCloseProgramm.UseVisualStyleBackColor = false;
            this.buttonCloseProgramm.Click += new System.EventHandler(this.buttonCloseProgramm_Click);
            // 
            // buttonDay
            // 
            this.buttonDay.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonDay.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonDay.Location = new System.Drawing.Point(978, 0);
            this.buttonDay.Name = "buttonDay";
            this.buttonDay.Size = new System.Drawing.Size(114, 72);
            this.buttonDay.TabIndex = 2;
            this.buttonDay.Text = "Список дедлайнов на сегодняшний день";
            this.buttonDay.UseVisualStyleBackColor = false;
            this.buttonDay.Click += new System.EventHandler(this.buttonDay_Click);
            // 
            // listBoxShowDeadline
            // 
            this.listBoxShowDeadline.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxShowDeadline.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxShowDeadline.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxShowDeadline.FormattingEnabled = true;
            this.listBoxShowDeadline.Location = new System.Drawing.Point(1117, 0);
            this.listBoxShowDeadline.Name = "listBoxShowDeadline";
            this.listBoxShowDeadline.Size = new System.Drawing.Size(320, 699);
            this.listBoxShowDeadline.TabIndex = 3;
            // 
            // buttonTomorrow
            // 
            this.buttonTomorrow.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonTomorrow.Location = new System.Drawing.Point(978, 96);
            this.buttonTomorrow.Name = "buttonTomorrow";
            this.buttonTomorrow.Size = new System.Drawing.Size(114, 73);
            this.buttonTomorrow.TabIndex = 4;
            this.buttonTomorrow.Text = "Список дедлайнов на завтрашний день";
            this.buttonTomorrow.UseVisualStyleBackColor = false;
            this.buttonTomorrow.Click += new System.EventHandler(this.buttonTomorrow_Click);
            // 
            // buttonWeek
            // 
            this.buttonWeek.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonWeek.Location = new System.Drawing.Point(978, 195);
            this.buttonWeek.Name = "buttonWeek";
            this.buttonWeek.Size = new System.Drawing.Size(114, 70);
            this.buttonWeek.TabIndex = 5;
            this.buttonWeek.Text = "Список дедлайнов в течении следующей недели";
            this.buttonWeek.UseVisualStyleBackColor = false;
            this.buttonWeek.Click += new System.EventHandler(this.buttonWeek_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 20);
            this.textBox1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 108);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(109, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(192, 108);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(85, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(970, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "выгрузить из файла";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormDeadLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1437, 699);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonWeek);
            this.Controls.Add(this.buttonTomorrow);
            this.Controls.Add(this.listBoxShowDeadline);
            this.Controls.Add(this.buttonDay);
            this.Controls.Add(this.buttonCloseProgramm);
            this.Controls.Add(this.buttonAddEvent);
            this.Name = "FormDeadLines";
            this.Text = "DeadLines";
            this.Load += new System.EventHandler(this.DeadLines_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddEvent;
        private System.Windows.Forms.Button buttonCloseProgramm;
        private System.Windows.Forms.Button buttonDay;
        private System.Windows.Forms.ListBox listBoxShowDeadline;
        private System.Windows.Forms.Button buttonTomorrow;
        private System.Windows.Forms.Button buttonWeek;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
    }
}

