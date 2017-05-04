namespace BitwiseCalcSharp
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
               this.components = new System.ComponentModel.Container();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
               this.txtHexXor01 = new System.Windows.Forms.TextBox();
               this.txtHexXor02 = new System.Windows.Forms.TextBox();
               this.txtHexXorResult = new System.Windows.Forms.TextBox();
               this.btnHexXor = new System.Windows.Forms.Button();
               this.txtHexNot = new System.Windows.Forms.TextBox();
               this.txtHexNotResult = new System.Windows.Forms.TextBox();
               this.btnHexNot = new System.Windows.Forms.Button();
               this.mnuMain = new System.Windows.Forms.MenuStrip();
               this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
               this.mnuQuit = new System.Windows.Forms.ToolStripMenuItem();
               this.mnuQuestionMark = new System.Windows.Forms.ToolStripMenuItem();
               this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
               this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
               this.txtHexOr01 = new System.Windows.Forms.TextBox();
               this.txtHexOr2 = new System.Windows.Forms.TextBox();
               this.txtHexOrResult = new System.Windows.Forms.TextBox();
               this.txtHexAnd01 = new System.Windows.Forms.TextBox();
               this.txtHexAnd02 = new System.Windows.Forms.TextBox();
               this.txtHexAndResult = new System.Windows.Forms.TextBox();
               this.btnHexAnd = new System.Windows.Forms.Button();
               this.btnHexOr = new System.Windows.Forms.Button();
               this.mnuMain.SuspendLayout();
               this.SuspendLayout();
               // 
               // txtHexXor01
               // 
               this.txtHexXor01.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.txtHexXor01.Location = new System.Drawing.Point(12, 87);
               this.txtHexXor01.MaxLength = 8;
               this.txtHexXor01.Name = "txtHexXor01";
               this.txtHexXor01.Size = new System.Drawing.Size(100, 19);
               this.txtHexXor01.TabIndex = 8;
               this.txtHexXor01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               this.txtHexXor01.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHexXor01_KeyPress);
               this.txtHexXor01.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHexXor01_KeyUp);
               // 
               // txtHexXor02
               // 
               this.txtHexXor02.AcceptsTab = true;
               this.txtHexXor02.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.txtHexXor02.Location = new System.Drawing.Point(118, 87);
               this.txtHexXor02.MaxLength = 8;
               this.txtHexXor02.Name = "txtHexXor02";
               this.txtHexXor02.Size = new System.Drawing.Size(100, 19);
               this.txtHexXor02.TabIndex = 9;
               this.txtHexXor02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               this.txtHexXor02.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHexXor02_KeyPress);
               this.txtHexXor02.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHexXor02_KeyUp);
               // 
               // txtHexXorResult
               // 
               this.txtHexXorResult.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.txtHexXorResult.Location = new System.Drawing.Point(301, 87);
               this.txtHexXorResult.Name = "txtHexXorResult";
               this.txtHexXorResult.ReadOnly = true;
               this.txtHexXorResult.Size = new System.Drawing.Size(100, 19);
               this.txtHexXorResult.TabIndex = 11;
               this.txtHexXorResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               // 
               // btnHexXor
               // 
               this.btnHexXor.Location = new System.Drawing.Point(222, 87);
               this.btnHexXor.Name = "btnHexXor";
               this.btnHexXor.Size = new System.Drawing.Size(75, 19);
               this.btnHexXor.TabIndex = 10;
               this.btnHexXor.Text = "XOR";
               this.btnHexXor.UseVisualStyleBackColor = true;
               this.btnHexXor.Click += new System.EventHandler(this.btnHexXor_Click);
               // 
               // txtHexNot
               // 
               this.txtHexNot.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.txtHexNot.Location = new System.Drawing.Point(118, 112);
               this.txtHexNot.MaxLength = 8;
               this.txtHexNot.Name = "txtHexNot";
               this.txtHexNot.Size = new System.Drawing.Size(100, 19);
               this.txtHexNot.TabIndex = 12;
               this.txtHexNot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               this.txtHexNot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHexNot_KeyPress);
               this.txtHexNot.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHexNot_KeyUp);
               // 
               // txtHexNotResult
               // 
               this.txtHexNotResult.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.txtHexNotResult.Location = new System.Drawing.Point(301, 112);
               this.txtHexNotResult.Name = "txtHexNotResult";
               this.txtHexNotResult.ReadOnly = true;
               this.txtHexNotResult.Size = new System.Drawing.Size(100, 19);
               this.txtHexNotResult.TabIndex = 14;
               this.txtHexNotResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               // 
               // btnHexNot
               // 
               this.btnHexNot.Location = new System.Drawing.Point(222, 112);
               this.btnHexNot.Name = "btnHexNot";
               this.btnHexNot.Size = new System.Drawing.Size(75, 19);
               this.btnHexNot.TabIndex = 13;
               this.btnHexNot.Text = "NOT";
               this.btnHexNot.UseVisualStyleBackColor = true;
               this.btnHexNot.Click += new System.EventHandler(this.btnHexNot_Click);
               // 
               // mnuMain
               // 
               this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuQuestionMark});
               this.mnuMain.Location = new System.Drawing.Point(0, 0);
               this.mnuMain.Name = "mnuMain";
               this.mnuMain.Size = new System.Drawing.Size(419, 24);
               this.mnuMain.TabIndex = 7;
               this.mnuMain.Text = "menuStrip1";
               // 
               // mnuFile
               // 
               this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuit});
               this.mnuFile.Name = "mnuFile";
               this.mnuFile.Size = new System.Drawing.Size(37, 20);
               this.mnuFile.Text = "&File";
               // 
               // mnuQuit
               // 
               this.mnuQuit.Image = global::BitwiseCalcSharp.Properties.Resources.Close;
               this.mnuQuit.Name = "mnuQuit";
               this.mnuQuit.ShortcutKeyDisplayString = "Ctrl+Q";
               this.mnuQuit.Size = new System.Drawing.Size(140, 22);
               this.mnuQuit.Text = "&Quit";
               this.mnuQuit.Click += new System.EventHandler(this.mnuQuit_Click);
               // 
               // mnuQuestionMark
               // 
               this.mnuQuestionMark.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
               this.mnuQuestionMark.Name = "mnuQuestionMark";
               this.mnuQuestionMark.Size = new System.Drawing.Size(24, 20);
               this.mnuQuestionMark.Text = "?";
               // 
               // mnuAbout
               // 
               this.mnuAbout.Image = global::BitwiseCalcSharp.Properties.Resources.About;
               this.mnuAbout.Name = "mnuAbout";
               this.mnuAbout.Size = new System.Drawing.Size(107, 22);
               this.mnuAbout.Text = "About";
               this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
               // 
               // contextMenuStrip1
               // 
               this.contextMenuStrip1.Name = "contextMenuStrip1";
               this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
               // 
               // txtHexOr01
               // 
               this.txtHexOr01.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.txtHexOr01.Location = new System.Drawing.Point(12, 62);
               this.txtHexOr01.MaxLength = 8;
               this.txtHexOr01.Name = "txtHexOr01";
               this.txtHexOr01.Size = new System.Drawing.Size(100, 19);
               this.txtHexOr01.TabIndex = 4;
               this.txtHexOr01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               this.txtHexOr01.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHexOr01_KeyPress);
               this.txtHexOr01.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHexOr01_KeyUp);
               // 
               // txtHexOr2
               // 
               this.txtHexOr2.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.txtHexOr2.Location = new System.Drawing.Point(118, 62);
               this.txtHexOr2.MaxLength = 8;
               this.txtHexOr2.Name = "txtHexOr2";
               this.txtHexOr2.Size = new System.Drawing.Size(100, 19);
               this.txtHexOr2.TabIndex = 5;
               this.txtHexOr2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               this.txtHexOr2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHexOr2_KeyPress);
               this.txtHexOr2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHexOr2_KeyUp);
               // 
               // txtHexOrResult
               // 
               this.txtHexOrResult.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.txtHexOrResult.Location = new System.Drawing.Point(301, 62);
               this.txtHexOrResult.Name = "txtHexOrResult";
               this.txtHexOrResult.ReadOnly = true;
               this.txtHexOrResult.Size = new System.Drawing.Size(100, 19);
               this.txtHexOrResult.TabIndex = 7;
               this.txtHexOrResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               // 
               // txtHexAnd01
               // 
               this.txtHexAnd01.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.txtHexAnd01.Location = new System.Drawing.Point(12, 37);
               this.txtHexAnd01.MaxLength = 8;
               this.txtHexAnd01.Name = "txtHexAnd01";
               this.txtHexAnd01.Size = new System.Drawing.Size(100, 19);
               this.txtHexAnd01.TabIndex = 0;
               this.txtHexAnd01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               this.txtHexAnd01.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHexAnd01_KeyPress);
               this.txtHexAnd01.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHexAnd01_KeyUp);
               // 
               // txtHexAnd02
               // 
               this.txtHexAnd02.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.txtHexAnd02.Location = new System.Drawing.Point(118, 37);
               this.txtHexAnd02.MaxLength = 8;
               this.txtHexAnd02.Name = "txtHexAnd02";
               this.txtHexAnd02.Size = new System.Drawing.Size(100, 19);
               this.txtHexAnd02.TabIndex = 1;
               this.txtHexAnd02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               this.txtHexAnd02.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHexAnd02_KeyPress);
               this.txtHexAnd02.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHexAnd02_KeyUp);
               // 
               // txtHexAndResult
               // 
               this.txtHexAndResult.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.txtHexAndResult.Location = new System.Drawing.Point(301, 37);
               this.txtHexAndResult.Name = "txtHexAndResult";
               this.txtHexAndResult.ReadOnly = true;
               this.txtHexAndResult.Size = new System.Drawing.Size(100, 19);
               this.txtHexAndResult.TabIndex = 3;
               this.txtHexAndResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               // 
               // btnHexAnd
               // 
               this.btnHexAnd.Location = new System.Drawing.Point(222, 37);
               this.btnHexAnd.Name = "btnHexAnd";
               this.btnHexAnd.Size = new System.Drawing.Size(75, 19);
               this.btnHexAnd.TabIndex = 2;
               this.btnHexAnd.Text = "AND";
               this.btnHexAnd.UseVisualStyleBackColor = true;
               this.btnHexAnd.Click += new System.EventHandler(this.btnHexAnd_Click);
               // 
               // btnHexOr
               // 
               this.btnHexOr.Location = new System.Drawing.Point(222, 62);
               this.btnHexOr.Name = "btnHexOr";
               this.btnHexOr.Size = new System.Drawing.Size(75, 19);
               this.btnHexOr.TabIndex = 6;
               this.btnHexOr.Text = "OR";
               this.btnHexOr.UseVisualStyleBackColor = true;
               this.btnHexOr.Click += new System.EventHandler(this.btnHexOr_Click);
               // 
               // frmMain
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(419, 176);
               this.Controls.Add(this.btnHexOr);
               this.Controls.Add(this.btnHexAnd);
               this.Controls.Add(this.txtHexAndResult);
               this.Controls.Add(this.txtHexAnd02);
               this.Controls.Add(this.txtHexAnd01);
               this.Controls.Add(this.txtHexOrResult);
               this.Controls.Add(this.txtHexOr2);
               this.Controls.Add(this.txtHexOr01);
               this.Controls.Add(this.btnHexNot);
               this.Controls.Add(this.txtHexNotResult);
               this.Controls.Add(this.txtHexNot);
               this.Controls.Add(this.btnHexXor);
               this.Controls.Add(this.txtHexXorResult);
               this.Controls.Add(this.txtHexXor02);
               this.Controls.Add(this.txtHexXor01);
               this.Controls.Add(this.mnuMain);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.MainMenuStrip = this.mnuMain;
               this.MaximizeBox = false;
               this.Name = "frmMain";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Form1";
               this.mnuMain.ResumeLayout(false);
               this.mnuMain.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.TextBox txtHexXor01;
          private System.Windows.Forms.TextBox txtHexXor02;
          private System.Windows.Forms.TextBox txtHexXorResult;
          private System.Windows.Forms.Button btnHexXor;
          private System.Windows.Forms.TextBox txtHexNot;
          private System.Windows.Forms.TextBox txtHexNotResult;
          private System.Windows.Forms.Button btnHexNot;
          private System.Windows.Forms.MenuStrip mnuMain;
          private System.Windows.Forms.ToolStripMenuItem mnuFile;
          private System.Windows.Forms.ToolStripMenuItem mnuQuit;
          private System.Windows.Forms.ToolStripMenuItem mnuQuestionMark;
          private System.Windows.Forms.ToolStripMenuItem mnuAbout;
          private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
          private System.Windows.Forms.TextBox txtHexOr01;
          private System.Windows.Forms.TextBox txtHexOr2;
          private System.Windows.Forms.TextBox txtHexOrResult;
          private System.Windows.Forms.TextBox txtHexAnd01;
          private System.Windows.Forms.TextBox txtHexAnd02;
          private System.Windows.Forms.TextBox txtHexAndResult;
          private System.Windows.Forms.Button btnHexAnd;
          private System.Windows.Forms.Button btnHexOr;
     }
}

