using System;
using System.IO;
using System.Windows.Forms;

namespace TextEditor
{
	public partial class MainForm : Form
	{
		bool unsavedChanges;
		string fullFileName;
		public MainForm()
		{
			InitializeComponent();
			unsavedChanges = false;
			fullFileName = null;
			tsbUndo.Enabled = false;
			tsmiUndo.Enabled = false;
		}

		private void textBox_TextChanged(object sender, EventArgs e)
		{
			unsavedChanges = true;
			tsbUndo.Enabled = textBox.CanUndo;
			tsmiUndo.Enabled = textBox.CanUndo;
		}

		private void tsmiOpen_Click(object sender, EventArgs e)
		{
			if (unsavedChanges)
			{
				DialogResult dr = 
					MessageBox.Show("The file has been changed. Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNoCancel);
				if (dr == DialogResult.Cancel)
					return;
				if (dr == DialogResult.Yes)
				{
					tsmiSave_Click(sender, e);
					if (unsavedChanges)
						return;
				}	
			}

			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "All Files (*.*)|*.*|Text Files (*.txt)|*.txt||";
			openFileDialog.FilterIndex = 1;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					StreamReader reader = File.OpenText(openFileDialog.FileName);
					textBox.Text = reader.ReadToEnd();
					fullFileName = openFileDialog.FileName;
					this.Text = fullFileName + " - Text Editor";
					unsavedChanges = false;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void tsmiNew_Click(object sender, EventArgs e)
		{
			if (unsavedChanges)
			{
				DialogResult dr =
					MessageBox.Show("The file has been changed. Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNoCancel);
				if (dr == DialogResult.Cancel)
					return;
				if (dr == DialogResult.Yes)
				{
					tsmiSave_Click(sender, e);
					if (unsavedChanges)
						return;
				}	
			}

			textBox.Clear();
			this.Text = "Text Editor";
			unsavedChanges = false;
			fullFileName = null;
		}

		private void tsmiSave_Click(object sender, EventArgs e)
		{
			if (fullFileName == null)
			{
				tsmiSaveAs_Click(sender, e);
				return;
			}
			if (!unsavedChanges)
				return;
			SaveToFile();
		}

		private void SaveToFile()
		{
			try
			{
				StreamWriter writer = new StreamWriter(fullFileName);
				writer.Write(textBox.Text);
				writer.Close();
				unsavedChanges = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}

		private void tsmiSaveAs_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "All Files (*.*)|*.*|Text Files (*.txt)|*.txt||";
			saveFileDialog.FilterIndex = 1;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				fullFileName = saveFileDialog.FileName;
				SaveToFile();
				this.Text = fullFileName + " - Text Editor";
			}
		}

		private void tsmiExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (unsavedChanges)
			{
				DialogResult dr =
					MessageBox.Show("The file has been changed. Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNoCancel);
				if (dr == DialogResult.Cancel)
					e.Cancel = true;
				if (dr == DialogResult.Yes)
				{
					tsmiSave_Click(sender, e);
					if (unsavedChanges)
						e.Cancel = true;
				}
			}
		}

		private void tsmiUndo_Click(object sender, EventArgs e)
		{
			textBox.Undo();
		}

		private void tsmiCopy_Click(object sender, EventArgs e)
		{
			textBox.Copy();
		}

		private void tsmiCut_Click(object sender, EventArgs e)
		{
			textBox.Cut();
		}

		private void tsmiPaste_Click(object sender, EventArgs e)
		{
			textBox.Paste();
		}

		private void tsmiSelectAll_Click(object sender, EventArgs e)
		{
			textBox.SelectAll();
		}

		private void tsmiFont_Click(object sender, EventArgs e)
		{
			FontDialog dialog = new FontDialog();
			dialog.Font = textBox.Font;
			if (dialog.ShowDialog() == DialogResult.OK)
				textBox.Font = dialog.Font;
		}

		private void tsmiFontColor_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			dialog.Color = textBox.ForeColor;
			if (dialog.ShowDialog() == DialogResult.OK)
				textBox.ForeColor = dialog.Color;
		}

		private void tsmiBackColor_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			dialog.Color = textBox.BackColor;
			if (dialog.ShowDialog() == DialogResult.OK)
				textBox.BackColor = dialog.Color;
		}

		// ToolStrip buttons clicks call the respective functions for MenuItems clicks:
		private void tsbNew_Click(object sender, EventArgs e)
		{
			tsmiNew_Click(sender, e);
		}
		private void tsbOpen_Click(object sender, EventArgs e)
		{
			tsmiOpen_Click(sender, e);
		}
		private void tsbSave_Click(object sender, EventArgs e)
		{
			tsmiSave_Click(sender, e);
		}
		private void tsbUndo_Click(object sender, EventArgs e)
		{
			tsmiUndo_Click(sender, e);
		}
		private void tsbCopy_Click(object sender, EventArgs e)
		{
			tsmiCopy_Click(sender, e);
		}
		private void tsbCut_Click(object sender, EventArgs e)
		{
			tsmiCut_Click(sender, e);
		}
		private void tsbPaste_Click(object sender, EventArgs e)
		{
			tsmiPaste_Click(sender, e);
		}
		private void tsbFont_Click(object sender, EventArgs e)
		{
			tsmiFont_Click(sender, e);
		}
		private void tsbFontColor_Click(object sender, EventArgs e)
		{
			tsmiFontColor_Click(sender, e);
		}
		private void tsbBackColor_Click(object sender, EventArgs e)
		{
			tsmiBackColor_Click(sender, e);
		}
	}
}
