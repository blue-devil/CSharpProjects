namespace ResimIndir
{
    partial class frmMain
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
               this.menuStrip1 = new System.Windows.Forms.MenuStrip();
               this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
               this.menuQuit = new System.Windows.Forms.ToolStripMenuItem();
               this.menuQuestionMark = new System.Windows.Forms.ToolStripMenuItem();
               this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
               this.pictSenkron = new System.Windows.Forms.PictureBox();
               this.pictAsenkron = new System.Windows.Forms.PictureBox();
               this.btnSenkron = new System.Windows.Forms.Button();
               this.btnAsenkron = new System.Windows.Forms.Button();
               this.txtSenkron = new System.Windows.Forms.TextBox();
               this.txtAsenkron = new System.Windows.Forms.TextBox();
               this.menuStrip1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictSenkron)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictAsenkron)).BeginInit();
               this.SuspendLayout();
               // 
               // menuStrip1
               // 
               this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuQuestionMark});
               this.menuStrip1.Location = new System.Drawing.Point(0, 0);
               this.menuStrip1.Name = "menuStrip1";
               this.menuStrip1.Size = new System.Drawing.Size(666, 24);
               this.menuStrip1.TabIndex = 0;
               this.menuStrip1.Text = "menuMain";
               // 
               // menuFile
               // 
               this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQuit});
               this.menuFile.Name = "menuFile";
               this.menuFile.Size = new System.Drawing.Size(37, 20);
               this.menuFile.Text = "&File";
               // 
               // menuQuit
               // 
               this.menuQuit.Image = global::ResimIndir.Properties.Resources.Close;
               this.menuQuit.Name = "menuQuit";
               this.menuQuit.Size = new System.Drawing.Size(152, 22);
               this.menuQuit.Text = "&Quit";
               this.menuQuit.Click += new System.EventHandler(this.menuQuit_Click);
               // 
               // menuQuestionMark
               // 
               this.menuQuestionMark.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
               this.menuQuestionMark.Name = "menuQuestionMark";
               this.menuQuestionMark.Size = new System.Drawing.Size(24, 20);
               this.menuQuestionMark.Text = "?";
               // 
               // menuAbout
               // 
               this.menuAbout.Image = global::ResimIndir.Properties.Resources.About;
               this.menuAbout.Name = "menuAbout";
               this.menuAbout.Size = new System.Drawing.Size(107, 22);
               this.menuAbout.Text = "About";
               this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
               // 
               // pictSenkron
               // 
               this.pictSenkron.Location = new System.Drawing.Point(32, 48);
               this.pictSenkron.Name = "pictSenkron";
               this.pictSenkron.Size = new System.Drawing.Size(291, 196);
               this.pictSenkron.TabIndex = 1;
               this.pictSenkron.TabStop = false;
               // 
               // pictAsenkron
               // 
               this.pictAsenkron.Location = new System.Drawing.Point(343, 48);
               this.pictAsenkron.Name = "pictAsenkron";
               this.pictAsenkron.Size = new System.Drawing.Size(291, 196);
               this.pictAsenkron.TabIndex = 2;
               this.pictAsenkron.TabStop = false;
               // 
               // btnSenkron
               // 
               this.btnSenkron.Location = new System.Drawing.Point(32, 262);
               this.btnSenkron.Name = "btnSenkron";
               this.btnSenkron.Size = new System.Drawing.Size(291, 23);
               this.btnSenkron.TabIndex = 3;
               this.btnSenkron.Text = "Senkron İndirme";
               this.btnSenkron.UseVisualStyleBackColor = true;
               this.btnSenkron.Click += new System.EventHandler(this.btnSenkron_Click);
               // 
               // btnAsenkron
               // 
               this.btnAsenkron.Location = new System.Drawing.Point(343, 262);
               this.btnAsenkron.Name = "btnAsenkron";
               this.btnAsenkron.Size = new System.Drawing.Size(291, 23);
               this.btnAsenkron.TabIndex = 4;
               this.btnAsenkron.Text = "Asenkron İndirme";
               this.btnAsenkron.UseVisualStyleBackColor = true;
               this.btnAsenkron.Click += new System.EventHandler(this.btnAsenkron_Click);
               // 
               // txtSenkron
               // 
               this.txtSenkron.Location = new System.Drawing.Point(32, 297);
               this.txtSenkron.Name = "txtSenkron";
               this.txtSenkron.ReadOnly = true;
               this.txtSenkron.Size = new System.Drawing.Size(291, 20);
               this.txtSenkron.TabIndex = 5;
               // 
               // txtAsenkron
               // 
               this.txtAsenkron.Location = new System.Drawing.Point(343, 297);
               this.txtAsenkron.Name = "txtAsenkron";
               this.txtAsenkron.ReadOnly = true;
               this.txtAsenkron.Size = new System.Drawing.Size(291, 20);
               this.txtAsenkron.TabIndex = 6;
               // 
               // frmMain
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(666, 329);
               this.Controls.Add(this.txtAsenkron);
               this.Controls.Add(this.txtSenkron);
               this.Controls.Add(this.btnAsenkron);
               this.Controls.Add(this.btnSenkron);
               this.Controls.Add(this.pictAsenkron);
               this.Controls.Add(this.pictSenkron);
               this.Controls.Add(this.menuStrip1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.MainMenuStrip = this.menuStrip1;
               this.MaximizeBox = false;
               this.Name = "frmMain";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "[SCT]Asenkron - Resim İndirme";
               this.menuStrip1.ResumeLayout(false);
               this.menuStrip1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictSenkron)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictAsenkron)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuQuit;
        private System.Windows.Forms.ToolStripMenuItem menuQuestionMark;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.PictureBox pictSenkron;
        private System.Windows.Forms.PictureBox pictAsenkron;
        private System.Windows.Forms.Button btnSenkron;
        private System.Windows.Forms.Button btnAsenkron;
        private System.Windows.Forms.TextBox txtSenkron;
        private System.Windows.Forms.TextBox txtAsenkron;
    }
}

