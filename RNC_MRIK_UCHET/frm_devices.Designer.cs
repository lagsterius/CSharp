namespace RNC_MRIK_UCHET
{
    partial class frm_devices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_devices));
            this.lbl_type = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.cmb_place = new System.Windows.Forms.ComboBox();
            this.lbl_place = new System.Windows.Forms.Label();
            this.cmb_responsible = new System.Windows.Forms.ComboBox();
            this.lbl_responsible = new System.Windows.Forms.Label();
            this.lbl_inv = new System.Windows.Forms.Label();
            this.txt_inv = new System.Windows.Forms.TextBox();
            this.chb_iswork = new System.Windows.Forms.CheckBox();
            this.chb_isspis = new System.Windows.Forms.CheckBox();
            this.rtb_comment = new System.Windows.Forms.RichTextBox();
            this.lbl_comment = new System.Windows.Forms.Label();
            this.tst_main = new System.Windows.Forms.ToolStrip();
            this.tsb_save_exit = new System.Windows.Forms.ToolStripButton();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.tsb_cancel = new System.Windows.Forms.ToolStripButton();
            this.txt_details = new System.Windows.Forms.TextBox();
            this.lbl_details = new System.Windows.Forms.Label();
            this.chb_inv = new System.Windows.Forms.CheckBox();
            this.tst_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_type
            // 
            this.lbl_type.Location = new System.Drawing.Point(10, 28);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(245, 21);
            this.lbl_type.TabIndex = 0;
            this.lbl_type.Text = "Тип оборудования:";
            this.lbl_type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_type
            // 
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(265, 28);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(245, 21);
            this.cmb_type.TabIndex = 1;
            this.cmb_type.TextChanged += new System.EventHandler(this.txt_changed);
            // 
            // cmb_place
            // 
            this.cmb_place.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_place.FormattingEnabled = true;
            this.cmb_place.Location = new System.Drawing.Point(265, 88);
            this.cmb_place.Name = "cmb_place";
            this.cmb_place.Size = new System.Drawing.Size(245, 21);
            this.cmb_place.TabIndex = 3;
            this.cmb_place.TextChanged += new System.EventHandler(this.txt_changed);
            // 
            // lbl_place
            // 
            this.lbl_place.Location = new System.Drawing.Point(10, 88);
            this.lbl_place.Name = "lbl_place";
            this.lbl_place.Size = new System.Drawing.Size(245, 21);
            this.lbl_place.TabIndex = 2;
            this.lbl_place.Text = "Размещение:";
            this.lbl_place.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_responsible
            // 
            this.cmb_responsible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_responsible.FormattingEnabled = true;
            this.cmb_responsible.Location = new System.Drawing.Point(265, 118);
            this.cmb_responsible.Name = "cmb_responsible";
            this.cmb_responsible.Size = new System.Drawing.Size(245, 21);
            this.cmb_responsible.TabIndex = 4;
            this.cmb_responsible.TextChanged += new System.EventHandler(this.txt_changed);
            // 
            // lbl_responsible
            // 
            this.lbl_responsible.Location = new System.Drawing.Point(10, 118);
            this.lbl_responsible.Name = "lbl_responsible";
            this.lbl_responsible.Size = new System.Drawing.Size(245, 21);
            this.lbl_responsible.TabIndex = 4;
            this.lbl_responsible.Text = "Ответственный:";
            this.lbl_responsible.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_inv
            // 
            this.lbl_inv.Location = new System.Drawing.Point(10, 148);
            this.lbl_inv.Name = "lbl_inv";
            this.lbl_inv.Size = new System.Drawing.Size(245, 21);
            this.lbl_inv.TabIndex = 6;
            this.lbl_inv.Text = "Инвентарный номер (макс. 20 символов):";
            this.lbl_inv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_inv
            // 
            this.txt_inv.Location = new System.Drawing.Point(265, 148);
            this.txt_inv.MaxLength = 20;
            this.txt_inv.Name = "txt_inv";
            this.txt_inv.Size = new System.Drawing.Size(149, 20);
            this.txt_inv.TabIndex = 5;
            this.txt_inv.TextChanged += new System.EventHandler(this.txt_changed);
            // 
            // chb_iswork
            // 
            this.chb_iswork.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_iswork.Location = new System.Drawing.Point(10, 178);
            this.chb_iswork.Name = "chb_iswork";
            this.chb_iswork.Size = new System.Drawing.Size(245, 21);
            this.chb_iswork.TabIndex = 7;
            this.chb_iswork.Text = "Рабочее оборудование:";
            this.chb_iswork.UseVisualStyleBackColor = true;
            this.chb_iswork.CheckedChanged += new System.EventHandler(this.txt_changed);
            // 
            // chb_isspis
            // 
            this.chb_isspis.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_isspis.Location = new System.Drawing.Point(265, 178);
            this.chb_isspis.Name = "chb_isspis";
            this.chb_isspis.Size = new System.Drawing.Size(245, 21);
            this.chb_isspis.TabIndex = 8;
            this.chb_isspis.Text = "Списанное оборудование:";
            this.chb_isspis.UseVisualStyleBackColor = true;
            this.chb_isspis.CheckedChanged += new System.EventHandler(this.txt_changed);
            // 
            // rtb_comment
            // 
            this.rtb_comment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_comment.Location = new System.Drawing.Point(10, 238);
            this.rtb_comment.MaxLength = 100;
            this.rtb_comment.Name = "rtb_comment";
            this.rtb_comment.Size = new System.Drawing.Size(502, 35);
            this.rtb_comment.TabIndex = 9;
            this.rtb_comment.Text = "";
            this.rtb_comment.TextChanged += new System.EventHandler(this.txt_changed);
            // 
            // lbl_comment
            // 
            this.lbl_comment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_comment.Location = new System.Drawing.Point(10, 208);
            this.lbl_comment.Name = "lbl_comment";
            this.lbl_comment.Size = new System.Drawing.Size(502, 21);
            this.lbl_comment.TabIndex = 11;
            this.lbl_comment.Text = "Комментарий (макс. 100 символов)";
            this.lbl_comment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tst_main
            // 
            this.tst_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_save_exit,
            this.tsb_save,
            this.tsb_cancel});
            this.tst_main.Location = new System.Drawing.Point(0, 0);
            this.tst_main.Name = "tst_main";
            this.tst_main.Size = new System.Drawing.Size(522, 25);
            this.tst_main.TabIndex = 12;
            this.tst_main.Text = "toolStrip1";
            // 
            // tsb_save_exit
            // 
            this.tsb_save_exit.Enabled = false;
            this.tsb_save_exit.Image = global::RNC_MRIK_UCHET.Properties.Resources.close_save;
            this.tsb_save_exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_save_exit.Name = "tsb_save_exit";
            this.tsb_save_exit.Size = new System.Drawing.Size(142, 22);
            this.tsb_save_exit.Text = "Сохранить и закрыть";
            this.tsb_save_exit.ToolTipText = "Сохранить сделанные изменения и закрыть форму";
            this.tsb_save_exit.Click += new System.EventHandler(this.tsb_save_exit_Click);
            // 
            // tsb_save
            // 
            this.tsb_save.Enabled = false;
            this.tsb_save.Image = global::RNC_MRIK_UCHET.Properties.Resources.save;
            this.tsb_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_save.Name = "tsb_save";
            this.tsb_save.Size = new System.Drawing.Size(85, 22);
            this.tsb_save.Text = "Сохранить";
            this.tsb_save.ToolTipText = "Сохранить внесенные изменения";
            this.tsb_save.Click += new System.EventHandler(this.tsb_save_Click);
            // 
            // tsb_cancel
            // 
            this.tsb_cancel.Enabled = false;
            this.tsb_cancel.Image = global::RNC_MRIK_UCHET.Properties.Resources.cancel;
            this.tsb_cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_cancel.Name = "tsb_cancel";
            this.tsb_cancel.Size = new System.Drawing.Size(81, 22);
            this.tsb_cancel.Text = "Отменить";
            this.tsb_cancel.ToolTipText = "Вернуть к исходному виду";
            this.tsb_cancel.Click += new System.EventHandler(this.tsb_cancel_Click);
            // 
            // txt_details
            // 
            this.txt_details.Location = new System.Drawing.Point(265, 58);
            this.txt_details.MaxLength = 50;
            this.txt_details.Name = "txt_details";
            this.txt_details.Size = new System.Drawing.Size(245, 20);
            this.txt_details.TabIndex = 2;
            this.txt_details.TextChanged += new System.EventHandler(this.txt_changed);
            // 
            // lbl_details
            // 
            this.lbl_details.Location = new System.Drawing.Point(10, 58);
            this.lbl_details.Name = "lbl_details";
            this.lbl_details.Size = new System.Drawing.Size(245, 21);
            this.lbl_details.TabIndex = 13;
            this.lbl_details.Text = "Описание (макс. 50 символов):";
            this.lbl_details.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chb_inv
            // 
            this.chb_inv.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_inv.Location = new System.Drawing.Point(420, 148);
            this.chb_inv.Name = "chb_inv";
            this.chb_inv.Size = new System.Drawing.Size(90, 20);
            this.chb_inv.TabIndex = 6;
            this.chb_inv.Text = "Без номера";
            this.chb_inv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_inv.UseVisualStyleBackColor = true;
            this.chb_inv.CheckedChanged += new System.EventHandler(this.txt_changed);
            // 
            // frm_devices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 284);
            this.Controls.Add(this.chb_inv);
            this.Controls.Add(this.txt_details);
            this.Controls.Add(this.lbl_details);
            this.Controls.Add(this.tst_main);
            this.Controls.Add(this.lbl_comment);
            this.Controls.Add(this.rtb_comment);
            this.Controls.Add(this.chb_isspis);
            this.Controls.Add(this.chb_iswork);
            this.Controls.Add(this.txt_inv);
            this.Controls.Add(this.lbl_inv);
            this.Controls.Add(this.cmb_responsible);
            this.Controls.Add(this.lbl_responsible);
            this.Controls.Add(this.cmb_place);
            this.Controls.Add(this.lbl_place);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.lbl_type);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_devices";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_devices_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_devices_FormClosed);
            this.Load += new System.EventHandler(this.frm_devices_Load);
            this.tst_main.ResumeLayout(false);
            this.tst_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.ComboBox cmb_place;
        private System.Windows.Forms.Label lbl_place;
        private System.Windows.Forms.ComboBox cmb_responsible;
        private System.Windows.Forms.Label lbl_responsible;
        private System.Windows.Forms.Label lbl_inv;
        private System.Windows.Forms.TextBox txt_inv;
        private System.Windows.Forms.CheckBox chb_iswork;
        private System.Windows.Forms.CheckBox chb_isspis;
        private System.Windows.Forms.RichTextBox rtb_comment;
        private System.Windows.Forms.Label lbl_comment;
        private System.Windows.Forms.ToolStrip tst_main;
        private System.Windows.Forms.ToolStripButton tsb_save_exit;
        private System.Windows.Forms.ToolStripButton tsb_save;
        private System.Windows.Forms.ToolStripButton tsb_cancel;
        private System.Windows.Forms.TextBox txt_details;
        private System.Windows.Forms.Label lbl_details;
        private System.Windows.Forms.CheckBox chb_inv;
    }
}