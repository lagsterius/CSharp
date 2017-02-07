using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace RNC_MRIK_UCHET
{
    public partial class frm_login : Form
    {
        sql_class SC = new sql_class();
        public StringBuilder sBuilder = new StringBuilder();
        public byte CurUser = 0;
        bool lg;

        public frm_login()
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

        private void frm_login_Load(object sender, EventArgs e)
        {
            this.Text = RNC_MRIK_UCHET.Properties.Resources.Org + ". " + RNC_MRIK_UCHET.Properties.Resources.ProgName + ". v " + System.Reflection.Assembly.GetEntryAssembly().GetName().Version;

            //SC.query("Select Logins.Login From Users, Logins where Users.LoginID = Logins.ID AND Users.InUse = 'True'");

            SC.query(0,
                "Logins.Login",
                null,
                "Users.LoginID = Logins.ID AND Users.InUse = 1");

            while (SC.dr.Read())
                cmb_login.Items.Add((SC.dr_read(0)));
            SC.conn.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            log();
        }

        private void txt_Changed(object sender, EventArgs e)
        {
            if (cmb_login.Text == "" || txt_pass.Text == "")
                btn_login.Enabled = false;
            else
                btn_login.Enabled = true;
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                if (sender.Equals(cmb_login))
                    txt_pass.Focus();
                else
                    log();
        }

        private void log()
        {
            //SC.query("SELECT Logins.Login, Logins.Password, Peoples.Surname, Peoples.Name, Peoples.FatherName, Logins.ID from Logins, Users, Peoples where Users.LoginID = Logins.ID AND Users.PeopleID = Peoples.ID AND Users.InUse = 'True'");

            SC.query(0,
                "Logins.Login, Logins.Password, Peoples.Surname, Peoples.Name, Peoples.FatherName, Logins.ID",
                null,
                "Users.LoginID = Logins.ID AND Users.PeopleID = Peoples.ID AND Users.InUse = 1");

            while (SC.dr.Read())
                if (SC.dr_read(0).ToLower() == cmb_login.Text.ToLower() && SC.dr_read(1) == get_hash(txt_pass.Text))
                {
                    frm_main frm_main = new frm_main();
                    frm_main.Show();
                    frm_main.Text = "Добро пожаловать, " + SC.dr_read(2) + ' ' + SC.dr_read(3) + ' ' + SC.dr_read(4);
                    CurUser = Convert.ToByte(SC.dr_read(5));
                    lg = true;
                    this.Hide();
                }
            if (!lg)
            {
                txt_pass.Clear();
                MessageBox.Show("Неверное имя пользователя/пароль");
            }
            SC.conn.Close();
        }



        public string get_hash(string password)
        {
            sBuilder.Remove(0, sBuilder.Length);
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
            for (int i = 0; i < data.Length; i++)
                sBuilder.Append(data[i].ToString("x2"));
            return sBuilder.ToString();
        }
    }
}
