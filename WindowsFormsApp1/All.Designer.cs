namespace WindowsFormsApp1
{
    partial class ShowAll
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
            this.writeAll = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // writeAll
            // 
            this.writeAll.Location = new System.Drawing.Point(12, 66);
            this.writeAll.Multiline = true;
            this.writeAll.Name = "writeAll";
            this.writeAll.Size = new System.Drawing.Size(401, 275);
            this.writeAll.TabIndex = 0;
            this.writeAll.TextChanged += new System.EventHandler(this.writeAll_TextChanged);
            // 
            // ShowAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 353);
            this.Controls.Add(this.writeAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ShowAll";
            this.Text = "ShowAll";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox writeAll;
    }
}