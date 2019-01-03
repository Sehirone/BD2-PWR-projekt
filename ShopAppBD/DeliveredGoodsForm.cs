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
    public partial class DeliveredGoodsForm : Form
    {
        int supplier_id;
        OracleConnection conn;

        public DeliveredGoodsForm(OracleConnection conn, int supplier_id)
        {
            this.supplier_id = supplier_id;
            this.conn = conn;
            InitializeComponent();
            getDeliveries();
        }

        private void getDeliveries()
        {

        }
    }
}
