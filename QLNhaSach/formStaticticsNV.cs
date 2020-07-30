using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNhaSach.BSLayer;

namespace QLNhaSach
{
    public partial class formStaticticsNV : Form
    {
        BLInfomation bl = new BLInfomation();
        public formStaticticsNV()
        {
            InitializeComponent();
        }

        private void formStaticticsNV_Load(object sender, EventArgs e)
        {
            chart1.DataSource = bl.GetStaticticsNV();
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            chart1.Series["Số nhân viên"].IsValueShownAsLabel = true;
            chart1.Series["Số nhân viên"].XValueMember = "Số năm";
            chart1.Series["Số nhân viên"].YValueMembers = "Số nhân viên";
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
