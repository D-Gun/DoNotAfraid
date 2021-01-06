
namespace Mapctr
{
    partial class XtraUserControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraMap.ChoroplethColorizer choroplethColorizer1 = new DevExpress.XtraMap.ChoroplethColorizer();
            DevExpress.XtraMap.LinearRangeDistribution linearRangeDistribution1 = new DevExpress.XtraMap.LinearRangeDistribution();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            this.vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            this.shapefileDataAdapter1 = new DevExpress.XtraMap.ShapefileDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mapControl1
            // 
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(37.505D, 127D);
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.EnableScrolling = true;
            this.mapControl1.Layers.Add(this.imageLayer1);
            this.mapControl1.Layers.Add(this.vectorItemsLayer1);
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mapControl1.MaxZoomLevel = 12D;
            this.mapControl1.MinZoomLevel = 10D;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.ShowCoordinates = false;
            this.mapControl1.NavigationPanelOptions.ShowKilometersScale = false;
            this.mapControl1.NavigationPanelOptions.ShowMilesScale = false;
            this.mapControl1.Size = new System.Drawing.Size(685, 626);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ZoomLevel = 10D;
            this.mapControl1.SelectionChanging += new DevExpress.XtraMap.MapSelectionChangingEventHandler(this.mapControl1_SelectionChanging);
            this.mapControl1.SelectionChanged += new DevExpress.XtraMap.MapSelectionChangedEventHandler(this.mapControl1_SelectionChanged);
            this.mapControl1.MapItemClick += new DevExpress.XtraMap.MapItemClickEventHandler(this.mapControl1_MapItemClick);
            this.imageLayer1.DataProvider = this.bingMapDataProvider1;
            this.bingMapDataProvider1.BingKey = "Ajpgpwdlqkf9o_r7GaID0kgX3FEOrhBQYLBVC62hdzkfP0Ekn-Mv8NrNJW8q9bzC";
            choroplethColorizer1.RangeDistribution = linearRangeDistribution1;
            this.vectorItemsLayer1.Colorizer = choroplethColorizer1;
            this.vectorItemsLayer1.Data = this.shapefileDataAdapter1;
            this.vectorItemsLayer1.EnableSelection = true;
            this.vectorItemsLayer1.EnableHighlighting = true;
            this.shapefileDataAdapter1.FileUri = new System.Uri("C:\\Users\\kccistc\\source\\repos\\CsStudyASY\\DoNotAfraid\\TL_SCCO_SIG_W_SHP\\TL_SCCO_SI" +
        "G_W.shp", System.UriKind.Absolute);
            // 
            // XtraUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mapControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XtraUserControl1";
            this.Size = new System.Drawing.Size(685, 626);
            this.Load += new System.EventHandler(this.XtraUserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1;
        private DevExpress.XtraMap.VectorItemsLayer vectorItemsLayer1;
        private DevExpress.XtraMap.ShapefileDataAdapter shapefileDataAdapter1;
    }
}
