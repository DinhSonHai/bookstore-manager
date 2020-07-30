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
    public partial class formStaticticsDG : Form
    {
        BLInfomation bl = new BLInfomation();
        
        public formStaticticsDG()
        {
            InitializeComponent();
        }

        private void formStaticticsDG_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = bl.GetStaticticsDG();
            chart1.DataSource = bl.GetStaticticsDG();
            chart1.Series["Series1"].XValueMember = "Số tuổi";
            chart1.Series["Series1"].YValueMembers = "Số độc giả";
            //this.chart1.Titles.Add("Category Title");
            //chart1.Series["Series1"].ChartType = SeriesChartType.Pie;
            chart1.Series["Series1"].IsValueShownAsLabel = true;
        }
    }
}
