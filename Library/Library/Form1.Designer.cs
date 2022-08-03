
namespace Library
{
    partial class AuthoF
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
            this.AuthoBtn = new System.Windows.Forms.Button();
            this.LoginLab = new System.Windows.Forms.Label();
            this.PasLab = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.textBoxPas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AuthoBtn
            // 
            this.AuthoBtn.Location = new System.Drawing.Point(22, 114);
            this.AuthoBtn.Name = "AuthoBtn";
            this.AuthoBtn.Size = new System.Drawing.Size(75, 23);
            this.AuthoBtn.TabIndex = 0;
            this.AuthoBtn.Text = "Войти";
            this.AuthoBtn.UseVisualStyleBackColor = true;
            this.AuthoBtn.Click += new System.EventHandler(this.AuthoBtn_Click);
            // 
            // LoginLab
            // 
            this.LoginLab.AutoSize = true;
            this.LoginLab.Location = new System.Drawing.Point(19, 18);
            this.LoginLab.Name = "LoginLab";
            this.LoginLab.Size = new System.Drawing.Size(38, 13);
            this.LoginLab.TabIndex = 1;
            this.LoginLab.Text = "Логин";
            // 
            // PasLab
            // 
            this.PasLab.AutoSize = true;
            this.PasLab.Location = new System.Drawing.Point(19, 72);
            this.PasLab.Name = "PasLab";
            this.PasLab.Size = new System.Drawing.Size(45, 13);
            this.PasLab.TabIndex = 2;
            this.PasLab.Text = "Пароль";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(22, 34);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(126, 20);
            this.textBoxLog.TabIndex = 3;
            // 
            // textBoxPas
            // 
            this.textBoxPas.Location = new System.Drawing.Point(22, 88);
            this.textBoxPas.Name = "textBoxPas";
            this.textBoxPas.PasswordChar = '*';
            this.textBoxPas.Size = new System.Drawing.Size(126, 20);
            this.textBoxPas.TabIndex = 4;
            // 
            // AuthoF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 161);
            this.Controls.Add(this.textBoxPas);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.PasLab);
            this.Controls.Add(this.LoginLab);
            this.Controls.Add(this.AuthoBtn);
            this.MaximumSize = new System.Drawing.Size(250, 200);
            this.Name = "AuthoF";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AuthoBtn;
        private System.Windows.Forms.Label LoginLab;
        private System.Windows.Forms.Label PasLab;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TextBox textBoxPas;
    }
}

