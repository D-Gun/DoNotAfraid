using DevExpress.Map.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraMap;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapctr
{
    public partial class XtraUserControl1 : XtraUserControl
    {
        public XtraUserControl1()
        {
            InitializeComponent();
        }

        public MapUnit DevMap { get; set; }
        public string GuName { get; set; }

        private void mapControl1_MapItemClick(object sender, MapItemClickEventArgs e)
        {
            mapControl1.MapUnitToCoordPoint(DevMap);
        }
        
        private void XtraUserControl1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(shapefileDataAdapter1.ToString());
        }

        private void mapControl1_SelectionChanged(object sender, MapSelectionChangedEventArgs e)
        {

        }


        private void mapControl1_SelectionChanging(object sender, MapSelectionChangingEventArgs e)
        {
            
        }
    }
}
