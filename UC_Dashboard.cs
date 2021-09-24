using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS_Aptech
{
    public partial class UC_Dashboard : UserControl
    {
        Bunifu.DataViz.DataPoint DataPoint;
        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void btnLoadChart_Click(object sender, EventArgs e)
        {
            DataPoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_line);
            Bunifu.DataViz.Canvas canvas = new Bunifu.DataViz.Canvas();
            Random random = new Random();

            DataPoint.addLabely("MON", random.Next(0, 50).ToString());
            DataPoint.addLabely("TUS", random.Next(0, 50).ToString());
            DataPoint.addLabely("WED", random.Next(0, 50).ToString());
            DataPoint.addLabely("THU", random.Next(0, 50).ToString());
            DataPoint.addLabely("FRI", random.Next(0, 50).ToString());
            DataPoint.addLabely("SAT", random.Next(0, 50).ToString());
            DataPoint.addLabely("SUN", random.Next(0, 50).ToString());
            canvas.addData(DataPoint);
            Chart.Render(canvas);
        }
    }
}
