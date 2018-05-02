namespace TextEditor
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiUndo = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiFormat = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiFont = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiFontColor = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBackColor = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbNew = new System.Windows.Forms.ToolStripButton();
			this.tsbOpen = new System.Windows.Forms.ToolStripButton();
			this.tsbSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbUndo = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbCopy = new System.Windows.Forms.ToolStripButton();
			this.tsbCut = new System.Windows.Forms.ToolStripButton();
			this.tsbPaste = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbFont = new System.Windows.Forms.ToolStripButton();
			this.tsbFontColor = new System.Windows.Forms.ToolStripButton();
			this.tsbBackColor = new System.Windows.Forms.ToolStripButton();
			this.textBox = new System.Windows.Forms.TextBox();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiEdit,
            this.tsmiFormat});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(584, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tsmiFile
			// 
			this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiOpen,
            this.tsmiSave,
            this.tsmiSaveAs,
            this.toolStripMenuItem3,
            this.tsmiExit});
			this.tsmiFile.Name = "tsmiFile";
			this.tsmiFile.Size = new System.Drawing.Size(37, 20);
			this.tsmiFile.Text = "File";
			// 
			// tsmiNew
			// 
			this.tsmiNew.Name = "tsmiNew";
			this.tsmiNew.Size = new System.Drawing.Size(152, 22);
			this.tsmiNew.Text = "New";
			this.tsmiNew.Click += new System.EventHandler(this.tsmiNew_Click);
			// 
			// tsmiOpen
			// 
			this.tsmiOpen.Name = "tsmiOpen";
			this.tsmiOpen.Size = new System.Drawing.Size(152, 22);
			this.tsmiOpen.Text = "Open...";
			this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
			// 
			// tsmiSave
			// 
			this.tsmiSave.Name = "tsmiSave";
			this.tsmiSave.Size = new System.Drawing.Size(152, 22);
			this.tsmiSave.Text = "Save";
			this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
			// 
			// tsmiSaveAs
			// 
			this.tsmiSaveAs.Name = "tsmiSaveAs";
			this.tsmiSaveAs.Size = new System.Drawing.Size(152, 22);
			this.tsmiSaveAs.Text = "Save As...";
			this.tsmiSaveAs.Click += new System.EventHandler(this.tsmiSaveAs_Click);
			// 
			// tsmiEdit
			// 
			this.tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUndo,
            this.toolStripMenuItem1,
            this.tsmiCopy,
            this.tsmiCut,
            this.tsmiPaste,
            this.toolStripMenuItem2,
            this.tsmiSelectAll});
			this.tsmiEdit.Name = "tsmiEdit";
			this.tsmiEdit.Size = new System.Drawing.Size(39, 20);
			this.tsmiEdit.Text = "Edit";
			// 
			// tsmiUndo
			// 
			this.tsmiUndo.Name = "tsmiUndo";
			this.tsmiUndo.Size = new System.Drawing.Size(152, 22);
			this.tsmiUndo.Text = "Undo";
			this.tsmiUndo.Click += new System.EventHandler(this.tsmiUndo_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
			// 
			// tsmiCopy
			// 
			this.tsmiCopy.Name = "tsmiCopy";
			this.tsmiCopy.Size = new System.Drawing.Size(152, 22);
			this.tsmiCopy.Text = "Copy";
			this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
			// 
			// tsmiCut
			// 
			this.tsmiCut.Name = "tsmiCut";
			this.tsmiCut.Size = new System.Drawing.Size(152, 22);
			this.tsmiCut.Text = "Cut";
			this.tsmiCut.Click += new System.EventHandler(this.tsmiCut_Click);
			// 
			// tsmiPaste
			// 
			this.tsmiPaste.Name = "tsmiPaste";
			this.tsmiPaste.Size = new System.Drawing.Size(152, 22);
			this.tsmiPaste.Text = "Paste";
			this.tsmiPaste.Click += new System.EventHandler(this.tsmiPaste_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
			// 
			// tsmiSelectAll
			// 
			this.tsmiSelectAll.Name = "tsmiSelectAll";
			this.tsmiSelectAll.Size = new System.Drawing.Size(152, 22);
			this.tsmiSelectAll.Text = "Select All";
			this.tsmiSelectAll.Click += new System.EventHandler(this.tsmiSelectAll_Click);
			// 
			// tsmiFormat
			// 
			this.tsmiFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFont,
            this.tsmiFontColor,
            this.tsmiBackColor});
			this.tsmiFormat.Name = "tsmiFormat";
			this.tsmiFormat.Size = new System.Drawing.Size(57, 20);
			this.tsmiFormat.Text = "Format";
			// 
			// tsmiFont
			// 
			this.tsmiFont.Name = "tsmiFont";
			this.tsmiFont.Size = new System.Drawing.Size(179, 22);
			this.tsmiFont.Text = "Font...";
			this.tsmiFont.Click += new System.EventHandler(this.tsmiFont_Click);
			// 
			// tsmiFontColor
			// 
			this.tsmiFontColor.Name = "tsmiFontColor";
			this.tsmiFontColor.Size = new System.Drawing.Size(179, 22);
			this.tsmiFontColor.Text = "Font Color...";
			this.tsmiFontColor.Click += new System.EventHandler(this.tsmiFontColor_Click);
			// 
			// tsmiBackColor
			// 
			this.tsmiBackColor.Name = "tsmiBackColor";
			this.tsmiBackColor.Size = new System.Drawing.Size(179, 22);
			this.tsmiBackColor.Text = "Background Color...";
			this.tsmiBackColor.Click += new System.EventHandler(this.tsmiBackColor_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbOpen,
            this.tsbSave,
            this.toolStripSeparator1,
            this.tsbUndo,
            this.toolStripSeparator2,
            this.tsbCopy,
            this.tsbCut,
            this.tsbPaste,
            this.toolStripSeparator3,
            this.tsbFont,
            this.tsbFontColor,
            this.tsbBackColor});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(584, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbNew
			// 
			this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
			this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbNew.Name = "tsbNew";
			this.tsbNew.Size = new System.Drawing.Size(23, 22);
			this.tsbNew.Tag = "";
			this.tsbNew.Text = "New...";
			this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
			// 
			// tsbOpen
			// 
			this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
			this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbOpen.Name = "tsbOpen";
			this.tsbOpen.Size = new System.Drawing.Size(23, 22);
			this.tsbOpen.Text = "Open...";
			this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
			// 
			// tsbSave
			// 
			this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
			this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbSave.Name = "tsbSave";
			this.tsbSave.Size = new System.Drawing.Size(23, 22);
			this.tsbSave.Text = "Save";
			this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbUndo
			// 
			this.tsbUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbUndo.Image = ((System.Drawing.Image)(resources.GetObject("tsbUndo.Image")));
			this.tsbUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbUndo.Name = "tsbUndo";
			this.tsbUndo.Size = new System.Drawing.Size(23, 22);
			this.tsbUndo.Text = "Undo";
			this.tsbUndo.Click += new System.EventHandler(this.tsbUndo_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbCopy
			// 
			this.tsbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbCopy.Image = ((System.Drawing.Image)(resources.GetObject("tsbCopy.Image")));
			this.tsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbCopy.Name = "tsbCopy";
			this.tsbCopy.Size = new System.Drawing.Size(23, 22);
			this.tsbCopy.Text = "Copy";
			this.tsbCopy.Click += new System.EventHandler(this.tsbCopy_Click);
			// 
			// tsbCut
			// 
			this.tsbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbCut.Image = ((System.Drawing.Image)(resources.GetObject("tsbCut.Image")));
			this.tsbCut.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbCut.Name = "tsbCut";
			this.tsbCut.Size = new System.Drawing.Size(23, 22);
			this.tsbCut.Text = "Cut";
			this.tsbCut.Click += new System.EventHandler(this.tsbCut_Click);
			// 
			// tsbPaste
			// 
			this.tsbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbPaste.Image = ((System.Drawing.Image)(resources.GetObject("tsbPaste.Image")));
			this.tsbPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPaste.Name = "tsbPaste";
			this.tsbPaste.Size = new System.Drawing.Size(23, 22);
			this.tsbPaste.Text = "Paste";
			this.tsbPaste.Click += new System.EventHandler(this.tsbPaste_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbFont
			// 
			this.tsbFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbFont.Image = ((System.Drawing.Image)(resources.GetObject("tsbFont.Image")));
			this.tsbFont.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbFont.Name = "tsbFont";
			this.tsbFont.Size = new System.Drawing.Size(23, 22);
			this.tsbFont.Text = "Font...";
			this.tsbFont.Click += new System.EventHandler(this.tsbFont_Click);
			// 
			// tsbFontColor
			// 
			this.tsbFontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbFontColor.Image = ((System.Drawing.Image)(resources.GetObject("tsbFontColor.Image")));
			this.tsbFontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbFontColor.Name = "tsbFontColor";
			this.tsbFontColor.Size = new System.Drawing.Size(23, 22);
			this.tsbFontColor.Text = "Font Color...";
			this.tsbFontColor.Click += new System.EventHandler(this.tsbFontColor_Click);
			// 
			// tsbBackColor
			// 
			this.tsbBackColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbBackColor.Image = ((System.Drawing.Image)(resources.GetObject("tsbBackColor.Image")));
			this.tsbBackColor.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbBackColor.Name = "tsbBackColor";
			this.tsbBackColor.Size = new System.Drawing.Size(23, 22);
			this.tsbBackColor.Text = "Background Color";
			this.tsbBackColor.Click += new System.EventHandler(this.tsbBackColor_Click);
			// 
			// textBox
			// 
			this.textBox.AcceptsReturn = true;
			this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox.Location = new System.Drawing.Point(0, 49);
			this.textBox.Multiline = true;
			this.textBox.Name = "textBox";
			this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox.Size = new System.Drawing.Size(584, 392);
			this.textBox.TabIndex = 2;
			this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(149, 6);
			// 
			// tsmiExit
			// 
			this.tsmiExit.Name = "tsmiExit";
			this.tsmiExit.Size = new System.Drawing.Size(152, 22);
			this.tsmiExit.Text = "Exit";
			this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 441);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Text Editor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmiFile;
		private System.Windows.Forms.ToolStripMenuItem tsmiNew;
		private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
		private System.Windows.Forms.ToolStripMenuItem tsmiSave;
		private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
		private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
		private System.Windows.Forms.ToolStripMenuItem tsmiUndo;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
		private System.Windows.Forms.ToolStripMenuItem tsmiCut;
		private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
		private System.Windows.Forms.ToolStripMenuItem tsmiFormat;
		private System.Windows.Forms.ToolStripMenuItem tsmiFont;
		private System.Windows.Forms.ToolStripMenuItem tsmiFontColor;
		private System.Windows.Forms.ToolStripMenuItem tsmiBackColor;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbNew;
		private System.Windows.Forms.ToolStripButton tsbOpen;
		private System.Windows.Forms.ToolStripButton tsbSave;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tsbUndo;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton tsbCopy;
		private System.Windows.Forms.ToolStripButton tsbCut;
		private System.Windows.Forms.ToolStripButton tsbPaste;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton tsbFont;
		private System.Windows.Forms.ToolStripButton tsbFontColor;
		private System.Windows.Forms.ToolStripButton tsbBackColor;
		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem tsmiExit;
	}
}

