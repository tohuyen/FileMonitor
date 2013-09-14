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
        FileReconTableDataContext db;

        public FrmFileMonitor()
        {
            db = new FileReconTableDataContext(ConfigurationManager.ConnectionStrings["ConnStr2"].ToString());
            var y = from p in db.tblFilesRecon_Locations where 1==1 select p;
            //dataGridView1.DataSource = db.tblFilesRecon_Locations();
            //var x = db.tblFilesRecon_Locations.Select(p => 1=1);

            this.tblFilesRecon_LocationBindingSource.DataSource = y;
            InitializeComponent();
        }
    }
}
