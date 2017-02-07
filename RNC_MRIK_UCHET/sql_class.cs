using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections.Generic;

namespace RNC_MRIK_UCHET
{
    class sql_class
    {
        public SqlConnection conn = new SqlConnection(RNC_MRIK_UCHET.Properties.Resources.ConStr);
        public SqlDataReader dr;
        public DataSet ds = new DataSet();

        /// <summary>
        /// Открытие соединения к базе данных, выполнение запроса типа type с параметрами Поле, Таблицы, условия
        /// </summary>
        /// <param name="type">Тип запроса: 0 - Select, 1 - Update, 2 - Insert, 3 - Delete</param>
        /// <param name="WhatFromWhere">[0] - Поля, [1] - Таблицы, [2] - Условия, [3] - Значения, [4] - Сортировка</param>
        public void query(byte type, params string[] WhatFromWhere)
        {
            string q = "";


            if (WhatFromWhere.Length > 1)
                if (WhatFromWhere[1] == null)
                    WhatFromWhere[1] = From(WhatFromWhere[0], WhatFromWhere[2]);
            conn.Open();

            if (type == 0)
            {
                if (WhatFromWhere.Length == 0)
                {
                    conn.Close();
                    query(0,
                        "Devices.ID, Types.Type, Places.Place, Places.Room, Places.Floor, Devices.InvNumber, Peoples.Surname, Peoples.Name, Peoples.FatherName, Devices.IsWork, Devices.IsSpis, Devices.Comment, Devices.Details, Devices.DateMod, Subdivisions.Subdivision",
                        null,
                        "Devices.ResponsibleID = Responsibles.ID  AND Responsibles.PeopleID = Peoples.ID AND Devices.placeID = Places.ID AND Devices.typeID = Types.ID AND Devices.ResponsibleID = Responsibles.ID AND Responsibles.SubdivisionID = Subdivisions.ID");
                    return;
                }
                else
                {
                    q = "Select ";
                    q += WhatFromWhere[0] == null ? "* " : WhatFromWhere[0];
                    q += " From ";
                    q += WhatFromWhere[1];
                    if (WhatFromWhere.Length > 2)
                    {

                        if (WhatFromWhere[2] != null)
                            q += " Where " + WhatFromWhere[2];
                        if (WhatFromWhere.Length > 4)
                            q += " Order By " + WhatFromWhere[4];
                    }
                }

                dr = new SqlCommand(q, conn).ExecuteReader(CommandBehavior.CloseConnection);
            }
            else if (type == 1)
            {
                string[] Columns = WhatFromWhere[0].Split(',');
                string[] Values = WhatFromWhere[3].Split(',');
                q = "Update ";
                q += WhatFromWhere[1];
                q += " Set ";
                for (int i = 0; i < Columns.Length; i++)
                {
                    q += Columns[i] + " = " + Values[i];
                    if (i < Columns.Length - 1) q += ",";
                }
                q += " Where " + WhatFromWhere[2];

                dr = new SqlCommand(q, conn).ExecuteReader(CommandBehavior.CloseConnection);
                conn.Close();
            }
            else if (type == 2)
            {
                q = "Insert Into ";
                q += WhatFromWhere[1];
                q += " (" + WhatFromWhere[0] + ") ";
                q += " Values (";
                q += WhatFromWhere[3] + ")";

                dr = new SqlCommand(q, conn).ExecuteReader(CommandBehavior.CloseConnection);
                conn.Close();

            }
            else
            {
                q = "Delete From ";
                q += WhatFromWhere[1];
                q += " Where " + WhatFromWhere[2];

                dr = new SqlCommand(q, conn).ExecuteReader(CommandBehavior.CloseConnection);
                conn.Close();
            }
            //System.Windows.Forms.MessageBox.Show(q);
        }


        string From(string one, string two)
        {
            List<string> Splitter = new List<string>();

            string msg = "";

            int start_pos;
            byte dot_count = 0;

            if (one != null)
            {
                for (int i = 0; i < one.Length; i++)
                    if (one[i] == '.')
                        dot_count++;
                if (dot_count > 0)
                {
                    start_pos = 0;
                    for (int i = 0; i < one.Length; i++)
                        if (one[i] == ' ')
                            start_pos = i + 1;
                        else if (one[i] == '.')
                            Splitter.Add(one.Substring(start_pos, i - start_pos));
                }
            }

            dot_count = 0;

            if (two != null)
            {
                for (int i = 0; i < two.Length; i++)
                    if (two[i] == '.')
                        dot_count++;
                start_pos = 0;
                if (dot_count > 0)
                {
                    for (int i = 0; i < two.Length; i++)
                        if (two[i] == ' ')
                            start_pos = i + 1;
                        else if (two[i] == '.')
                            Splitter.Add(two.Substring(start_pos, i - start_pos));
                }
            }

            Splitter.Sort();

            for (int i = 0; i < Splitter.Count - 1; i++)
                if (Splitter[i] == Splitter[i + 1])
                {
                    Splitter.RemoveAt(i + 1);
                    i--;
                }

            for (int i = 0; i < Splitter.Count; i++)
            {
                msg += Splitter[i];
                if (i != Splitter.Count - 1)
                    msg += ",";
            }
            return msg;
        }


        /// <summary>
        /// Прочитать из DataReader элемент и преобразовать в строку
        /// </summary>
        /// <param name="n">Порядковый номер элемента</param>
        /// <returns></returns>
        public string dr_read(int n)
        {
            return dr.GetValue(n).ToString();
        }
    }
}
