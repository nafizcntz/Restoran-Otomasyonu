using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASCI
{
    public partial class TableButton : UserControl
    {
        public int Masaid;
        public TableButton()
        {
            InitializeComponent();
        }
        public TableButton(int id)
        {
            Masaid = id;
            InitializeComponent();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            TableOrders to = new TableOrders(Masaid);
            to.ShowDialog();
        }
    }
}
