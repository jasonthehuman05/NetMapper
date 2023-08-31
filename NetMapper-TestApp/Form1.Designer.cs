namespace NetMapper_TestApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.netMapperMap1 = new NetMapper.NetMapperMap();
            this.button1 = new System.Windows.Forms.Button();
            this.zoomInButton = new System.Windows.Forms.Button();
            this.zoomOutButton = new System.Windows.Forms.Button();
            this.panUpButton = new System.Windows.Forms.Button();
            this.panLeftButton = new System.Windows.Forms.Button();
            this.panDownButton = new System.Windows.Forms.Button();
            this.panRightButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // netMapperMap1
            // 
            this.netMapperMap1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.netMapperMap1.BackColor = System.Drawing.SystemColors.Control;
            this.netMapperMap1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.netMapperMap1.CenterX = 128;
            this.netMapperMap1.CenterY = 128;
            this.netMapperMap1.Location = new System.Drawing.Point(12, 12);
            this.netMapperMap1.MaximumSize = new System.Drawing.Size(256, 256);
            this.netMapperMap1.MinimumSize = new System.Drawing.Size(256, 256);
            this.netMapperMap1.Name = "netMapperMap1";
            this.netMapperMap1.Size = new System.Drawing.Size(256, 256);
            this.netMapperMap1.TabIndex = 0;
            this.netMapperMap1.ZoomLevel = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "testbutton";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // zoomInButton
            // 
            this.zoomInButton.Location = new System.Drawing.Point(362, 105);
            this.zoomInButton.Name = "zoomInButton";
            this.zoomInButton.Size = new System.Drawing.Size(64, 28);
            this.zoomInButton.TabIndex = 2;
            this.zoomInButton.Text = "+";
            this.zoomInButton.UseVisualStyleBackColor = true;
            this.zoomInButton.Click += new System.EventHandler(this.zoomInPressed);
            // 
            // zoomOutButton
            // 
            this.zoomOutButton.Location = new System.Drawing.Point(362, 139);
            this.zoomOutButton.Name = "zoomOutButton";
            this.zoomOutButton.Size = new System.Drawing.Size(64, 28);
            this.zoomOutButton.TabIndex = 3;
            this.zoomOutButton.Text = "-";
            this.zoomOutButton.UseVisualStyleBackColor = true;
            this.zoomOutButton.Click += new System.EventHandler(this.zoomOutPressed);
            // 
            // panUpButton
            // 
            this.panUpButton.Location = new System.Drawing.Point(362, 35);
            this.panUpButton.Name = "panUpButton";
            this.panUpButton.Size = new System.Drawing.Size(64, 64);
            this.panUpButton.TabIndex = 4;
            this.panUpButton.Text = "UP";
            this.panUpButton.UseVisualStyleBackColor = true;
            this.panUpButton.Click += new System.EventHandler(this.panUpPressed);
            // 
            // panLeftButton
            // 
            this.panLeftButton.Location = new System.Drawing.Point(292, 105);
            this.panLeftButton.Name = "panLeftButton";
            this.panLeftButton.Size = new System.Drawing.Size(64, 64);
            this.panLeftButton.TabIndex = 6;
            this.panLeftButton.Text = "LT";
            this.panLeftButton.UseVisualStyleBackColor = true;
            this.panLeftButton.Click += new System.EventHandler(this.panLeftPressed);
            // 
            // panDownButton
            // 
            this.panDownButton.Location = new System.Drawing.Point(362, 175);
            this.panDownButton.Name = "panDownButton";
            this.panDownButton.Size = new System.Drawing.Size(64, 64);
            this.panDownButton.TabIndex = 7;
            this.panDownButton.Text = "DN";
            this.panDownButton.UseVisualStyleBackColor = true;
            this.panDownButton.Click += new System.EventHandler(this.panDownPressed);
            // 
            // panRightButton
            // 
            this.panRightButton.Location = new System.Drawing.Point(432, 105);
            this.panRightButton.Name = "panRightButton";
            this.panRightButton.Size = new System.Drawing.Size(64, 64);
            this.panRightButton.TabIndex = 8;
            this.panRightButton.Text = "RT";
            this.panRightButton.UseVisualStyleBackColor = true;
            this.panRightButton.Click += new System.EventHandler(this.panRightPressed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1061, 675);
            this.Controls.Add(this.panRightButton);
            this.Controls.Add(this.panDownButton);
            this.Controls.Add(this.panLeftButton);
            this.Controls.Add(this.panUpButton);
            this.Controls.Add(this.zoomOutButton);
            this.Controls.Add(this.zoomInButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.netMapperMap1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private NetMapper.NetMapperMap netMapperMap1;
        private Button button1;
        private Button zoomInButton;
        private Button zoomOutButton;
        private Button panUpButton;
        private Button panLeftButton;
        private Button panDownButton;
        private Button panRightButton;
    }
}