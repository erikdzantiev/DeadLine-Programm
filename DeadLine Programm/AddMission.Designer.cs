
namespace DeadLine_Programm
{
    partial class FormAddEvent
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxNameDL = new System.Windows.Forms.TextBox();
            this.textBoxPurposeDL = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.comboBoxHours = new System.Windows.Forms.ComboBox();
            this.comboBoxMinutes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(150, 343);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(82, 33);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxNameDL
            // 
            this.textBoxNameDL.Location = new System.Drawing.Point(151, 34);
            this.textBoxNameDL.Multiline = true;
            this.textBoxNameDL.Name = "textBoxNameDL";
            this.textBoxNameDL.Size = new System.Drawing.Size(120, 35);
            this.textBoxNameDL.TabIndex = 2;
            // 
            // textBoxPurposeDL
            // 
            this.textBoxPurposeDL.Location = new System.Drawing.Point(151, 90);
            this.textBoxPurposeDL.Multiline = true;
            this.textBoxPurposeDL.Name = "textBoxPurposeDL";
            this.textBoxPurposeDL.Size = new System.Drawing.Size(425, 136);
            this.textBoxPurposeDL.TabIndex = 3;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(151, 252);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxDate.TabIndex = 4;
            // 
            // comboBoxHours
            // 
            this.comboBoxHours.FormattingEnabled = true;
            this.comboBoxHours.Location = new System.Drawing.Point(150, 296);
            this.comboBoxHours.Name = "comboBoxHours";
            this.comboBoxHours.Size = new System.Drawing.Size(54, 21);
            this.comboBoxHours.TabIndex = 5;
            // 
            // comboBoxMinutes
            // 
            this.comboBoxMinutes.FormattingEnabled = true;
            this.comboBoxMinutes.Location = new System.Drawing.Point(235, 296);
            this.comboBoxMinutes.Name = "comboBoxMinutes";
            this.comboBoxMinutes.Size = new System.Drawing.Size(54, 21);
            this.comboBoxMinutes.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(208, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(257, 252);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(14, 20);
            this.dateTimePickerDate.TabIndex = 8;
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePickerDate_ValueChanged);
            // 
            // FormAddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMinutes);
            this.Controls.Add(this.comboBoxHours);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxPurposeDL);
            this.Controls.Add(this.textBoxNameDL);
            this.Controls.Add(this.buttonSave);
            this.Name = "FormAddEvent";
            this.Text = "Добавьте мероприятие";
            this.Load += new System.EventHandler(this.AddEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        public System.Windows.Forms.TextBox textBoxNameDL;
        public System.Windows.Forms.TextBox textBoxPurposeDL;
        public System.Windows.Forms.TextBox textBoxDate;
        public System.Windows.Forms.ComboBox comboBoxHours;
        public System.Windows.Forms.ComboBox comboBoxMinutes;
    }
}