using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;


namespace Colegio_las_Rosas
{
    public partial class frmReporteMensual : Form
    {
        public frmReporteMensual(string nombre_reporte)
        {
            InitializeComponent();
            NotaMes cryRpt = new NotaMes();
            cryRpt.Load();

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
            //InitializeComponent();
            //ReportDocument cryRpt = new ReportDocument();
            //cryRpt.Load(nombre_reporte);

            //crystalReportViewer1.ReportSource = cryRpt;
            //crystalReportViewer1.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            //InitializeComponent();
            //NotaMes cryRpt = new NotaMes();
            //cryRpt.Load();

            //crystalReportViewer1.ReportSource = cryRpt;
            //crystalReportViewer1.Refresh();
        }
    }
}
