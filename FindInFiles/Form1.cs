using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindInFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
		string path;
		struct sfile
		{
			public string filename;
			public string filepath;
			public string subpath;
		}
		List<sfile> files;

		void getfiles(DirectoryInfo directoryInfo, List<sfile> files)
		{
			foreach (DirectoryInfo directoryInfo1 in directoryInfo.GetDirectories())
			{
				getfiles(directoryInfo1, files);
			}
			foreach (string filetype in txtFileTypes.Text.Split(','))
			{
				FileInfo[] Files = directoryInfo.GetFiles(filetype); //Getting Text files
				string str = "";
				foreach (FileInfo file in Files)
				{
					sfile _file = new sfile();
					_file.filename = file.Name;
					_file.filepath = file.FullName;
					files.Add(_file);
				}
			}
		}

		private void bBrowse_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog op = new OpenFileDialog();
				op.ValidateNames = false;
				op.CheckFileExists = false;
				op.FileName = "Folder Selection";
				try
				{
					op.InitialDirectory = System.IO.File.ReadAllText("defaultpath1.txt");
				}
				catch { }

				if (op.ShowDialog() == DialogResult.OK)
				{
					path = op.FileName;
					DirectoryInfo directory = new DirectoryInfo(path);
					path = directory.Parent.FullName;
					tBrowse.Text = path;
					try
					{
						System.IO.File.WriteAllText("defaultpath1.txt", path);
					}
					catch { }


					//label1.Text = "Folder:\n--" + path.Split('\\').Last();
					DirectoryInfo d = new DirectoryInfo(path); //Assuming Test is your Folder
					files = new List<sfile>();
					getfiles(d, files);
					listBox1.Items.Clear();
					foreach (sfile file in files)
					{
						listBox1.Items.Add(file.filepath.Replace(path + "\\", ""));
					}
					lStatus.Text = "There are " + files.Count.ToString() + "  files are in the directory with selected types.";
					lItemsFound.Text = "Items Found: " + listBox1.Items.Count.ToString();
				}
			}catch { }
		}

        private void bFindAll_Click(object sender, EventArgs e)
        {
			try
			{
				if (files == null || files.Count == 0) return;
				listBox1.Items.Clear();
				for (int i = 0; i < files.Count; i++)
				{
					string str = System.IO.File.ReadAllText(files[i].filepath);
					if (str.Contains(tFind.Text))
					{
						listBox1.Items.Add(files[i].filepath.Replace(path + "\\", ""));
					}
					lStatus.Text = "Searched in " + (i + 1) + "/" + files.Count + " files. found " + listBox1.Items.Count + " items";
					lItemsFound.Text = "Items Found: " + listBox1.Items.Count.ToString();
				}
			}
			catch { }
        }

		private int FindAndColorText(RichTextBox richTextBox, string textToFind, Color color)
		{
			
				int startIndex = 0;
				int count = 0;
				while (startIndex < richTextBox.TextLength)
				{
					int foundIndex = richTextBox.Find(textToFind, startIndex, RichTextBoxFinds.MatchCase);
					if (foundIndex != -1)
					{
						richTextBox.SelectionStart = foundIndex;
						richTextBox.SelectionLength = textToFind.Length;
						richTextBox.SelectionColor = Color.White;
						richTextBox.SelectionBackColor = color;
						startIndex = foundIndex + textToFind.Length;
						count++;
					}
					else
					{
						break;
					}
				}
				return count;
			
		}

		private int FindAndColorTextNext(RichTextBox richTextBox, string textToFind, Color color)
		{

			if (richTextBox.SelectedText.Equals(textToFind))
			{
				richTextBox.SelectionBackColor = Color.Blue;
				richTextBox.SelectionStart += textToFind.Length;
			}
			int startIndex = richTextBox1.SelectionStart;
			int count = 0;
			
			int foundIndex = richTextBox.Find(textToFind, startIndex, RichTextBoxFinds.MatchCase);
			if (foundIndex != -1)
			{
				richTextBox.SelectionStart = foundIndex;
				richTextBox.SelectionLength = textToFind.Length;
				richTextBox.SelectionColor = Color.White;
				richTextBox.SelectionBackColor = color;
				richTextBox.ScrollToCaret();
				startIndex = foundIndex + textToFind.Length;
				//richTextBox.SelectionStart = startIndex;
				count++;
			}
			else
			{
				richTextBox.SelectionStart = 0;
			}
			return count;

		}


		string selectedpath="";

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
				if (listBox1.SelectedItem == null || listBox1.SelectedIndex==-1) return;
				selectedpath = path +"\\"+ listBox1.SelectedItem.ToString();
				richTextBox1.Text = System.IO.File.ReadAllText(selectedpath);
				int count1 = FindAndColorText(richTextBox1, tFind.Text.ToString(), Color.Blue);
				int count2 = FindAndColorText(richTextBox1, tReplace.Text.ToString(), Color.OrangeRed);
				lStatus.Text = "Selected File: " + listBox1.SelectedItem.ToString()+"   found: "+count1+ " blues and "+count2+" oranges";
				lSelectedFile.Text = listBox1.SelectedItem.ToString();
				bReplaceAllThisFile.Text = "Replace "+count1+" Items In This File Without Save";
				richTextBox1.SelectionStart = 0;
				richTextBox1.ScrollToCaret();
			}
			catch
            {

            }
        }

        private void bSaveThisFile_Click(object sender, EventArgs e)
        {
			try
			{
				System.IO.File.WriteAllText(selectedpath, richTextBox1.Text.ToString());
				lStatus.Text = "File Saved Successfully: " + selectedpath;
				bSaveThisFile.Visible= false;
			}catch(Exception ex)
            {
				lStatus.Text = "Can't save file due to error:" + ex.Message;

			}

		}

        private void bReplaceAllThisFile_Click(object sender, EventArgs e)
        {
			try
			{
				if (richTextBox1.Text == null || richTextBox1.Text.Length == 0) return;
				richTextBox1.Text = richTextBox1.Text.Replace(tFind.Text.ToString(), tReplace.Text.ToString());
				int count1 = FindAndColorText(richTextBox1, tFind.Text.ToString(), Color.Blue);
				int count2 = FindAndColorText(richTextBox1, tReplace.Text.ToString(), Color.OrangeRed);
				lStatus.Text = "Selected File: " + listBox1.SelectedItem.ToString() + "   found: " + count1 + " blues and " + count2 + " oranges";
				bReplaceAllThisFile.Text = "Replace " + count1 + " Items In This File Without Save";
			}
			catch { }
			
		}

        private void bpaste1_Click(object sender, EventArgs e)
        {
            try { 
			tFind.Text = Clipboard.GetText();
			}catch (Exception ex)
            {

            }
        }

        private void bpaste2_Click(object sender, EventArgs e)
        {
			try
			{
				tReplace.Text = Clipboard.GetText();
			}
			catch (Exception ex)
			{

			}
		}

        private void bReplaceAll_Click(object sender, EventArgs e)
        {
			try
			{
				if (listBox1.Items == null || listBox1.Items.Count == 0) return;
				int success = 0;
				int fail = 0;
				string fails = "";
				for (int i = 0; i < listBox1.Items.Count; i++)
				{
					try
					{
						string selectedpath = path + "\\" + listBox1.Items[i].ToString();
						string selectedfile = System.IO.File.ReadAllText(selectedpath);
						string replacedfile = selectedfile.Replace(tFind.Text, tReplace.Text);
						System.IO.File.WriteAllText(selectedpath, replacedfile);
						success++;
					}
					catch (Exception ex)
					{
						fail++;
						if (fails.Length > 0) fails += "\n";
						fails += listBox1.Items[i].ToString();
					}
				}
				lStatus.Text = "Replacement finished: Success: " + success + " Fails: " + fail;

				MessageBox.Show(lStatus.Text + (fails.Length > 0 ? "\n\nFailed Items:\n" + fails : ""));
			}
			catch { }
		}

        private void Form1_Resize(object sender, EventArgs e)
        {
			if (Width < 1043) Width = 1043;
			if (Height < 315) Height = 315;
			listBox1.Left = 25; 
			listBox1.Width = (Width - 80) / 2;
			richTextBox1.Width = (Width - 80) / 2;
			richTextBox1.Left = listBox1.Width + 40;
			pThisFile.Left = richTextBox1.Left;
			listBox1.Height = (Height - listBox1.Top - 60);
			richTextBox1.Height = listBox1.Height;

		}

        private void Form1_Load(object sender, EventArgs e)
        {
			try
			{
			  txtFileTypes.Text= System.IO.File.ReadAllText("filetypes.txt");
			}
			catch { }
			
		}

        private void txtFileTypes_TextChanged(object sender, EventArgs e)
        {
			try
			{
				System.IO.File.WriteAllText("filetypes.txt", txtFileTypes.Text);
			}
			catch { }
		}

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
			try
			{
				if(richTextBox1.Text.Equals(System.IO.File.ReadAllText(selectedpath)))
                {
					bSaveThisFile.Visible = false;
                }else
                {
					bSaveThisFile.Visible = true;
                }
			}
			catch { }
        }

        private void tFind_TextChanged(object sender, EventArgs e)
        {
			try
			{
				listBox1_SelectedIndexChanged(sender, e);
			}
			catch { }
		}

        private void tReplace_TextChanged(object sender, EventArgs e)
        {
			try
			{
				listBox1_SelectedIndexChanged(sender, e);
			}
			catch { }
		}

        private void button1_Click(object sender, EventArgs e)
        {

			int count1 = FindAndColorTextNext(richTextBox1, tFind.Text.ToString(), Color.Green);
		}

        private void button2_Click(object sender, EventArgs e)
        {
			lStatus.Text = richTextBox1.SelectionStart.ToString() + "---" + richTextBox1.SelectionLength + "---" + richTextBox1.SelectedText;
			if (richTextBox1.SelectedText.Equals(tFind.Text))
            {
				richTextBox1.SelectedText = tReplace.Text;
				richTextBox1.SelectionBackColor = Color.OrangeRed;
            }

		}
    }
}
