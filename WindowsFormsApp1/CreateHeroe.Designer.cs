namespace WindowsFormsApp1
{
    partial class createHero
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
            this.New = new System.Windows.Forms.Button();
            this.All = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.Sh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(100, 102);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(170, 39);
            this.New.TabIndex = 0;
            this.New.Text = "Create New Сharacter ";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // All
            // 
            this.All.Location = new System.Drawing.Point(100, 170);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(170, 39);
            this.All.TabIndex = 1;
            this.All.Text = "Show All ";
            this.All.UseVisualStyleBackColor = true;
            this.All.Click += new System.EventHandler(this.All_Click);
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(100, 232);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(170, 39);
            this.Del.TabIndex = 2;
            this.Del.Text = "Delete Character";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Sh
            // 
            this.Sh.Location = new System.Drawing.Point(100, 302);
            this.Sh.Name = "Sh";
            this.Sh.Size = new System.Drawing.Size(169, 39);
            this.Sh.TabIndex = 3;
            this.Sh.Text = "Show Character";
            this.Sh.UseVisualStyleBackColor = true;
            this.Sh.Click += new System.EventHandler(this.Sh_Click);
            // 
            // createHero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(359, 390);
            this.Controls.Add(this.Sh);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.All);
            this.Controls.Add(this.New);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "createHero";
            this.Text = "createHero";
            this.Load += new System.EventHandler(this.CreateHeroe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button All;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button Sh;
    }
}

