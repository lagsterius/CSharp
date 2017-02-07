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
    public partial class frm_devices : Form
    {
        sql_class SC = new sql_class();
        my_class MC = new my_class();

        public byte t;
        public System.Windows.Forms.SortOrder order;
        public string type_text, place_text, responsible_text, invNum_text, comment_text, details_text;
        public bool isWork, isSpis, CloseError, JustClose;
        public int ID_device, sortColumn, i = 0;

        List<byte> ID_places = new List<byte>();
        List<byte> ID_types = new List<byte>();
        List<byte> ID_responsibles = new List<byte>();

        public frm_devices()
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

        private void frm_devices_Load(object sender, EventArgs e)
        {
            //SC.query("select ID, Type from Types order by Type");

            SC.query(0,
                "ID, Type",
                "Types",
                null,
                null,
                "Type");

            while (SC.dr.Read())
            {
                ID_types.Add(Convert.ToByte(SC.dr_read(0)));
                cmb_type.Items.Add(SC.dr_read(1));
            }
            SC.conn.Close();

            //SC.query("select ID, Place, Room, Floor from Places order by place");

            SC.query(0,
                "ID, Place, Room, Floor",
                "Places",
                null,
                null,
                "Place");

            while (SC.dr.Read())
            {
                ID_places.Add(Convert.ToByte(SC.dr_read(0)));
                cmb_place.Items.Add((SC.dr_read(2) == "" ? SC.dr_read(1) + " (" + SC.dr_read(3) + " эт.)" : SC.dr_read(1) + " (" + SC.dr_read(2) + " каб., " + SC.dr_read(3) + " эт.)"));
            }
            SC.conn.Close();

            //SC.query("select Responsibles.ID, Peoples.Surname, Peoples.Name, Peoples.FatherName from Responsibles, Peoples where Peoples.ID = Responsibles.peopleID order by Surname, Name, FatherName");

            SC.query(0,
                "Responsibles.ID, Peoples.Surname, Peoples.Name, Peoples.FatherName",
                null,
                "Peoples.ID = Responsibles.PeopleID",
                null,
                "Surname, Name, FatherName");

            while (SC.dr.Read())
            {
                ID_responsibles.Add(Convert.ToByte(SC.dr_read(0)));
                cmb_responsible.Items.Add(SC.dr_read(1) + ' ' + SC.dr_read(2).Substring(0, 1) + ". " + SC.dr_read(3).Substring(0, 1) + '.');
            }
            SC.conn.Close();

            if (t > 0)
            {
                cmb_type.Text = type_text;
                txt_details.Text = details_text;
                cmb_place.Text = place_text;
                cmb_responsible.Text = responsible_text;
                txt_inv.Text = invNum_text;
                chb_isspis.Checked = isSpis;
                chb_iswork.Checked = isWork;
                rtb_comment.Text = comment_text;
            }

            if (invNum_text == "Б/Н")
                chb_inv.Checked = true;
        }

        private void frm_devices_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["frm_main"].Enabled = true;
            Application.OpenForms["frm_main"].Opacity = 1;
        }

        private void tsb_cancel_Click(object sender, EventArgs e)
        {
            chb_inv.Checked = invNum_text == "Б/Н" ? true : false;
            cmb_type.Text = type_text;
            txt_details.Text = details_text;
            cmb_place.Text = place_text;
            cmb_responsible.Text = responsible_text;
            txt_inv.Text = invNum_text;
            chb_isspis.Checked = isSpis;
            chb_iswork.Checked = isWork;
            rtb_comment.Text = comment_text;

        }

        private void tsb_save_Click(object sender, EventArgs e)
        {
            save();
        }

        private void tsb_save_exit_Click(object sender, EventArgs e)
        {
            save();
            if (!CloseError)
            {
                JustClose = true;
                this.Close();
            }
        }

        private void save()
        {

            if (cmb_type.Text == "")
            {
                MessageBox.Show("Заполните тип оборудования", "Отсутствует тип оборудования");
                CloseError = true;
                return;
            }

            else if (txt_details.Text == "")
            {
                MessageBox.Show("Заполните наименование оборудования", "Отсутствует наименование оборудования");
                CloseError = true;
                return;
            }
            else if (cmb_place.Text == "")
            {
                MessageBox.Show("Заполните расположение оборудования", "Отсутствует расположение оборудования");
                CloseError = true;
                return;
            }
            else if (cmb_responsible.Text == "")
            {
                MessageBox.Show("Заполните поле ответственного", "Отсутствует ответственный");
                CloseError = true;
                return;
            }
            else if (txt_inv.Text == "")
            {
                MessageBox.Show("Заполните поле инвентарного номера", "Отсутствует инвентарный номер");
                CloseError = true;
                return;
            }

            if (t < 2)
            {
                //SC.query("select Devices.InvNumber, Places.Place, Types.Type from Devices, Places, Types where Devices.PlaceID = Places.ID and Devices.TypeID = Types.ID");

                SC.query(0,
                    "Devices.InvNumber, Places.Place, Types.Type",
                    null,
                    "Devices.PlaceID = Places.ID AND Devices.TypeID = Types.ID");

                while (SC.dr.Read())
                    if (SC.dr_read(0) == txt_inv.Text)
                    {
                        MessageBox.Show("Оборудование " + SC.dr_read(2) + " (" + SC.dr_read(1) + ") уже имеет такой же инвентарный номер", "Дублирование инвентарных номеров");
                        SC.conn.Close();
                        CloseError = true;
                        return;
                    }
                SC.conn.Close();

                //SC.query("insert into Devices (TypeID, PlaceID, IsWork, InvNumber, ResponsibleID, IsSpis, Comment, Details, DateMod) values (" + ID_types[cmb_type.SelectedIndex] + ',' + ID_places[cmb_place.SelectedIndex] + ',' + (chb_iswork.Checked ? "1" : "0") + ",'" + txt_inv.Text + "'," + ID_responsibles[cmb_responsible.SelectedIndex] + ',' + (!chb_isspis.Checked ? "0" : "1") + ",'" + rtb_comment.Text + "','" + txt_details.Text + "','" + DateTime.Now.ToString() + "')", true);

                SC.query(2,
                    "TypeID, PlaceID, IsWork, InvNumber, ResponsibleID, IsSpis, Comment, Details, DateMod",
                    "Devices",
                    null,
                    ID_types[cmb_type.SelectedIndex] + "," + ID_places[cmb_place.SelectedIndex] + "," + (chb_iswork.Checked ? "1" : "0") + ",'" + txt_inv.Text + "'," + ID_responsibles[cmb_responsible.SelectedIndex] + ',' + (!chb_isspis.Checked ? "0" : "1") + ",'" + rtb_comment.Text + "','" + txt_details.Text + "','" + DateTime.Now.ToString() + "'");

                ((frm_main)Application.OpenForms["frm_main"]).lvw_main.Items.Clear();
                
                SC.query(0);

                i = 0;
                while (SC.dr.Read())
                {
                    ((frm_main)Application.OpenForms["frm_main"]).lvw_main.Items.Add(SC.dr_read(0));
                    ((frm_main)Application.OpenForms["frm_main"]).lvw_main.Items[i].SubItems.Add(SC.dr_read(1));
                    ((frm_main)Application.OpenForms["frm_main"]).lvw_main.Items[i].SubItems.Add(SC.dr_read(12));
                    ((frm_main)Application.OpenForms["frm_main"]).lvw_main.Items[i].SubItems.Add(SC.dr_read(3) == "" ? SC.dr_read(2) + " (" + SC.dr_read(4) + " эт.)" : SC.dr_read(2) + " (" + SC.dr_read(3) + " каб., " + SC.dr_read(4) + " эт.)");
                    ((frm_main)Application.OpenForms["frm_main"]).lvw_main.Items[i].SubItems.Add(SC.dr_read(14));
                    ((frm_main)Application.OpenForms["frm_main"]).lvw_main.Items[i].SubItems.Add(SC.dr_read(5));
                    ((frm_main)Application.OpenForms["frm_main"]).lvw_main.Items[i].SubItems.Add(SC.dr_read(6) + " " + SC.dr_read(7).Substring(0, 1) + ". " + SC.dr_read(8).Substring(0, 1) + ".");
                    ((frm_main)Application.OpenForms["frm_main"]).lvw_main.Items[i].SubItems.Add(SC.dr_read(10) == "True" ? "Списан" : "На учете");
                    ((frm_main)Application.OpenForms["frm_main"]).lvw_main.Items[i].SubItems.Add(SC.dr_read(9) == "True" ? "Рабочее" : "Сломано");
                    ((frm_main)Application.OpenForms["frm_main"]).lvw_main.Items[i].SubItems.Add(SC.dr_read(11));
                    ((frm_main)Application.OpenForms["frm_main"]).lvw_main.Items[i].SubItems.Add(SC.dr_read(13));
                    i++;
                }
                SC.conn.Close();
                if (!(sortColumn == -1)) ((frm_main)Application.OpenForms["frm_main"]).lvw_main.ListViewItemSorter = new ListViewItemComparer(sortColumn, order);
                ((frm_main)Application.OpenForms["frm_main"]).re_color();
            }
            else
            {
                //SC.query("update devices set TypeID = " + ID_types[cmb_type.SelectedIndex] + ", PlaceID = " + ID_places[cmb_place.SelectedIndex] + ", IsWork = " + (chb_iswork.Checked ? "1" : "0") + ", InvNumber = '" + txt_inv.Text + "', ResponsibleID = " + ID_responsibles[cmb_responsible.SelectedIndex] + ", IsSpis = " + (!chb_isspis.Checked ? "0" : "1") + ", Comment = '" + rtb_comment.Text + "', Details = '" + txt_details.Text + "', DateMod = '" + DateTime.Now.ToString() + "' where ID = " + ID_device, true);

                SC.query(1,
                    "TypeID, PlaceID, IsWork, InvNumber, ResponsibleID, IsSpis, Comment, Details, DateMod",
                    "Devices",
                    "ID = " + ID_device,
                    ID_types[cmb_type.SelectedIndex] + "," + ID_places[cmb_place.SelectedIndex] + "," + (chb_iswork.Checked ? "1" : "0") + ",'" + txt_inv.Text + "'," + ID_responsibles[cmb_responsible.SelectedIndex] + "," + (!chb_isspis.Checked ? "0" : "1") + ",'" + rtb_comment.Text + "','" + txt_details.Text + "','" + DateTime.Now.ToString() + "'");

                for (i = 0; i < ((frm_main)Application.OpenForms["frm_main"]).lvw_main.Items.Count; i++)
                    if (((frm_main)Application.OpenForms["frm_main"]).lvw_main.Items[i].SubItems[0].Text == ID_device.ToString())
                    {
                        ((frm_main)Application.OpenForms["frm_main"]).lvw_main.Items[i].SubItems[1].Text = cmb_type.Text;
                        ((frm_main)Application.OpenForms["frm_main"]).lvw_main.Items[i].SubItems[2].Text = txt_details.Text;
                        ((frm_main)Application.OpenForms["frm_main"]).lvw_main.Items[i].SubItems[3].Text = cmb_place.Text;
                        
                        SC.query(0,
                            "Subdivisions.Subdivision",
                            null,
                            "Responsibles.SubdivisionID = Subdivisions.ID AND Responsibles.ID = " + ID_responsibles[cmb_responsible.SelectedIndex]);
                        SC.dr.Read();

                        ((frm_main)Application.OpenForms["frm_main"]).lvw_main.Items[i].SubItems[4].Text = SC.dr_read(0);
                        SC.dr.Close();

                        ((frm_main)Application.OpenForms["frm_main"]).lvw_main.Items[i].SubItems[5].Text = txt_inv.Text;
                        ((frm_main)Application.OpenForms["frm_main"]).lvw_main.Items[i].SubItems[6].Text = cmb_responsible.Text;
                        ((frm_main)Application.OpenForms["frm_main"]).lvw_main.Items[i].SubItems[7].Text = chb_isspis.Checked ? "Списан" : "На учете";
                        if (chb_iswork.Checked)
                        {
                            ((frm_main)Application.OpenForms["frm_main"]).lvw_main.Items[i].SubItems[8].Text = "Рабочее";
                            ((frm_main)Application.OpenForms["frm_main"]).lvw_main.Items[i].BackColor = i % 2 == 0 ? MC.ch : MC.nech;
                        }
                        else
                        {
                            ((frm_main)Application.OpenForms["frm_main"]).lvw_main.Items[i].SubItems[8].Text = "Сломано";
                            ((frm_main)Application.OpenForms["frm_main"]).lvw_main.Items[i].BackColor = MC.bad;
                        }
                        ((frm_main)Application.OpenForms["frm_main"]).lvw_main.Items[i].SubItems[9].Text = rtb_comment.Text;
                        ((frm_main)Application.OpenForms["frm_main"]).lvw_main.Items[i].SubItems[10].Text = DateTime.Now.ToString();
                    }
            }
        }

        private void frm_devices_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tsb_save.Enabled && !JustClose && MessageBox.Show("Вы точно хотите закрыть форму без сохранения?", "Закрытие формы", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
                e.Cancel = true;
        }

        private void chb_inv_CheckedChanged(object sender, EventArgs e)
        {
            txt_inv.Text = chb_inv.Checked ? "Б/Н" : "";
            txt_inv.Enabled = !chb_inv.Checked;
        }

        private void txt_changed(object sender, EventArgs e)
        {
            if (sender.Equals(chb_inv))
            {
                txt_inv.Text = chb_inv.Checked ? "Б/Н" : "";
                txt_inv.Enabled = !chb_inv.Checked;
            }

            if (cmb_type.Text != type_text || txt_details.Text != details_text || cmb_place.Text != place_text || cmb_responsible.Text != responsible_text || txt_inv.Text != invNum_text || chb_iswork.Checked != isWork || chb_isspis.Checked != isSpis || rtb_comment.Text != comment_text)
            {
                tsb_cancel.Enabled = true;
                tsb_save.Enabled = true;
                tsb_save_exit.Enabled = true;
            }
            else
            {
                tsb_cancel.Enabled = false;
                tsb_save.Enabled = false;
                tsb_save_exit.Enabled = false;
            }
        }
    }
}
