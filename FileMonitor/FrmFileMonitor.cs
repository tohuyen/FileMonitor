using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace FileMonitor
{
    public partial class FrmFileMonitor : Form
    {
        FileReconsDataContext db;

        public FrmFileMonitor()
        {
            db = new FileReconsDataContext(ConfigurationManager.ConnectionStrings["ConnStr"].ToString());
            var y = (from p in db.tblFilesRecon_Locations select p);
            //dataGridView1.DataSource = db.tblFilesRecon_Locations();
            var x = db.tblFilesRecon_Locations;

            this.tblFilesRecon_LocationBindingSource.DataSource = db.tblFilesRecon_Locations;
            InitializeComponent();
        }
    }
}
