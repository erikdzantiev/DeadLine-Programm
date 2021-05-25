
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
            this.buttonLoadFromFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddEvent
            // 
            this.buttonAddEvent.BackColor = System.Drawing.SystemColors.Info;
            this.buttonAddEvent.Location = new System.Drawing.Point(52, 349);
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
            this.buttonCloseProgramm.Location = new System.Drawing.Point(244, 349);
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
            this.buttonDay.Location = new System.Drawing.Point(432, 0);
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
            this.listBoxShowDeadline.Location = new System.Drawing.Point(553, 0);
            this.listBoxShowDeadline.Name = "listBoxShowDeadline";
            this.listBoxShowDeadline.Size = new System.Drawing.Size(320, 473);
            this.listBoxShowDeadline.TabIndex = 3;
            // 
            // buttonTomorrow
            // 
            this.buttonTomorrow.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonTomorrow.Location = new System.Drawing.Point(432, 78);
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
            this.buttonWeek.Location = new System.Drawing.Point(432, 157);
            this.buttonWeek.Name = "buttonWeek";
            this.buttonWeek.Size = new System.Drawing.Size(114, 70);
            this.buttonWeek.TabIndex = 5;
            this.buttonWeek.Text = "Список дедлайнов в течении следующей недели";
            this.buttonWeek.UseVisualStyleBackColor = false;
            this.buttonWeek.Click += new System.EventHandler(this.buttonWeek_Click);
            // 
            // buttonLoadFromFile
            // 
            this.buttonLoadFromFile.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonLoadFromFile.Location = new System.Drawing.Point(432, 233);
            this.buttonLoadFromFile.Name = "buttonLoadFromFile";
            this.buttonLoadFromFile.Size = new System.Drawing.Size(114, 60);
            this.buttonLoadFromFile.TabIndex = 9;
            this.buttonLoadFromFile.Text = "выгрузить из файла";
            this.buttonLoadFromFile.UseVisualStyleBackColor = false;
            this.buttonLoadFromFile.Click += new System.EventHandler(this.buttonLoadFromFile_Click);
            // 
            // FormDeadLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(873, 473);
            this.Controls.Add(this.buttonLoadFromFile);
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

        }

        #endregion

        private System.Windows.Forms.Button buttonAddEvent;
        private System.Windows.Forms.Button buttonCloseProgramm;
        private System.Windows.Forms.Button buttonDay;
        private System.Windows.Forms.ListBox listBoxShowDeadline;
        private System.Windows.Forms.Button buttonTomorrow;
        private System.Windows.Forms.Button buttonWeek;
        private System.Windows.Forms.Button buttonLoadFromFile;
    }
}

