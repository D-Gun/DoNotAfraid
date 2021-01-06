using DevExpress.XtraEditors;
using DevExpress.XtraMap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mapctr
{
    public partial class XtraUserControl1 : XtraUserControl
    {
        public XtraUserControl1()
        {
            InitializeComponent();
        }

        public MapUnit DevMap { get; set; }

        private void mapControl1_MapItemClick(object sender, MapItemClickEventArgs e)
        {
            mapControl1.MapUnitToCoordPoint(DevMap);
            vectorItemsLayer1.SelectedItemStyle.Fill = Color.Blue;
        }

        private void XtraUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void mapControl1_SelectionChanged(object sender, MapSelectionChangedEventArgs e)
        {
            //vectorItemsLayer1.SelectedItemStyle.Fill = Color.Blue;
            //vectorItemsLayer1.SelectedItemStyle.Stroke = Color.Blue;
        }

        private void mapControl1_SelectionChanging(object sender, MapSelectionChangingEventArgs e)
        {

        }
    }
}
