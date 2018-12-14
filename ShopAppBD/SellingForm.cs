using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace ShopAppBD
{
    public partial class SellingForm : Form
    {
        OracleConnection conn;

        public SellingForm(OracleConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }
    }
}
