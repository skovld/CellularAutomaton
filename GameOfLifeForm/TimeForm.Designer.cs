namespace CellularAutomatonForm
{
    partial class TimeForm
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
            this.timeValue_numeric = new System.Windows.Forms.NumericUpDown();
            this.deny_Btn = new System.Windows.Forms.Button();
            this.accept_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timeValue_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // timeValue_numeric
            // 
            this.timeValue_numeric.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.timeValue_numeric.Location = new System.Drawing.Point(8, 43);
            this.timeValue_numeric.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.timeValue_numeric.Name = "timeValue_numeric";
            this.timeValue_numeric.Size = new System.Drawing.Size(170, 20);
            this.timeValue_numeric.TabIndex = 1;
            // 
            // deny_Btn
            // 
            this.deny_Btn.Location = new System.Drawing.Point(98, 75);
            this.deny_Btn.Name = "deny_Btn";
            this.deny_Btn.Size = new System.Drawing.Size(56, 24);
            this.deny_Btn.TabIndex = 7;
            this.deny_Btn.Text = "Cancel";
            this.deny_Btn.UseVisualStyleBackColor = true;
            this.deny_Btn.Click += new System.EventHandler(this.deny_Btn_Click);
            // 
            // accept_Btn
            // 
            this.accept_Btn.Location = new System.Drawing.Point(36, 75);
            this.accept_Btn.Name = "accept_Btn";
            this.accept_Btn.Size = new System.Drawing.Size(56, 24);
            this.accept_Btn.TabIndex = 6;
            this.accept_Btn.Text = "OK";
            this.accept_Btn.UseVisualStyleBackColor = true;
            this.accept_Btn.Click += new System.EventHandler(this.accept_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите время задержки:\r\n(0 - 5000 мс)";
            // 
            // TimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 106);
            this.Controls.Add(this.deny_Btn);
            this.Controls.Add(this.accept_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeValue_numeric);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Задержка";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TimeForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.timeValue_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown timeValue_numeric;
        private System.Windows.Forms.Button deny_Btn;
        private System.Windows.Forms.Button accept_Btn;
        private System.Windows.Forms.Label label1;
    }
}