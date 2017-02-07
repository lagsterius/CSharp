namespace RNC_MRIK_UCHET
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.mst_main = new System.Windows.Forms.MenuStrip();
            this.tsmi_file = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_change = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_spr = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_types = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_places = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_responsibles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_admin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_users = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvw_main = new System.Windows.Forms.ListView();
            this.tst_main = new System.Windows.Forms.ToolStrip();
            this.tsb_add = new System.Windows.Forms.ToolStripButton();
            this.tsb_copy = new System.Windows.Forms.ToolStripButton();
            this.tsb_edit = new System.Windows.Forms.ToolStripButton();
            this.tsb_delete = new System.Windows.Forms.ToolStripButton();
            this.cms_main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_add = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.mst_main.SuspendLayout();
            this.tst_main.SuspendLayout();
            this.cms_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // mst_main
            // 
            this.mst_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_file,
            this.tsmi_spr,
            this.tsmi_admin,
            this.помощьToolStripMenuItem});
            this.mst_main.Location = new System.Drawing.Point(0, 0);
            this.mst_main.Name = "mst_main";
            this.mst_main.Size = new System.Drawing.Size(1584, 24);
            this.mst_main.TabIndex = 0;
            this.mst_main.Text = "menuStrip1";
            // 
            // tsmi_file
            // 
            this.tsmi_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_change,
            this.tsmi_exit});
            this.tsmi_file.Image = global::RNC_MRIK_UCHET.Properties.Resources.file;
            this.tsmi_file.Name = "tsmi_file";
            this.tsmi_file.Size = new System.Drawing.Size(64, 20);
            this.tsmi_file.Text = "Файл";
            // 
            // tsmi_change
            // 
            this.tsmi_change.Image = global::RNC_MRIK_UCHET.Properties.Resources.change_user;
            this.tsmi_change.Name = "tsmi_change";
            this.tsmi_change.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.tsmi_change.Size = new System.Drawing.Size(238, 22);
            this.tsmi_change.Text = "Сменить пользователя";
            this.tsmi_change.Click += new System.EventHandler(this.tsmi_change_Click);
            // 
            // tsmi_exit
            // 
            this.tsmi_exit.Image = global::RNC_MRIK_UCHET.Properties.Resources.close;
            this.tsmi_exit.Name = "tsmi_exit";
            this.tsmi_exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsmi_exit.Size = new System.Drawing.Size(238, 22);
            this.tsmi_exit.Text = "Выйти";
            this.tsmi_exit.Click += new System.EventHandler(this.tsmi_exit_Click);
            // 
            // tsmi_spr
            // 
            this.tsmi_spr.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_types,
            this.tsmi_places,
            this.tsmi_responsibles});
            this.tsmi_spr.Image = global::RNC_MRIK_UCHET.Properties.Resources.spr;
            this.tsmi_spr.Name = "tsmi_spr";
            this.tsmi_spr.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.tsmi_spr.Size = new System.Drawing.Size(110, 20);
            this.tsmi_spr.Text = "Справочники";
            // 
            // tsmi_types
            // 
            this.tsmi_types.Image = global::RNC_MRIK_UCHET.Properties.Resources.devices;
            this.tsmi_types.Name = "tsmi_types";
            this.tsmi_types.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.tsmi_types.Size = new System.Drawing.Size(281, 22);
            this.tsmi_types.Text = "Типы оборудования";
            this.tsmi_types.Click += new System.EventHandler(this.tsmi_types_Click);
            // 
            // tsmi_places
            // 
            this.tsmi_places.Image = global::RNC_MRIK_UCHET.Properties.Resources.places;
            this.tsmi_places.Name = "tsmi_places";
            this.tsmi_places.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.tsmi_places.Size = new System.Drawing.Size(281, 22);
            this.tsmi_places.Text = "Места хранения оборудования";
            this.tsmi_places.Click += new System.EventHandler(this.tsmi_places_Click);
            // 
            // tsmi_responsibles
            // 
            this.tsmi_responsibles.Image = global::RNC_MRIK_UCHET.Properties.Resources.responsibles;
            this.tsmi_responsibles.Name = "tsmi_responsibles";
            this.tsmi_responsibles.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.tsmi_responsibles.Size = new System.Drawing.Size(281, 22);
            this.tsmi_responsibles.Text = "Ответственные";
            this.tsmi_responsibles.Click += new System.EventHandler(this.tsmi_responsibles_Click);
            // 
            // tsmi_admin
            // 
            this.tsmi_admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_users,
            this.настройкиToolStripMenuItem});
            this.tsmi_admin.Image = global::RNC_MRIK_UCHET.Properties.Resources.admin;
            this.tsmi_admin.Name = "tsmi_admin";
            this.tsmi_admin.Size = new System.Drawing.Size(150, 20);
            this.tsmi_admin.Text = "Администрирование";
            // 
            // tsmi_users
            // 
            this.tsmi_users.Image = global::RNC_MRIK_UCHET.Properties.Resources.users;
            this.tsmi_users.Name = "tsmi_users";
            this.tsmi_users.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U)));
            this.tsmi_users.Size = new System.Drawing.Size(190, 22);
            this.tsmi_users.Text = "Пользователи";
            this.tsmi_users.Click += new System.EventHandler(this.tsmi_users_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.Image = global::RNC_MRIK_UCHET.Properties.Resources.help;
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::RNC_MRIK_UCHET.Properties.Resources.about;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // lvw_main
            // 
            this.lvw_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvw_main.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvw_main.FullRowSelect = true;
            this.lvw_main.GridLines = true;
            this.lvw_main.Location = new System.Drawing.Point(12, 67);
            this.lvw_main.MultiSelect = false;
            this.lvw_main.Name = "lvw_main";
            this.lvw_main.Size = new System.Drawing.Size(1560, 782);
            this.lvw_main.TabIndex = 3;
            this.lvw_main.UseCompatibleStateImageBehavior = false;
            this.lvw_main.View = System.Windows.Forms.View.Details;
            this.lvw_main.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvw_main_ColumnClick);
            this.lvw_main.SelectedIndexChanged += new System.EventHandler(this.lvw_main_SelectedIndexChanged);
            this.lvw_main.DoubleClick += new System.EventHandler(this.lvw_main_DoubleClick);
            this.lvw_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvw_main_MouseUp);
            // 
            // tst_main
            // 
            this.tst_main.AutoSize = false;
            this.tst_main.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tst_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_add,
            this.tsb_copy,
            this.tsb_edit,
            this.tsb_delete});
            this.tst_main.Location = new System.Drawing.Point(0, 24);
            this.tst_main.Name = "tst_main";
            this.tst_main.Size = new System.Drawing.Size(1584, 40);
            this.tst_main.TabIndex = 4;
            this.tst_main.Text = "toolStrip1";
            // 
            // tsb_add
            // 
            this.tsb_add.Image = global::RNC_MRIK_UCHET.Properties.Resources.add;
            this.tsb_add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_add.Name = "tsb_add";
            this.tsb_add.Size = new System.Drawing.Size(104, 37);
            this.tsb_add.Text = "Добавить";
            this.tsb_add.ToolTipText = "Добавить оборудование";
            this.tsb_add.Click += new System.EventHandler(this.tsb_add_Click);
            // 
            // tsb_copy
            // 
            this.tsb_copy.Enabled = false;
            this.tsb_copy.Image = global::RNC_MRIK_UCHET.Properties.Resources.add_copy;
            this.tsb_copy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_copy.Name = "tsb_copy";
            this.tsb_copy.Size = new System.Drawing.Size(121, 37);
            this.tsb_copy.Text = "Копировать";
            this.tsb_copy.ToolTipText = "Добавить оборудование копированием выбранного элемента";
            this.tsb_copy.Click += new System.EventHandler(this.tsb_copy_Click);
            // 
            // tsb_edit
            // 
            this.tsb_edit.Enabled = false;
            this.tsb_edit.Image = global::RNC_MRIK_UCHET.Properties.Resources.edit;
            this.tsb_edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_edit.Name = "tsb_edit";
            this.tsb_edit.Size = new System.Drawing.Size(139, 37);
            this.tsb_edit.Text = "Редактировать";
            this.tsb_edit.ToolTipText = "Редактировать выбранный элемент";
            this.tsb_edit.Click += new System.EventHandler(this.tsb_edit_Click);
            // 
            // tsb_delete
            // 
            this.tsb_delete.Enabled = false;
            this.tsb_delete.Image = global::RNC_MRIK_UCHET.Properties.Resources.delete;
            this.tsb_delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_delete.Name = "tsb_delete";
            this.tsb_delete.Size = new System.Drawing.Size(93, 37);
            this.tsb_delete.Text = "Удалить";
            this.tsb_delete.ToolTipText = "Удалить выбранный элемент";
            this.tsb_delete.Click += new System.EventHandler(this.tsb_delete_Click);
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
            this.tsmi_add.Click += new System.EventHandler(this.tsmi_add_Click);
            // 
            // tsmi_copy
            // 
            this.tsmi_copy.Image = global::RNC_MRIK_UCHET.Properties.Resources.add_copy;
            this.tsmi_copy.Name = "tsmi_copy";
            this.tsmi_copy.Size = new System.Drawing.Size(154, 22);
            this.tsmi_copy.Text = "Копировать";
            this.tsmi_copy.Visible = false;
            this.tsmi_copy.Click += new System.EventHandler(this.tsmi_copy_Click);
            // 
            // tsmi_edit
            // 
            this.tsmi_edit.Image = global::RNC_MRIK_UCHET.Properties.Resources.edit;
            this.tsmi_edit.Name = "tsmi_edit";
            this.tsmi_edit.Size = new System.Drawing.Size(154, 22);
            this.tsmi_edit.Text = "Редактировать";
            this.tsmi_edit.Visible = false;
            this.tsmi_edit.Click += new System.EventHandler(this.tsmi_edit_Click);
            // 
            // tsmi_delete
            // 
            this.tsmi_delete.Image = global::RNC_MRIK_UCHET.Properties.Resources.delete;
            this.tsmi_delete.Name = "tsmi_delete";
            this.tsmi_delete.Size = new System.Drawing.Size(154, 22);
            this.tsmi_delete.Text = "Удалить";
            this.tsmi_delete.Visible = false;
            this.tsmi_delete.Click += new System.EventHandler(this.tsmi_delete_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.tst_main);
            this.Controls.Add(this.lvw_main);
            this.Controls.Add(this.mst_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mst_main;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_main_FormClosed);
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.mst_main.ResumeLayout(false);
            this.mst_main.PerformLayout();
            this.tst_main.ResumeLayout(false);
            this.tst_main.PerformLayout();
            this.cms_main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mst_main;
        private System.Windows.Forms.ToolStripMenuItem tsmi_file;
        private System.Windows.Forms.ToolStripMenuItem tsmi_exit;
        private System.Windows.Forms.ToolStripMenuItem tsmi_change;
        private System.Windows.Forms.ToolStripMenuItem tsmi_spr;
        private System.Windows.Forms.ToolStripMenuItem tsmi_types;
        private System.Windows.Forms.ToolStripMenuItem tsmi_places;
        private System.Windows.Forms.ToolStripMenuItem tsmi_admin;
        private System.Windows.Forms.ToolStripMenuItem tsmi_users;
        public System.Windows.Forms.ListView lvw_main;
        private System.Windows.Forms.ToolStrip tst_main;
        private System.Windows.Forms.ToolStripButton tsb_add;
        private System.Windows.Forms.ToolStripButton tsb_copy;
        private System.Windows.Forms.ToolStripButton tsb_delete;
        private System.Windows.Forms.ToolStripButton tsb_edit;
        private System.Windows.Forms.ToolStripMenuItem tsmi_responsibles;
        private System.Windows.Forms.ContextMenuStrip cms_main;
        private System.Windows.Forms.ToolStripMenuItem tsmi_copy;
        private System.Windows.Forms.ToolStripMenuItem tsmi_edit;
        private System.Windows.Forms.ToolStripMenuItem tsmi_delete;
        private System.Windows.Forms.ToolStripMenuItem tsmi_add;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
    }
}