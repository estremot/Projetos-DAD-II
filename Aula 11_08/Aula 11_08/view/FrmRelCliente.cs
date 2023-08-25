using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_11_08.view
{
    public partial class FrmRelCliente : Form
    {
        DataTable dt = new DataTable();
        public FrmRelCliente(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void FrmRelCliente_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1",dt));

            this.reportViewer1.RefreshReport();

        }
    }
}
