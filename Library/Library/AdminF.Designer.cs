
namespace Library
{
    partial class AdminF
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DelBtn);
            this.groupBox1.Controls.Add(this.EditBtn);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(702, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Навигация";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(6, 80);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(83, 23);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Добавление";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(6, 132);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(83, 23);
            this.EditBtn.TabIndex = 1;
            this.EditBtn.Text = "Измение";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(6, 186);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(83, 23);
            this.DelBtn.TabIndex = 2;
            this.DelBtn.Text = "Удаление";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBooks.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.Size = new System.Drawing.Size(702, 450);
            this.dataGridViewBooks.TabIndex = 1;
            // 
            // AdminF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminF";
            this.Text = "AdminF";
            this.Load += new System.EventHandler(this.AdminF_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
    }
}