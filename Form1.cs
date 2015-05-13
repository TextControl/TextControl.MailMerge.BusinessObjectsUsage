using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tx_BO_reporting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Report> Reports = new List<Report>();

            Product product = new Product();
            product.Name = "TX Text Control .NET for Windows Forms Subscription";
            product.Description = "1 developer license including all updates for 1 year incl. technical support";
            product.Price = 1608.60F;
            product.ProductCode = "TX-2000-DP-S";


            Report report = new Report();
            report.Title = "Sales Report";
            report.Product = product;

            Reports.Add(report);

            mailMerge1.MergeObjects(Reports);
        }
    }
}
