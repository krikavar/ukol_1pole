
namespace ukol_1pole
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_vstuphod = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button_vypoc = new System.Windows.Forms.Button();
            this.radioButton_nahoru = new System.Windows.Forms.RadioButton();
            this.radioButton_dolu = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox_vstuphod
            // 
            this.textBox_vstuphod.Location = new System.Drawing.Point(297, 70);
            this.textBox_vstuphod.Name = "textBox_vstuphod";
            this.textBox_vstuphod.Size = new System.Drawing.Size(137, 22);
            this.textBox_vstuphod.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 372);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(152, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 372);
            this.listBox2.TabIndex = 2;
            // 
            // button_vypoc
            // 
            this.button_vypoc.Location = new System.Drawing.Point(297, 12);
            this.button_vypoc.Name = "button_vypoc";
            this.button_vypoc.Size = new System.Drawing.Size(137, 34);
            this.button_vypoc.TabIndex = 3;
            this.button_vypoc.Text = "Výpočet";
            this.button_vypoc.UseVisualStyleBackColor = true;
            this.button_vypoc.Click += new System.EventHandler(this.button_vypoc_Click);
            // 
            // radioButton_nahoru
            // 
            this.radioButton_nahoru.AutoSize = true;
            this.radioButton_nahoru.Location = new System.Drawing.Point(297, 139);
            this.radioButton_nahoru.Name = "radioButton_nahoru";
            this.radioButton_nahoru.Size = new System.Drawing.Size(89, 21);
            this.radioButton_nahoru.TabIndex = 4;
            this.radioButton_nahoru.Text = "Sestupně";
            this.radioButton_nahoru.UseVisualStyleBackColor = true;
            // 
            // radioButton_dolu
            // 
            this.radioButton_dolu.AutoSize = true;
            this.radioButton_dolu.Checked = true;
            this.radioButton_dolu.Location = new System.Drawing.Point(297, 112);
            this.radioButton_dolu.Name = "radioButton_dolu";
            this.radioButton_dolu.Size = new System.Drawing.Size(96, 21);
            this.radioButton_dolu.TabIndex = 5;
            this.radioButton_dolu.TabStop = true;
            this.radioButton_dolu.Text = "Vzestupně";
            this.radioButton_dolu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 397);
            this.Controls.Add(this.radioButton_dolu);
            this.Controls.Add(this.radioButton_nahoru);
            this.Controls.Add(this.button_vypoc);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox_vstuphod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Úkol 1 POLE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_vstuphod;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button_vypoc;
        private System.Windows.Forms.RadioButton radioButton_nahoru;
        private System.Windows.Forms.RadioButton radioButton_dolu;
    }
}

