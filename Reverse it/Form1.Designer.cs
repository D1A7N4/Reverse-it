namespace Reverse_it
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBX_Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Reverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reverse It";
            // 
            // TBX_Input
            // 
            this.TBX_Input.Location = new System.Drawing.Point(101, 114);
            this.TBX_Input.Name = "TBX_Input";
            this.TBX_Input.Size = new System.Drawing.Size(126, 20);
            this.TBX_Input.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input your string:";
            // 
            // BTN_Reverse
            // 
            this.BTN_Reverse.Location = new System.Drawing.Point(101, 155);
            this.BTN_Reverse.Name = "BTN_Reverse";
            this.BTN_Reverse.Size = new System.Drawing.Size(126, 30);
            this.BTN_Reverse.TabIndex = 3;
            this.BTN_Reverse.Text = "Reverse it!";
            this.BTN_Reverse.UseVisualStyleBackColor = true;
            this.BTN_Reverse.Click += new System.EventHandler(this.BTN_Reverse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 225);
            this.Controls.Add(this.BTN_Reverse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBX_Input);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBX_Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Reverse;
    }
}

