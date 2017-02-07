namespace RNC_MRIK_UCHET
{
    partial class frm_spr
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_spr));
            this.cms_main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_add = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tst_main = new System.Windows.Forms.ToolStrip();
            this.tsb_add = new System.Windows.Forms.ToolStripButton();
            this.tsb_addcopy = new System.Windows.Forms.ToolStripButton();
            this.tsb_edit = new System.Windows.Forms.ToolStripButton();
            this.tsb_delete = new System.Windows.Forms.ToolStripButton();
            this.lvw_main = new System.Windows.Forms.ListView();
            this.cms_main.SuspendLayout();
            this.tst_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // cms_main
            // 
            this.cms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_add,
            this.tsmi_copy,
            this.tsmi_edit,
            this.tsmi_delete});
            this.cms_main.Name = "cms_main";
            this.cms_main.Size = new System.Drawing.Size(155, 92);
            // 
            // tsmi_add
            // 
            this.tsmi_add.Image = global::RNC_MRIK_UCHET.Properties.Resources.add;
            this.tsmi_add.Name = "tsmi_add";
            this.tsmi_add.Size = new System.Drawing.Size(154, 22);
            this.tsmi_add.Text = "Добавить";
            this.tsmi_add.Visible = false;
            // 
            // tsmi_copy
            // 
            this.tsmi_copy.Image = global::RNC_MRIK_UCHET.Properties.Resources.add_copy;
            this.tsmi_copy.Name = "tsmi_copy";
            this.tsmi_copy.Size = new System.Drawing.Size(154, 22);
            this.tsmi_copy.Text = "Копировать";
            this.tsmi_copy.Visible = false;
            // 
            // tsmi_edit
            // 
            this.tsmi_edit.Image = global::RNC_MRIK_UCHET.Properties.Resources.edit;
            this.tsmi_edit.Name = "tsmi_edit";
            this.tsmi_edit.Size = new System.Drawing.Size(154, 22);
            this.tsmi_edit.Text = "Редактировать";
            this.tsmi_edit.Visible = false;
            // 
            // tsmi_delete
            // 
            this.tsmi_delete.Image = global::RNC_MRIK_UCHET.Properties.Resources.delete;
            this.tsmi_delete.Name = "tsmi_delete";
            this.tsmi_delete.Size = new System.Drawing.Size(154, 22);
            this.tsmi_delete.Text = "Удалить";
            this.tsmi_delete.Visible = false;
            // 
            // tst_main
            // 
            this.tst_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_add,
            this.tsb_addcopy,
            this.tsb_edit,
            this.tsb_delete});
            this.tst_main.Location = new System.Drawing.Point(0, 0);
            this.tst_main.Name = "tst_main";
            this.tst_main.Size = new System.Drawing.Size(530, 25);
            this.tst_main.TabIndex = 5;
            this.tst_main.Text = "toolStrip1";
            // 
            // tsb_add
            // 
            this.tsb_add.Image = global::RNC_MRIK_UCHET.Properties.Resources.add;
            this.tsb_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_add.Name = "tsb_add";
            this.tsb_add.Size = new System.Drawing.Size(79, 22);
            this.tsb_add.Text = "Добавить";
            this.tsb_add.ToolTipText = "Добавить оборудование";
            // 
            // tsb_addcopy
            // 
            this.tsb_addcopy.Image = global::RNC_MRIK_UCHET.Properties.Resources.add_copy;
            this.tsb_addcopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_addcopy.Name = "tsb_addcopy";
            this.tsb_addcopy.Size = new System.Drawing.Size(92, 22);
            this.tsb_addcopy.Text = "Копировать";
            this.tsb_addcopy.ToolTipText = "Добавить оборудование копированием выбранного элемента";
            // 
            // tsb_edit
            // 
            this.tsb_edit.Image = global::RNC_MRIK_UCHET.Properties.Resources.edit;
            this.tsb_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_edit.Name = "tsb_edit";
            this.tsb_edit.Size = new System.Drawing.Size(107, 22);
            this.tsb_edit.Text = "Редактировать";
            this.tsb_edit.ToolTipText = "Редактировать выбранный элемент";
            // 
            // tsb_delete
            // 
            this.tsb_delete.Image = global::RNC_MRIK_UCHET.Properties.Resources.delete;
            this.tsb_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_delete.Name = "tsb_delete";
            this.tsb_delete.Size = new System.Drawing.Size(71, 22);
            this.tsb_delete.Text = "Удалить";
            this.tsb_delete.ToolTipText = "Удалить выбранный элемент";
            // 
            // lvw_main
            // 
            this.lvw_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvw_main.BackColor = System.Drawing.SystemColors.Window;
            this.lvw_main.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvw_main.FullRowSelect = true;
            this.lvw_main.GridLines = true;
            this.lvw_main.Location = new System.Drawing.Point(12, 28);
            this.lvw_main.MultiSelect = false;
            this.lvw_main.Name = "lvw_main";
            this.lvw_main.Size = new System.Drawing.Size(506, 369);
            this.lvw_main.TabIndex = 6;
            this.lvw_main.UseCompatibleStateImageBehavior = false;
            this.lvw_main.View = System.Windows.Forms.View.Details;
            // 
            // frm_spr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 409);
            this.Controls.Add(this.lvw_main);
            this.Controls.Add(this.tst_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_spr";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_spr_FormClosed);
            this.Load += new System.EventHandler(this.frm_spr_Load);
            this.cms_main.ResumeLayout(false);
            this.tst_main.ResumeLayout(false);
            this.tst_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cms_main;
        private System.Windows.Forms.ToolStripMenuItem tsmi_add;
        private System.Windows.Forms.ToolStripMenuItem tsmi_copy;
        private System.Windows.Forms.ToolStripMenuItem tsmi_edit;
        private System.Windows.Forms.ToolStripMenuItem tsmi_delete;
        private System.Windows.Forms.ToolStrip tst_main;
        private System.Windows.Forms.ToolStripButton tsb_add;
        private System.Windows.Forms.ToolStripButton tsb_addcopy;
        private System.Windows.Forms.ToolStripButton tsb_edit;
        private System.Windows.Forms.ToolStripButton tsb_delete;
        private System.Windows.Forms.ListView lvw_main;
    }
}