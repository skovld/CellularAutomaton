namespace CellularAutomatonForm
{
    partial class RandomForm
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
            this.randomValue_numeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.accept_Btn = new System.Windows.Forms.Button();
            this.deny_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.randomValue_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // randomValue_numeric
            // 
            this.randomValue_numeric.Location = new System.Drawing.Point(12, 44);
            this.randomValue_numeric.Name = "randomValue_numeric";
            this.randomValue_numeric.Size = new System.Drawing.Size(170, 20);
            this.randomValue_numeric.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите плотность заполнения:\r\n(0 - 100%)";
            // 
            // accept_Btn
            // 
            this.accept_Btn.Location = new System.Drawing.Point(40, 80);
            this.accept_Btn.Name = "accept_Btn";
            this.accept_Btn.Size = new System.Drawing.Size(56, 24);
            this.accept_Btn.TabIndex = 2;
            this.accept_Btn.Text = "OK";
            this.accept_Btn.UseVisualStyleBackColor = true;
            this.accept_Btn.Click += new System.EventHandler(this.accept_Btn_Click);
            // 
            // deny_Btn
            // 
            this.deny_Btn.Location = new System.Drawing.Point(102, 80);
            this.deny_Btn.Name = "deny_Btn";
            this.deny_Btn.Size = new System.Drawing.Size(56, 24);
            this.deny_Btn.TabIndex = 4;
            this.deny_Btn.Text = "Cancel";
            this.deny_Btn.UseVisualStyleBackColor = true;
            this.deny_Btn.Click += new System.EventHandler(this.deny_Btn_Click);
            // 
            // RandomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(196, 116);
            this.Controls.Add(this.deny_Btn);
            this.Controls.Add(this.accept_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.randomValue_numeric);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RandomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Случайное заполнение";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RandomForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.randomValue_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown randomValue_numeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button accept_Btn;
        private System.Windows.Forms.Button deny_Btn;
    }
}