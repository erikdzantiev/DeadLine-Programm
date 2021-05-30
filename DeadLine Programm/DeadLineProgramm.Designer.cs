
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
            this.buttonDay = new System.Windows.Forms.Button();
            this.listBoxShowDeadline = new System.Windows.Forms.ListBox();
            this.buttonTomorrow = new System.Windows.Forms.Button();
            this.buttonWeek = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOtherTime = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddEvent
            // 
            this.buttonAddEvent.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonAddEvent.Location = new System.Drawing.Point(15, 90);
            this.buttonAddEvent.Name = "buttonAddEvent";
            this.buttonAddEvent.Size = new System.Drawing.Size(172, 84);
            this.buttonAddEvent.TabIndex = 0;
            this.buttonAddEvent.Text = "добавить Дедлайн";
            this.buttonAddEvent.UseVisualStyleBackColor = false;
            this.buttonAddEvent.Click += new System.EventHandler(this.buttonAddEvent_Click);
            // 
            // buttonDay
            // 
            this.buttonDay.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonDay.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonDay.Location = new System.Drawing.Point(623, 141);
            this.buttonDay.Name = "buttonDay";
            this.buttonDay.Size = new System.Drawing.Size(153, 111);
            this.buttonDay.TabIndex = 2;
            this.buttonDay.Text = "Список дел на сегодняшний день";
            this.buttonDay.UseVisualStyleBackColor = false;
            this.buttonDay.Click += new System.EventHandler(this.buttonDay_Click);
            // 
            // listBoxShowDeadline
            // 
            this.listBoxShowDeadline.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxShowDeadline.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxShowDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxShowDeadline.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxShowDeadline.FormattingEnabled = true;
            this.listBoxShowDeadline.ItemHeight = 25;
            this.listBoxShowDeadline.Location = new System.Drawing.Point(782, 0);
            this.listBoxShowDeadline.Name = "listBoxShowDeadline";
            this.listBoxShowDeadline.Size = new System.Drawing.Size(521, 668);
            this.listBoxShowDeadline.TabIndex = 3;
            // 
            // buttonTomorrow
            // 
            this.buttonTomorrow.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonTomorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTomorrow.Location = new System.Drawing.Point(623, 277);
            this.buttonTomorrow.Name = "buttonTomorrow";
            this.buttonTomorrow.Size = new System.Drawing.Size(153, 111);
            this.buttonTomorrow.TabIndex = 4;
            this.buttonTomorrow.Text = "Список дел на завтрашний день";
            this.buttonTomorrow.UseVisualStyleBackColor = false;
            this.buttonTomorrow.Click += new System.EventHandler(this.buttonTomorrow_Click);
            // 
            // buttonWeek
            // 
            this.buttonWeek.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWeek.Location = new System.Drawing.Point(623, 413);
            this.buttonWeek.Name = "buttonWeek";
            this.buttonWeek.Size = new System.Drawing.Size(153, 111);
            this.buttonWeek.TabIndex = 5;
            this.buttonWeek.Text = "Список дел в течении следующей недели";
            this.buttonWeek.UseVisualStyleBackColor = false;
            this.buttonWeek.Click += new System.EventHandler(this.buttonWeek_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 89);
            this.label1.TabIndex = 10;
            this.label1.Text = "Чтобы добавить событие нажмите сюда:";
            // 
            // buttonOtherTime
            // 
            this.buttonOtherTime.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonOtherTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOtherTime.ForeColor = System.Drawing.Color.Black;
            this.buttonOtherTime.Location = new System.Drawing.Point(623, 541);
            this.buttonOtherTime.Name = "buttonOtherTime";
            this.buttonOtherTime.Size = new System.Drawing.Size(153, 127);
            this.buttonOtherTime.TabIndex = 11;
            this.buttonOtherTime.Text = "Список дел на продолжительный промежуток времени";
            this.buttonOtherTime.UseVisualStyleBackColor = false;
            this.buttonOtherTime.Click += new System.EventHandler(this.buttonOtherTime_Click);
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(623, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 111);
            this.button1.TabIndex = 12;
            this.button1.Text = "показать все дела";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(42, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 75);
            this.label2.TabIndex = 13;
            this.label2.Text = "Время до ближайшего Дедлайна:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(55, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 67);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // FormDeadLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1303, 668);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonOtherTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonWeek);
            this.Controls.Add(this.buttonTomorrow);
            this.Controls.Add(this.listBoxShowDeadline);
            this.Controls.Add(this.buttonDay);
            this.Controls.Add(this.buttonAddEvent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormDeadLines";
            this.Text = "DeadLines";
            this.Load += new System.EventHandler(this.DeadLines_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddEvent;
        private System.Windows.Forms.Button buttonDay;
        private System.Windows.Forms.ListBox listBoxShowDeadline;
        private System.Windows.Forms.Button buttonTomorrow;
        private System.Windows.Forms.Button buttonWeek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOtherTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

