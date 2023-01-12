using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButtonClicked(object sender, EventArgs e)
        {
            bookDataSet.bookzDataTable.AddbookzDataTableRow(
                this.bookName.Text,
                this.auther.Text,
                int.Parse(this.price.Text)
            );
        }

        private void RemoveButtonClicked(object sender, EventArgs e)
        {
            int row = this.bookDataGrid.CurrentRow.Index;
            this.bookDataGrid.Rows.RemoveAt(row);
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
