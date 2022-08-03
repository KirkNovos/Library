
namespace Library
{
    partial class AddF
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
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBook = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.comboBoxJanr = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxDate = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveBtn.Location = new System.Drawing.Point(0, 268);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(254, 23);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Добавить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование книги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Год книги";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Жанр книги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Автор книги";
            // 
            // textBoxBook
            // 
            this.textBoxBook.Location = new System.Drawing.Point(30, 56);
            this.textBoxBook.Name = "textBoxBook";
            this.textBoxBook.Size = new System.Drawing.Size(179, 20);
            this.textBoxBook.TabIndex = 5;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(30, 224);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(179, 20);
            this.textBoxAuthor.TabIndex = 8;
            // 
            // comboBoxJanr
            // 
            this.comboBoxJanr.FormattingEnabled = true;
            this.comboBoxJanr.Location = new System.Drawing.Point(30, 158);
            this.comboBoxJanr.Name = "comboBoxJanr";
            this.comboBoxJanr.Size = new System.Drawing.Size(179, 21);
            this.comboBoxJanr.TabIndex = 9;
            // 
            // maskedTextBoxDate
            // 
            this.maskedTextBoxDate.Location = new System.Drawing.Point(30, 110);
            this.maskedTextBoxDate.Mask = "00/00/0000";
            this.maskedTextBoxDate.Name = "maskedTextBoxDate";
            this.maskedTextBoxDate.Size = new System.Drawing.Size(179, 20);
            this.maskedTextBoxDate.TabIndex = 10;
            this.maskedTextBoxDate.ValidatingType = typeof(System.DateTime);
            // 
            // AddF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 291);
            this.Controls.Add(this.maskedTextBoxDate);
            this.Controls.Add(this.comboBoxJanr);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxBook);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveBtn);
            this.MaximumSize = new System.Drawing.Size(270, 330);
            this.MinimumSize = new System.Drawing.Size(270, 330);
            this.Name = "AddF";
            this.Text = "Добавление книги";
            this.Load += new System.EventHandler(this.AddF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBook;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.ComboBox comboBoxJanr;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDate;
    }
}