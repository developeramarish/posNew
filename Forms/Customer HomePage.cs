using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Customer_HomePage : MetroFramework.Forms.MetroForm
    {
        public Customer_HomePage()
        {
            InitializeComponent();
        }

        private void tilePayment_Click(object sender, EventArgs e)
        {
            new CreateOrder().ShowDialog();
        }
    }
}
