
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
            this.mapControl1.Layers.Add(this.imageLayer1);
            this.mapControl1.Layers.Add(this.vectorItemsLayer1);
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.MaxZoomLevel = 12D;
            this.mapControl1.MinZoomLevel = 10D;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(599, 487);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ZoomLevel = 10D;
            this.mapControl1.MapItemClick += new DevExpress.XtraMap.MapItemClickEventHandler(this.mapControl1_MapItemClick);
            this.imageLayer1.DataProvider = this.bingMapDataProvider1;
            this.bingMapDataProvider1.BingKey = "Ajpgpwdlqkf9o_r7GaID0kgX3FEOrhBQYLBVC62hdzkfP0Ekn-Mv8NrNJW8q9bzC";
            this.vectorItemsLayer1.Data = this.shapefileDataAdapter1;
            this.shapefileDataAdapter1.FileUri = new System.Uri("C:\\gitDoNotAfraid\\TL_SCCO_SIG_W_SHP\\TL_SCCO_SIG_W.shp", System.UriKind.Absolute);
            // 
            // XtraUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mapControl1);
            this.Name = "XtraUserControl1";
            this.Size = new System.Drawing.Size(599, 487);
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
