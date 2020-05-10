namespace WindowsFormsApp2
{
    partial class Form1
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
            this.hoverButtonG1 = new WindowsFormsApp2.HoverButtonG();
            this.hoverButttonGC1 = new WindowsFormsApp2.HoverButttonGC();
            this.SuspendLayout();
            // 
            // hoverButtonG1
            // 
            this.hoverButtonG1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoverButtonG1.ForeColor = System.Drawing.Color.White;
            this.hoverButtonG1.Location = new System.Drawing.Point(12, 12);
            this.hoverButtonG1.Name = "hoverButtonG1";
            this.hoverButtonG1.Size = new System.Drawing.Size(223, 222);
            this.hoverButtonG1.TabIndex = 0;
            this.hoverButtonG1.Text = "hoverButtonG1";
            this.hoverButtonG1.UseVisualStyleBackColor = true;
            // 
            // hoverButttonGC1
            // 
            this.hoverButttonGC1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoverButttonGC1.ForeColor = System.Drawing.Color.LightBlue;
            this.hoverButttonGC1.Location = new System.Drawing.Point(250, 12);
            this.hoverButttonGC1.Name = "hoverButttonGC1";
            this.hoverButttonGC1.Size = new System.Drawing.Size(225, 231);
            this.hoverButttonGC1.TabIndex = 1;
            this.hoverButttonGC1.Text = "hoverButttonGC1";
            this.hoverButttonGC1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 266);
            this.Controls.Add(this.hoverButttonGC1);
            this.Controls.Add(this.hoverButtonG1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private HoverButtonG hoverButtonG1;
        private HoverButttonGC hoverButttonGC1;
    }
}

