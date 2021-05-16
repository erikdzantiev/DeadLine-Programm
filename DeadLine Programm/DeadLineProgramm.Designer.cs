
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
            this.SuspendLayout();
            // 
            // buttonAddEvent
            // 
            this.buttonAddEvent.Location = new System.Drawing.Point(26, 235);
            this.buttonAddEvent.Name = "buttonAddEvent";
            this.buttonAddEvent.Size = new System.Drawing.Size(75, 23);
            this.buttonAddEvent.TabIndex = 0;
            this.buttonAddEvent.Text = "button1";
            this.buttonAddEvent.UseVisualStyleBackColor = true;
            this.buttonAddEvent.Click += new System.EventHandler(this.buttonAddEvent_Click);
            // 
            // buttonCloseProgramm
            // 
            this.buttonCloseProgramm.Location = new System.Drawing.Point(395, 328);
            this.buttonCloseProgramm.Name = "buttonCloseProgramm";
            this.buttonCloseProgramm.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseProgramm.TabIndex = 1;
            this.buttonCloseProgramm.Text = "button1";
            this.buttonCloseProgramm.UseVisualStyleBackColor = true;
            this.buttonCloseProgramm.Click += new System.EventHandler(this.buttonCloseProgramm_Click);
            // 
            // buttonDay
            // 
            this.buttonDay.Location = new System.Drawing.Point(649, 274);
            this.buttonDay.Name = "buttonDay";
            this.buttonDay.Size = new System.Drawing.Size(75, 23);
            this.buttonDay.TabIndex = 2;
            this.buttonDay.Text = "button1";
            this.buttonDay.UseVisualStyleBackColor = true;
            this.buttonDay.Click += new System.EventHandler(this.buttonDay_Click);
            // 
            // FormDeadLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

