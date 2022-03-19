namespace CornerstoneApartments
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menustripbedroom = new System.Windows.Forms.ToolStripMenuItem();
            this.bedRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bedRoomToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bedRoomToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.viewOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lakeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radiobtn1bath = new System.Windows.Forms.RadioButton();
            this.radiobtn2bath = new System.Windows.Forms.RadioButton();
            this.radiobtn3bath = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblselectedoptions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "CornerstoneApartments";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(848, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menustripbedroom});
            this.menuStrip1.Location = new System.Drawing.Point(21, 239);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(258, 40);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menustripbedroom
            // 
            this.menustripbedroom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bedRoomToolStripMenuItem,
            this.bedRoomToolStripMenuItem1,
            this.bedRoomToolStripMenuItem2});
            this.menustripbedroom.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menustripbedroom.Name = "menustripbedroom";
            this.menustripbedroom.Size = new System.Drawing.Size(250, 38);
            this.menustripbedroom.Text = "Bed room options";
            // 
            // bedRoomToolStripMenuItem
            // 
            this.bedRoomToolStripMenuItem.Name = "bedRoomToolStripMenuItem";
            this.bedRoomToolStripMenuItem.Size = new System.Drawing.Size(511, 44);
            this.bedRoomToolStripMenuItem.Text = "1 Bed room ($450 per month)";
            this.bedRoomToolStripMenuItem.Click += new System.EventHandler(this.bedRoomToolStripMenuItem_Click);
            // 
            // bedRoomToolStripMenuItem1
            // 
            this.bedRoomToolStripMenuItem1.Name = "bedRoomToolStripMenuItem1";
            this.bedRoomToolStripMenuItem1.Size = new System.Drawing.Size(511, 44);
            this.bedRoomToolStripMenuItem1.Text = "2 Bed room ($550 per month)";
            this.bedRoomToolStripMenuItem1.Click += new System.EventHandler(this.bedRoomToolStripMenuItem1_Click);
            // 
            // bedRoomToolStripMenuItem2
            // 
            this.bedRoomToolStripMenuItem2.Name = "bedRoomToolStripMenuItem2";
            this.bedRoomToolStripMenuItem2.Size = new System.Drawing.Size(511, 44);
            this.bedRoomToolStripMenuItem2.Text = "3 Bed room ($700 per month)";
            this.bedRoomToolStripMenuItem2.Click += new System.EventHandler(this.bedRoomToolStripMenuItem2_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncalculate.Location = new System.Drawing.Point(304, 524);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(239, 59);
            this.btncalculate.TabIndex = 3;
            this.btncalculate.Text = "Calculate monthly rate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.SystemColors.Info;
            this.btnreset.Location = new System.Drawing.Point(21, 593);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(117, 37);
            this.btnreset.TabIndex = 4;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.Info;
            this.btnexit.Location = new System.Drawing.Point(766, 593);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(103, 37);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewOptionsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(474, 239);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(206, 40);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // viewOptionsToolStripMenuItem
            // 
            this.viewOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lakeViewToolStripMenuItem,
            this.normalViewToolStripMenuItem});
            this.viewOptionsToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOptionsToolStripMenuItem.Name = "viewOptionsToolStripMenuItem";
            this.viewOptionsToolStripMenuItem.Size = new System.Drawing.Size(198, 38);
            this.viewOptionsToolStripMenuItem.Text = "View options ";
            // 
            // lakeViewToolStripMenuItem
            // 
            this.lakeViewToolStripMenuItem.Name = "lakeViewToolStripMenuItem";
            this.lakeViewToolStripMenuItem.Size = new System.Drawing.Size(519, 44);
            this.lakeViewToolStripMenuItem.Text = "Lake view (+ $50 per month)";
            this.lakeViewToolStripMenuItem.Click += new System.EventHandler(this.lakeViewToolStripMenuItem_Click);
            // 
            // normalViewToolStripMenuItem
            // 
            this.normalViewToolStripMenuItem.Name = "normalViewToolStripMenuItem";
            this.normalViewToolStripMenuItem.Size = new System.Drawing.Size(519, 44);
            this.normalViewToolStripMenuItem.Text = "Normal view (+ $0 per month)";
            this.normalViewToolStripMenuItem.Click += new System.EventHandler(this.normalViewToolStripMenuItem_Click);
            // 
            // radiobtn1bath
            // 
            this.radiobtn1bath.AutoSize = true;
            this.radiobtn1bath.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtn1bath.Location = new System.Drawing.Point(6, 43);
            this.radiobtn1bath.Name = "radiobtn1bath";
            this.radiobtn1bath.Size = new System.Drawing.Size(376, 35);
            this.radiobtn1bath.TabIndex = 7;
            this.radiobtn1bath.TabStop = true;
            this.radiobtn1bath.Text = "1 Bath room (+$0 per month)";
            this.radiobtn1bath.UseVisualStyleBackColor = true;
            // 
            // radiobtn2bath
            // 
            this.radiobtn2bath.AutoSize = true;
            this.radiobtn2bath.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtn2bath.Location = new System.Drawing.Point(408, 43);
            this.radiobtn2bath.Name = "radiobtn2bath";
            this.radiobtn2bath.Size = new System.Drawing.Size(390, 35);
            this.radiobtn2bath.TabIndex = 8;
            this.radiobtn2bath.TabStop = true;
            this.radiobtn2bath.Text = "2 Bath room (+$75 per month)";
            this.radiobtn2bath.UseVisualStyleBackColor = true;
            // 
            // radiobtn3bath
            // 
            this.radiobtn3bath.AutoSize = true;
            this.radiobtn3bath.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtn3bath.Location = new System.Drawing.Point(251, 84);
            this.radiobtn3bath.Name = "radiobtn3bath";
            this.radiobtn3bath.Size = new System.Drawing.Size(404, 35);
            this.radiobtn3bath.TabIndex = 9;
            this.radiobtn3bath.TabStop = true;
            this.radiobtn3bath.Text = "3 Bath room (+$150 per month)";
            this.radiobtn3bath.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobtn1bath);
            this.groupBox1.Controls.Add(this.radiobtn3bath);
            this.groupBox1.Controls.Add(this.radiobtn2bath);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 390);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 128);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bath room options";
            // 
            // lblselectedoptions
            // 
            this.lblselectedoptions.AutoSize = true;
            this.lblselectedoptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselectedoptions.Location = new System.Drawing.Point(260, 344);
            this.lblselectedoptions.Name = "lblselectedoptions";
            this.lblselectedoptions.Size = new System.Drawing.Size(354, 31);
            this.lblselectedoptions.TabIndex = 11;
            this.lblselectedoptions.Text = "Selected bed room and view";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 642);
            this.Controls.Add(this.lblselectedoptions);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menustripbedroom;
        private System.Windows.Forms.ToolStripMenuItem bedRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bedRoomToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bedRoomToolStripMenuItem2;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem viewOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lakeViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalViewToolStripMenuItem;
        private System.Windows.Forms.RadioButton radiobtn1bath;
        private System.Windows.Forms.RadioButton radiobtn2bath;
        private System.Windows.Forms.RadioButton radiobtn3bath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblselectedoptions;
    }
}

