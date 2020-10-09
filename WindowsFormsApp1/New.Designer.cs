namespace WindowsFormsApp1
{
    partial class New
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
            this.Creat = new System.Windows.Forms.Button();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.HP2 = new System.Windows.Forms.TextBox();
            this.Energy3 = new System.Windows.Forms.TextBox();
            this.Ability1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Creat
            // 
            this.Creat.Location = new System.Drawing.Point(96, 54);
            this.Creat.Name = "Creat";
            this.Creat.Size = new System.Drawing.Size(144, 41);
            this.Creat.TabIndex = 0;
            this.Creat.Text = "Create ";
            this.Creat.UseVisualStyleBackColor = true;
            this.Creat.Click += new System.EventHandler(this.Create_Click);
            // 
            // Name1
            // 
            this.Name1.Location = new System.Drawing.Point(142, 127);
            this.Name1.Multiline = true;
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(163, 25);
            this.Name1.TabIndex = 1;
            this.Name1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // HP2
            // 
            this.HP2.Location = new System.Drawing.Point(142, 176);
            this.HP2.Multiline = true;
            this.HP2.Name = "HP2";
            this.HP2.Size = new System.Drawing.Size(163, 25);
            this.HP2.TabIndex = 2;
            // 
            // Energy3
            // 
            this.Energy3.Location = new System.Drawing.Point(142, 224);
            this.Energy3.Multiline = true;
            this.Energy3.Name = "Energy3";
            this.Energy3.Size = new System.Drawing.Size(163, 25);
            this.Energy3.TabIndex = 3;
            // 
            // Ability1
            // 
            this.Ability1.Location = new System.Drawing.Point(142, 264);
            this.Ability1.Name = "Ability1";
            this.Ability1.Size = new System.Drawing.Size(163, 69);
            this.Ability1.TabIndex = 4;
            this.Ability1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "HP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Energy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Special abilities";
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 345);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ability1);
            this.Controls.Add(this.Energy3);
            this.Controls.Add(this.HP2);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.Creat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Create";
            this.Text = "Create";
            this.Load += new System.EventHandler(this.Create_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Creat;
        private System.Windows.Forms.TextBox Name1;
        private System.Windows.Forms.TextBox HP2;
        private System.Windows.Forms.TextBox Energy3;
        private System.Windows.Forms.RichTextBox Ability1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}