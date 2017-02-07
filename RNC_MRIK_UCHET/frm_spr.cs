using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RNC_MRIK_UCHET
{
    public partial class frm_spr : Form
    {
        sql_class SC = new sql_class();
        my_class MC = new my_class();
        public byte spr;

        public frm_spr()
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

        private void frm_spr_Load(object sender, EventArgs e)
        {
            lvw_main.Columns.Add("ID");

            if (spr == 0)
            {
                //SC.query("Select ID, Type From Types");

                SC.query(0,
                    "ID, Type",
                    "Types");

                lvw_main.Columns.Add("Наименование");
                while (SC.dr.Read())
                {
                    lvw_main.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    lvw_main.Items.Add(new ListViewItem(new[] { SC.dr_read(0), SC.dr_read(1) })).BackColor = MC.myColor(lvw_main.Items.Count);
                }
            }
            else if (spr == 1)
            {
                //SC.query("Select ID, Place, Room, Floor From Places");

                SC.query(0,
                    "ID, Place, Room, Floor",
                    "Places");

                lvw_main.Columns.Add("Название");
                lvw_main.Columns.Add("Комната/Кабинет");
                lvw_main.Columns.Add("Этаж");
                while (SC.dr.Read())
                {
                    lvw_main.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    lvw_main.Items.Add(new ListViewItem(new[] { SC.dr_read(0), SC.dr_read(1), SC.dr_read(2), SC.dr_read(3) })).BackColor = MC.myColor(lvw_main.Items.Count);
                }
            }
            else
            {
                //SC.query("Select Responsibles.ID, Peoples.Surname, Peoples.Name, Peoples.FatherName From Responsibles, Peoples where Responsibles.PeopleID = Peoples.ID");

                SC.query(0,
                    "Responsibles.ID, Peoples.Surname, Peoples.Name, Peoples.FatherName",
                    null,
                    "Responsibles.PeopleID = Peoples.ID");
                
                lvw_main.Columns.Add("Фамилия");
                lvw_main.Columns.Add("Имя");
                lvw_main.Columns.Add("Отчество");
                while (SC.dr.Read())
                {
                    lvw_main.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    lvw_main.Items.Add(new ListViewItem(new[] { SC.dr_read(0), SC.dr_read(1), SC.dr_read(2), SC.dr_read(3) })).BackColor = MC.myColor(lvw_main.Items.Count);
                }
            }
            SC.conn.Close();
        }

        private void frm_spr_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["frm_main"].Enabled = true;
            Application.OpenForms["frm_main"].Opacity = 1;
        }
    }
}
