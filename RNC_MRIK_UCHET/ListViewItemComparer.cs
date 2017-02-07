using System;
using System.Windows.Forms;
using System.Collections;

namespace RNC_MRIK_UCHET
{
    class ListViewItemComparer : IComparer
    {
        private int col;
        private System.Windows.Forms.SortOrder order;

        public ListViewItemComparer()
        {
            col = 0;
            order = System.Windows.Forms.SortOrder.Ascending;
        }

        public ListViewItemComparer(int column, System.Windows.Forms.SortOrder order)
        {
            col = column;
            this.order = order;
        }

        public int Compare(object x, object y)
        {
            int returnVal = -1;
            try
            {
                returnVal = Convert.ToInt16(((ListViewItem)x).SubItems[col].Text) > Convert.ToInt16(((ListViewItem)y).SubItems[col].Text) ? 1 : Convert.ToInt16(((ListViewItem)x).SubItems[col].Text) == Convert.ToInt16(((ListViewItem)y).SubItems[col].Text) ? 0 : -1;
            }
            catch
            {
                returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            }

            if (order == System.Windows.Forms.SortOrder.Descending)
                returnVal *= -1;
            return returnVal;
        }
    }
}
