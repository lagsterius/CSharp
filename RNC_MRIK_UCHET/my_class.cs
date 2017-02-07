using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace RNC_MRIK_UCHET
{
    class my_class
    {
        public Color nech = Color.FromArgb(255, 210, 230, 252), ch = Color.FromArgb(255, 234, 250, 255), bad = Color.FromArgb(255, 249, 204, 214);
        
        /// <summary>
        /// Возвращает цвет строки ListView (сломанный, четный или нечетный)
        /// </summary>
        /// <param name="p">Порядковый номер элемента, сломанный/рабочий</param>
        public Color myColor(int i, params bool[] p)
        {
            if (p.Length > 0 && !(bool)p[0])
                return bad;
            else if (i % 2 == 1)
                return ch;
            else
                return nech;
        }

        /// <summary>
        /// Центрирует новое окно по отношению к родителю
        /// </summary>
        /// <param name="from">Форма-родитель</param>
        /// <param name="to">Форма-предок</param>
        public Point myCenter(object from, object to)   //Центрирует новое окно по отношению к родителю
        {
            return new Point(((Form)from).Location.X + (((Form)from).Size.Width - ((Form)to).Size.Width) / 2, ((Form)from).Location.Y + (((Form)from).Size.Height - ((Form)to).Size.Height) / 2);
        }
    }
}
