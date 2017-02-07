using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace RNC_MRIK_UCHET
{
    public partial class frm_main : Form
    {
        sql_class SC = new sql_class();
        frm_login FL = new frm_login();
        my_class MC = new my_class();
        frm_devices FD;
        frm_spr FS;

        bool sw = true;
        public int sortColumn = -1;
        DialogResult drs;

        public frm_main()
        {
            InitializeComponent();
            try
            {
                SC.conn.Open();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
                Environment.Exit(0);
            }
            SC.conn.Close();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            lvw_main.Columns.Add("ID");
            lvw_main.Columns.Add("Тип оборудования");
            lvw_main.Columns.Add("Описание");
            lvw_main.Columns.Add("Размещение");
            lvw_main.Columns.Add("Подразделение");
            lvw_main.Columns.Add("Инвентарный номер");
            lvw_main.Columns.Add("Ответственный");
            lvw_main.Columns.Add("На учете");
            lvw_main.Columns.Add("Состояние");
            lvw_main.Columns.Add("Комментарий");
            lvw_main.Columns.Add("Дата создания/изменения");

            ListViewItem lvi;
            SC.query(0);

            while (SC.dr.Read())
            {
                lvi = new ListViewItem(new[] { SC.dr_read(0), SC.dr_read(1), SC.dr_read(12), (SC.dr_read(3) == "" ? SC.dr_read(2) + " (" + SC.dr_read(4) + " эт.)" : SC.dr_read(2) + " (" + SC.dr_read(3) + " каб., " + SC.dr_read(4) + " эт.)"), SC.dr_read(14), SC.dr_read(5), SC.dr_read(6) + ' ' + SC.dr_read(7).Substring(0, 1) + ". " + SC.dr_read(8).Substring(0, 1) + '.', Convert.ToBoolean(SC.dr_read(10)) ? "Списан" : "На учете", Convert.ToBoolean(SC.dr_read(9)) ? "Рабочее" : "Сломано", SC.dr_read(11), SC.dr_read(13) });
                lvw_main.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                lvw_main.Items.Add(lvi).BackColor = MC.myColor(lvw_main.Items.Count, Convert.ToBoolean(SC.dr_read(9)));
            }
            SC.conn.Close();
        }

        private void frm_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sw) Environment.Exit(0);
        }

        private void tsmi_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void tsmi_change_Click(object sender, EventArgs e)
        {
            FL.Show();
            sw = false;
            this.Close();
        }

        private void lvw_main_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != sortColumn)
            {
                sortColumn = e.Column;
                ((ListView)sender).Sorting = System.Windows.Forms.SortOrder.Ascending;
            }
            else
            {
                if (((ListView)sender).Sorting == System.Windows.Forms.SortOrder.Ascending)
                    ((ListView)sender).Sorting = System.Windows.Forms.SortOrder.Descending;
                else
                    ((ListView)sender).Sorting = System.Windows.Forms.SortOrder.Ascending;
            }

            ((ListView)sender).ListViewItemSorter = new ListViewItemComparer(e.Column, ((ListView)sender).Sorting);
            ((ListView)sender).Sort();
            re_color();
        }

        private void lvw_main_DoubleClick(object sender, EventArgs e)
        {
            add_copy_edit_f(sender, 2);
        }

        private void tsb_add_Click(object sender, EventArgs e)
        {
            add_copy_edit_f(sender, 0);
        }

        private void tsb_copy_Click(object sender, EventArgs e)
        {
            add_copy_edit_f(sender, 1);
        }

        private void tsb_edit_Click(object sender, EventArgs e)
        {
            add_copy_edit_f(sender, 2);
        }

        private void tsb_delete_Click(object sender, EventArgs e)
        {
            del();
        }

        private void tsmi_types_Click(object sender, EventArgs e)
        {
            tsmi_spr_f(sender, 0);
        }

        private void tsmi_places_Click(object sender, EventArgs e)
        {
            tsmi_spr_f(sender, 1);
        }

        private void tsmi_responsibles_Click(object sender, EventArgs e)
        {
            tsmi_spr_f(sender, 2);
        }

        private void tsmi_users_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Типа админка");
        }

        private void lvw_main_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvw_main.SelectedItems.Count == 0)
                {
                    tsmi_add.Visible = true;
                    tsmi_copy.Visible = false;
                    tsmi_edit.Visible = false;
                    tsmi_delete.Visible = false;
                }
                else
                {
                    tsmi_add.Visible = false;
                    tsmi_copy.Visible = true;
                    tsmi_edit.Visible = true;
                    tsmi_delete.Visible = true;
                }

                cms_main.Show(new Point(Cursor.Position.X, Cursor.Position.Y));
            }
        }

        private void tsmi_add_Click(object sender, EventArgs e)
        {
            add_copy_edit_f(sender, 0);
        }

        private void tsmi_copy_Click(object sender, EventArgs e)
        {
            add_copy_edit_f(sender, 1);
        }

        private void tsmi_edit_Click(object sender, EventArgs e)
        {
            add_copy_edit_f(sender, 2);
        }

        private void tsmi_delete_Click(object sender, EventArgs e)
        {
            del();
        }

        public void del()
        {
            drs = MessageBox.Show("Вы действительно хотите удалить выбранный элемент", "Подтверждение удаления", MessageBoxButtons.OKCancel);
            if (drs == DialogResult.OK)
            {
                tsb_copy.Enabled = false;
                tsb_delete.Enabled = false;
                tsb_edit.Enabled = false;

                //SC.query("Delete From Devices where ID = " + lvw_main.SelectedItems[0].Text, true);
                
                SC.query(3,
                    null,
                    "Devices",
                    "ID = " + lvw_main.SelectedItems[0].Text);
                
                lvw_main.SelectedItems[0].Remove();
            }
            re_color();
        }

        private void tsmi_spr_f(object sender, byte spr)
        {
            FS = new frm_spr();
            FS.spr = spr;
            FS.Show();
            FS.Location = MC.myCenter(this, FS);
            FS.Text = "Справочник \"" + ((ToolStripMenuItem)sender).Text + '\"';
            this.Enabled = false;
            this.Opacity = .9;
        }

        private void add_copy_edit_f(object sender, byte t)
        {
            FD = new frm_devices();
            FD.t = t;
            FD.sortColumn = sortColumn;
            FD.order = lvw_main.Sorting;
            if (t > 0)
            {
                if (t == 2)
                    FD.ID_device = Convert.ToInt16(sub_text(0));
                FD.type_text = sub_text(1);
                FD.place_text = sub_text(3);
                FD.responsible_text = sub_text(6);
                FD.invNum_text = sub_text(5);
                FD.isWork = sub_text(8) == "Сломано" ? false : true;
                FD.isSpis = sub_text(7) == "Списан" ? true : false;
                FD.comment_text = sub_text(9);
                FD.details_text = sub_text(2);
            }
            FD.Show();
            FD.Location = MC.myCenter(this, FD);
            FD.Text = t == 2 ? "Редактирование: " + sub_text(1) + " (" + sub_text(3) + ')' : "Добавление нового оборудования";
            this.Enabled = false;
            this.Opacity = .9;
        }

        private string sub_text(int n)
        {
            return lvw_main.SelectedItems[0].SubItems[n].Text;
        }

        public void re_color()
        {
            for (int i = 0; i < lvw_main.Items.Count; i++)
                lvw_main.Items[i].BackColor = MC.myColor(i + 1, lvw_main.Items[i].SubItems[8].Text == "Рабочее" ? true : false);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Учет оборудования\nlagsterius@gmail.com\n© 2015", "О программе");
        }

        private void lvw_main_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvw_main.SelectedItems.Count == 0)
            {
                tsb_copy.Enabled = false;
                tsb_edit.Enabled = false;
                tsb_delete.Enabled = false;
            }
            else
            {
                tsb_copy.Enabled = true;
                tsb_edit.Enabled = true;
                tsb_delete.Enabled = true;
            }
        }
    }
}
