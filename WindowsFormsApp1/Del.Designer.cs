namespace WindowsFormsApp1
{
    partial class DelCharacter
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
            this.button1 = new System.Windows.Forms.Button();
            this.delBox = new System.Windows.Forms.TextBox();
            this.SwowBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "enter the Index your character ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.del_Click);
            // 
            // delBox
            // 
            this.delBox.Location = new System.Drawing.Point(15, 57);
            this.delBox.Name = "delBox";
            this.delBox.Size = new System.Drawing.Size(100, 22);
            this.delBox.TabIndex = 2;
            this.delBox.TextChanged += new System.EventHandler(this.delBox_TextChanged);
            // 
            // SwowBox
            // 
            this.SwowBox.Location = new System.Drawing.Point(12, 128);
            this.SwowBox.Multiline = true;
            this.SwowBox.Name = "SwowBox";
            this.SwowBox.Size = new System.Drawing.Size(237, 69);
            this.SwowBox.TabIndex = 3;
            this.SwowBox.TextChanged += new System.EventHandler(this.SwowBox_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.exit_Click);
            // 
            // DelCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SwowBox);
            this.Controls.Add(this.delBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "DelCharacter";
            this.Text = "Delete Character";
            this.Load += new System.EventHandler(this.DelCharacter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox delBox;
        private System.Windows.Forms.TextBox SwowBox;
        private System.Windows.Forms.Button button2;
    }
}