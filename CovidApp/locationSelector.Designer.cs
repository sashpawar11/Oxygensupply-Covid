
namespace CovidApp
{
    partial class locationSelector
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.locatormap = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.latBox = new System.Windows.Forms.TextBox();
            this.longBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.locatormap);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.saveBtn);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.longBox);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.latBox);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1165, 621);
            this.splitContainer1.SplitterDistance = 706;
            this.splitContainer1.TabIndex = 0;
            // 
            // locatormap
            // 
            this.locatormap.Bearing = 0F;
            this.locatormap.CanDragMap = true;
            this.locatormap.EmptyTileColor = System.Drawing.Color.Navy;
            this.locatormap.GrayScaleMode = false;
            this.locatormap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.locatormap.LevelsKeepInMemory = 5;
            this.locatormap.Location = new System.Drawing.Point(12, 12);
            this.locatormap.MarkersEnabled = true;
            this.locatormap.MaxZoom = 2;
            this.locatormap.MinZoom = 2;
            this.locatormap.MouseWheelZoomEnabled = true;
            this.locatormap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.locatormap.Name = "locatormap";
            this.locatormap.NegativeMode = false;
            this.locatormap.PolygonsEnabled = true;
            this.locatormap.RetryLoadTile = 0;
            this.locatormap.RoutesEnabled = true;
            this.locatormap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.locatormap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.locatormap.ShowTileGridLines = false;
            this.locatormap.Size = new System.Drawing.Size(691, 606);
            this.locatormap.TabIndex = 0;
            this.locatormap.Zoom = 0D;
            this.locatormap.Load += new System.EventHandler(this.locationSelector_Load);
            this.locatormap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.locatormap_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Latitude";
            // 
            // latBox
            // 
            this.latBox.Location = new System.Drawing.Point(33, 159);
            this.latBox.Name = "latBox";
            this.latBox.Size = new System.Drawing.Size(338, 22);
            this.latBox.TabIndex = 1;
            // 
            // longBox
            // 
            this.longBox.Location = new System.Drawing.Point(33, 258);
            this.longBox.Name = "longBox";
            this.longBox.Size = new System.Drawing.Size(338, 22);
            this.longBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Longitude";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Your Location";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(33, 365);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(338, 34);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save Location";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // locationSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 621);
            this.Controls.Add(this.splitContainer1);
            this.Name = "locationSelector";
            this.Text = "locationSelector";
            this.Load += new System.EventHandler(this.locationSelector_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private GMap.NET.WindowsForms.GMapControl locatormap;
        private System.Windows.Forms.TextBox longBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox latBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveBtn;
    }
}