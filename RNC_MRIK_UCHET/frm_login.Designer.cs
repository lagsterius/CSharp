namespace RNC_MRIK_UCHET
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.ptb_logo = new System.Windows.Forms.PictureBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.cmb_login = new System.Windows.Forms.ComboBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_logo
            // 
            this.ptb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_logo.ErrorImage = global::RNC_MRIK_UCHET.Properties.Resources.logo;
            this.ptb_logo.Image = global::RNC_MRIK_UCHET.Properties.Resources.logo;
            this.ptb_logo.InitialImage = global::RNC_MRIK_UCHET.Properties.Resources.logo;
            this.ptb_logo.Location = new System.Drawing.Point(10, 15);
            this.ptb_logo.Name = "ptb_logo";
            this.ptb_logo.Size = new System.Drawing.Size(225, 120);
            this.ptb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_logo.TabIndex = 0;
            this.ptb_logo.TabStop = false;
            // 
            // lbl_login
            // 
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(240, 10);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(200, 20);
            this.lbl_login.TabIndex = 1;
            this.lbl_login.Text = "Имя пользователя";
            this.lbl_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_login
            // 
            this.cmb_login.FormattingEnabled = true;
            this.cmb_login.Location = new System.Drawing.Point(240, 30);
            this.cmb_login.Name = "cmb_login";
            this.cmb_login.Size = new System.Drawing.Size(200, 21);
            this.cmb_login.TabIndex = 2;
            this.cmb_login.SelectedIndexChanged += new System.EventHandler(this.txt_Changed);
            this.cmb_login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lbl_pass
            // 
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(240, 55);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(200, 20);
            this.lbl_pass.TabIndex = 3;
            this.lbl_pass.Text = "Пароль";
            this.lbl_pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(240, 75);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(200, 20);
            this.txt_pass.TabIndex = 4;
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_Changed);
            this.txt_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // btn_login
            // 
            this.btn_login.Enabled = false;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Location = new System.Drawing.Point(240, 105);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(200, 25);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Войти";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 146);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.cmb_login);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.ptb_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_logo;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.ComboBox cmb_login;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btn_login;
    }
}

