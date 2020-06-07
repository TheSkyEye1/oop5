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
            this.gal = new WindowsFormsApp2.HoverButtonG();
            this.galc = new WindowsFormsApp2.HoverButttonGC();
            this.SuspendLayout();
            // 
            // gal
            // 
            this.gal.ForeColor = System.Drawing.Color.LightBlue;
            this.gal.Location = new System.Drawing.Point(62, 43);
            this.gal.Name = "gal";
            this.gal.Size = new System.Drawing.Size(173, 167);
            this.gal.TabIndex = 0;
            this.gal.Text = "hoverButtonG1";
            this.gal.UseVisualStyleBackColor = true;
            // 
            // galc
            // 
            this.galc.ForeColor = System.Drawing.Color.LightBlue;
            this.galc.Location = new System.Drawing.Point(379, 37);
            this.galc.Name = "galc";
            this.galc.Size = new System.Drawing.Size(180, 173);
            this.galc.TabIndex = 1;
            this.galc.Text = "hoverButttonGC1";
            this.galc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(661, 261);
            this.Controls.Add(this.galc);
            this.Controls.Add(this.gal);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }


        #endregion

        private HoverButtonG gal;
        private HoverButttonGC galc;
    }
}

