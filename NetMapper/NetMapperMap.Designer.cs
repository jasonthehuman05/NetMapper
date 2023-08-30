namespace NetMapper
{
    partial class NetMapperMap
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
            this.tileHolder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tileHolder)).BeginInit();
            this.SuspendLayout();
            // 
            // tileHolder
            // 
            this.tileHolder.Location = new System.Drawing.Point(0, 0);
            this.tileHolder.Name = "tileHolder";
            this.tileHolder.Size = new System.Drawing.Size(256, 256);
            this.tileHolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tileHolder.TabIndex = 0;
            this.tileHolder.TabStop = false;
            this.tileHolder.Click += new System.EventHandler(this.TileClicked);
            // 
            // NetMapperMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tileHolder);
            this.MaximumSize = new System.Drawing.Size(256, 256);
            this.MinimumSize = new System.Drawing.Size(256, 256);
            this.Name = "NetMapperMap";
            this.Size = new System.Drawing.Size(254, 254);
            this.Resize += new System.EventHandler(this.ControlResized);
            ((System.ComponentModel.ISupportInitialize)(this.tileHolder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox tileHolder;
    }
}