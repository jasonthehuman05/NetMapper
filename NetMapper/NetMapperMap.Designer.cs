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
            tileHolder = new PictureBox();
            MessageLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)tileHolder).BeginInit();
            SuspendLayout();
            // 
            // tileHolder
            // 
            tileHolder.Location = new Point(0, 0);
            tileHolder.Name = "tileHolder";
            tileHolder.Size = new Size(256, 256);
            tileHolder.SizeMode = PictureBoxSizeMode.StretchImage;
            tileHolder.TabIndex = 0;
            tileHolder.TabStop = false;
            tileHolder.Click += TileClicked;
            // 
            // MessageLabel
            // 
            MessageLabel.AutoSize = true;
            MessageLabel.Location = new Point(12, 228);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(38, 15);
            MessageLabel.TabIndex = 1;
            MessageLabel.Text = "label1";
            // 
            // NetMapperMap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(MessageLabel);
            Controls.Add(tileHolder);
            MaximumSize = new Size(256, 256);
            MinimumSize = new Size(256, 256);
            Name = "NetMapperMap";
            Size = new Size(254, 254);
            Click += TileClicked;
            Resize += ControlResized;
            ((System.ComponentModel.ISupportInitialize)tileHolder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox tileHolder;
        private Label MessageLabel;
    }
}