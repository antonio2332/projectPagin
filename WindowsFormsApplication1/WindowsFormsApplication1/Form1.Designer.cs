namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LToBegin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NUMRecCount = new System.Windows.Forms.NumericUpDown();
            this.NUMVisiblePagesCount = new System.Windows.Forms.NumericUpDown();
            this.NUMPoljenie = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NUMRecsAtPage = new System.Windows.Forms.NumericUpDown();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUMRecCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMVisiblePagesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMPoljenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMRecsAtPage)).BeginInit();
            this.SuspendLayout();
            // 
            // LToBegin
            // 
            this.LToBegin.AutoSize = true;
            this.LToBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LToBegin.Location = new System.Drawing.Point(3, 9);
            this.LToBegin.Name = "LToBegin";
            this.LToBegin.Size = new System.Drawing.Size(92, 24);
            this.LToBegin.TabIndex = 0;
            this.LToBegin.Text = "Нажмите";
            this.LToBegin.Click += new System.EventHandler(this.LPage_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LToBegin);
            this.panel2.Location = new System.Drawing.Point(12, 355);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 42);
            this.panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(11, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(536, 293);
            this.textBox1.TabIndex = 2;
            // 
            // NUMRecCount
            // 
            this.NUMRecCount.Location = new System.Drawing.Point(26, 34);
            this.NUMRecCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUMRecCount.Name = "NUMRecCount";
            this.NUMRecCount.Size = new System.Drawing.Size(76, 20);
            this.NUMRecCount.TabIndex = 3;
            // 
            // NUMVisiblePagesCount
            // 
            this.NUMVisiblePagesCount.Location = new System.Drawing.Point(245, 34);
            this.NUMVisiblePagesCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUMVisiblePagesCount.Name = "NUMVisiblePagesCount";
            this.NUMVisiblePagesCount.Size = new System.Drawing.Size(76, 20);
            this.NUMVisiblePagesCount.TabIndex = 4;
            // 
            // NUMPoljenie
            // 
            this.NUMPoljenie.Location = new System.Drawing.Point(348, 34);
            this.NUMPoljenie.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUMPoljenie.Name = "NUMPoljenie";
            this.NUMPoljenie.Size = new System.Drawing.Size(76, 20);
            this.NUMPoljenie.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Кол-во записей";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Видимых страниц";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Положение страницы";
            // 
            // BOK
            // 
            this.BOK.Location = new System.Drawing.Point(472, 31);
            this.BOK.Name = "BOK";
            this.BOK.Size = new System.Drawing.Size(75, 23);
            this.BOK.TabIndex = 9;
            this.BOK.Text = "Применить";
            this.BOK.UseVisualStyleBackColor = true;
            this.BOK.Click += new System.EventHandler(this.BOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Записей на странице";
            // 
            // NUMRecsAtPage
            // 
            this.NUMRecsAtPage.Location = new System.Drawing.Point(122, 34);
            this.NUMRecsAtPage.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUMRecsAtPage.Name = "NUMRecsAtPage";
            this.NUMRecsAtPage.Size = new System.Drawing.Size(76, 20);
            this.NUMRecsAtPage.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 401);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NUMRecsAtPage);
            this.Controls.Add(this.BOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NUMPoljenie);
            this.Controls.Add(this.NUMVisiblePagesCount);
            this.Controls.Add(this.NUMRecCount);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUMRecCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMVisiblePagesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMPoljenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMRecsAtPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LToBegin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown NUMRecCount;
        private System.Windows.Forms.NumericUpDown NUMVisiblePagesCount;
        private System.Windows.Forms.NumericUpDown NUMPoljenie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUMRecsAtPage;
    }
}

