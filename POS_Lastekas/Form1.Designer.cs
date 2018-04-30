namespace POS_Lastekas
{
    partial class Main_Panel
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Panel));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.menuButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.sideMenu = new System.Windows.Forms.Panel();
            this.laduButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sellingScreenButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.menuAnimator2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.sideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.AutoSize = true;
            this.menuAnimator.SetDecoration(this.timeLabel, BunifuAnimatorNS.DecorationType.None);
            this.menuAnimator2.SetDecoration(this.timeLabel, BunifuAnimatorNS.DecorationType.None);
            this.timeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.timeLabel.ForeColor = System.Drawing.Color.Silver;
            this.timeLabel.Location = new System.Drawing.Point(704, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(72, 21);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "00:00:00";
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.AutoSize = true;
            this.menuAnimator.SetDecoration(this.dateLabel, BunifuAnimatorNS.DecorationType.None);
            this.menuAnimator2.SetDecoration(this.dateLabel, BunifuAnimatorNS.DecorationType.None);
            this.dateLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.dateLabel.ForeColor = System.Drawing.Color.Silver;
            this.dateLabel.Location = new System.Drawing.Point(687, 17);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(106, 21);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "dd:dd:dddd";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Controls.Add(this.dateLabel);
            this.menuAnimator2.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.menuAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 42);
            this.panel1.TabIndex = 2;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.menuAnimator2.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.menuAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(64, 42);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 6;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.menuAnimator2.SetDecoration(this.minimizeButton, BunifuAnimatorNS.DecorationType.None);
            this.menuAnimator.SetDecoration(this.minimizeButton, BunifuAnimatorNS.DecorationType.None);
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.ImageActive = null;
            this.minimizeButton.Location = new System.Drawing.Point(799, 13);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(25, 25);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 4;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Zoom = 10;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.menuAnimator2.SetDecoration(this.closeButton, BunifuAnimatorNS.DecorationType.None);
            this.menuAnimator.SetDecoration(this.closeButton, BunifuAnimatorNS.DecorationType.None);
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageActive = null;
            this.closeButton.Location = new System.Drawing.Point(830, 8);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 3;
            this.closeButton.TabStop = false;
            this.closeButton.Zoom = 10;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuAnimator2.SetDecoration(this.menuButton, BunifuAnimatorNS.DecorationType.None);
            this.menuAnimator.SetDecoration(this.menuButton, BunifuAnimatorNS.DecorationType.None);
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.ImageActive = null;
            this.menuButton.Location = new System.Drawing.Point(5, 6);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(39, 33);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuButton.TabIndex = 5;
            this.menuButton.TabStop = false;
            this.menuButton.Zoom = 10;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.sideMenu.Controls.Add(this.menuButton);
            this.sideMenu.Controls.Add(this.laduButton);
            this.sideMenu.Controls.Add(this.sellingScreenButton);
            this.menuAnimator2.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.menuAnimator.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Location = new System.Drawing.Point(0, 42);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(49, 374);
            this.sideMenu.TabIndex = 3;
            // 
            // laduButton
            // 
            this.laduButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.laduButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.laduButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.laduButton.BorderRadius = 0;
            this.laduButton.ButtonText = "       Ladu";
            this.laduButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuAnimator2.SetDecoration(this.laduButton, BunifuAnimatorNS.DecorationType.None);
            this.menuAnimator.SetDecoration(this.laduButton, BunifuAnimatorNS.DecorationType.None);
            this.laduButton.DisabledColor = System.Drawing.Color.Gray;
            this.laduButton.Iconcolor = System.Drawing.Color.Transparent;
            this.laduButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("laduButton.Iconimage")));
            this.laduButton.Iconimage_right = null;
            this.laduButton.Iconimage_right_Selected = null;
            this.laduButton.Iconimage_Selected = null;
            this.laduButton.IconMarginLeft = 0;
            this.laduButton.IconMarginRight = 0;
            this.laduButton.IconRightVisible = true;
            this.laduButton.IconRightZoom = 0D;
            this.laduButton.IconVisible = true;
            this.laduButton.IconZoom = 80D;
            this.laduButton.IsTab = false;
            this.laduButton.Location = new System.Drawing.Point(0, 96);
            this.laduButton.Name = "laduButton";
            this.laduButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.laduButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.laduButton.OnHoverTextColor = System.Drawing.Color.Silver;
            this.laduButton.selected = false;
            this.laduButton.Size = new System.Drawing.Size(176, 45);
            this.laduButton.TabIndex = 5;
            this.laduButton.Text = "       Ladu";
            this.laduButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.laduButton.Textcolor = System.Drawing.Color.Silver;
            this.laduButton.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            // 
            // sellingScreenButton
            // 
            this.sellingScreenButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.sellingScreenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.sellingScreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sellingScreenButton.BorderRadius = 0;
            this.sellingScreenButton.ButtonText = "       Müük";
            this.sellingScreenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuAnimator2.SetDecoration(this.sellingScreenButton, BunifuAnimatorNS.DecorationType.None);
            this.menuAnimator.SetDecoration(this.sellingScreenButton, BunifuAnimatorNS.DecorationType.None);
            this.sellingScreenButton.DisabledColor = System.Drawing.Color.Gray;
            this.sellingScreenButton.Iconcolor = System.Drawing.Color.Transparent;
            this.sellingScreenButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("sellingScreenButton.Iconimage")));
            this.sellingScreenButton.Iconimage_right = null;
            this.sellingScreenButton.Iconimage_right_Selected = null;
            this.sellingScreenButton.Iconimage_Selected = null;
            this.sellingScreenButton.IconMarginLeft = 0;
            this.sellingScreenButton.IconMarginRight = 0;
            this.sellingScreenButton.IconRightVisible = true;
            this.sellingScreenButton.IconRightZoom = 0D;
            this.sellingScreenButton.IconVisible = true;
            this.sellingScreenButton.IconZoom = 80D;
            this.sellingScreenButton.IsTab = false;
            this.sellingScreenButton.Location = new System.Drawing.Point(0, 45);
            this.sellingScreenButton.Name = "sellingScreenButton";
            this.sellingScreenButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.sellingScreenButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.sellingScreenButton.OnHoverTextColor = System.Drawing.Color.Silver;
            this.sellingScreenButton.selected = false;
            this.sellingScreenButton.Size = new System.Drawing.Size(176, 45);
            this.sellingScreenButton.TabIndex = 4;
            this.sellingScreenButton.Text = "       Müük";
            this.sellingScreenButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sellingScreenButton.Textcolor = System.Drawing.Color.Silver;
            this.sellingScreenButton.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            // 
            // menuAnimator
            // 
            this.menuAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.menuAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.menuAnimator.DefaultAnimation = animation1;
            // 
            // menuAnimator2
            // 
            this.menuAnimator2.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.menuAnimator2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.menuAnimator2.DefaultAnimation = animation2;
            // 
            // Main_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(865, 416);
            this.Controls.Add(this.sideMenu);
            this.Controls.Add(this.panel1);
            this.menuAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.menuAnimator2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Panel";
            this.Text = "POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Panel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.sideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton minimizeButton;
        private Bunifu.Framework.UI.BunifuImageButton closeButton;
        private Bunifu.Framework.UI.BunifuImageButton menuButton;
        private System.Windows.Forms.Panel sideMenu;
        private Bunifu.Framework.UI.BunifuFlatButton sellingScreenButton;
        private Bunifu.Framework.UI.BunifuFlatButton laduButton;
        private BunifuAnimatorNS.BunifuTransition menuAnimator;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private BunifuAnimatorNS.BunifuTransition menuAnimator2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}

