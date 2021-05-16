
namespace DeadLine_Programm
{
    partial class FormOneDay
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
            this.listBoxOD = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxOD
            // 
            this.listBoxOD.FormattingEnabled = true;
            this.listBoxOD.Location = new System.Drawing.Point(0, 0);
            this.listBoxOD.Name = "listBoxOD";
            this.listBoxOD.Size = new System.Drawing.Size(317, 433);
            this.listBoxOD.TabIndex = 0;
            // 
            // FormOneDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxOD);
            this.Name = "FormOneDay";
            this.Text = "OneDay";
            this.Load += new System.EventHandler(this.FormOneDay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOD;
    }
}