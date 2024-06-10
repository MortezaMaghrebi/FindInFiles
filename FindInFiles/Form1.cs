using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

		public static bool SearchString(string text, string searchTerm, bool matchCase, bool matchWholeWord)
		{
			if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(searchTerm))
			{
				return false;
			}

			var options = RegexOptions.None;
			if (!matchCase)
			{
				options |= RegexOptions.IgnoreCase;
			}

			string pattern = searchTerm;
			if (matchWholeWord)
			{
				pattern = @"\b" + searchTerm.Trim() + @"\b";
			}

			return Regex.IsMatch(text, pattern, options);
		}

		public static string ReplaceString(string text, string searchTerm,string ReplaceTerm, bool matchCase, bool matchWholeWord)
		{
			if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(searchTerm))
			{
				return text;
			}

			var options = RegexOptions.None;
			if (!matchCase)
			{
				options |= RegexOptions.IgnoreCase;
			}

			string pattern = searchTerm;
			if (matchWholeWord)
			{
				pattern = @"\b" + searchTerm.Trim() + @"\b";
			}

			string replacedText= Regex.Replace(text,pattern,ReplaceTerm,options);
			return replacedText;
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

					if (SearchString(str,tFind.Text,cMatchCase.Checked,cMatchWholeWord.Checked))
					{

						//Regex.Match(str,tFind.Text,RegexOptions.);
						
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
					var findOptions = RichTextBoxFinds.None;
					if (cMatchCase.Checked)
					{
						findOptions |= RichTextBoxFinds.MatchCase; // Inverted logic for RichTextBoxFinds.MatchCase
					}
					if (cMatchWholeWord.Checked)
					{
						findOptions |= RichTextBoxFinds.WholeWord;
					}
					int foundIndex = richTextBox.Find(textToFind, startIndex, findOptions);
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

		private void SeekToFirstOccurence(RichTextBox richTextBox, string textToFind)
		{

			int startIndex = 0;
			int count = 0;

			var findOptions = RichTextBoxFinds.None;
			if (cMatchCase.Checked)
			{
				findOptions |= RichTextBoxFinds.MatchCase; // Inverted logic for RichTextBoxFinds.MatchCase
			}
			if (cMatchWholeWord.Checked)
			{
				findOptions |= RichTextBoxFinds.WholeWord;
			}
			int foundIndex = richTextBox.Find(textToFind, startIndex, findOptions);
			if (foundIndex != -1)
			{
				if (foundIndex > 60) foundIndex -= 60;
				else foundIndex = 0;
				richTextBox.SelectionStart = foundIndex;
				richTextBox.ScrollToCaret();
			}

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
			
			var findOptions = RichTextBoxFinds.None;
			if (cMatchCase.Checked)
			{
				findOptions |= RichTextBoxFinds.MatchCase; // Inverted logic for RichTextBoxFinds.MatchCase
			}
			if (cMatchWholeWord.Checked)
			{
				findOptions |= RichTextBoxFinds.WholeWord;
			}
			int foundIndex = richTextBox.Find(textToFind, startIndex, findOptions);
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
				SeekToFirstOccurence(richTextBox1, tFind.Text);
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
						string replacedfile = ReplaceString(selectedfile, tFind.Text, tReplace.Text, cMatchCase.Checked, cMatchWholeWord.Checked);// selectedfile.Replace(tFind.Text, tReplace.Text);
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
			if (WindowState != FormWindowState.Minimized)
			{
				if(listBox1.Left!=25) listBox1.Left = 25;
				if (listBox1.Width != (Width - 80) / 2) listBox1.Width = (Width - 80) / 2;
				if(richTextBox1.Width != (Width - 80) / 2) richTextBox1.Width = (Width - 80) / 2;
				if(richTextBox1.Left != listBox1.Width + 40)richTextBox1.Left = listBox1.Width + 40;
				if(pThisFile.Left != richTextBox1.Left) pThisFile.Left = richTextBox1.Left;
				if(listBox1.Height != (Height - listBox1.Top - 60))listBox1.Height = (Height - listBox1.Top - 60);
				if(richTextBox1.Height != listBox1.Height)richTextBox1.Height = listBox1.Height;
			}
		}

        private void Form1_Load(object sender, EventArgs e)
        {
			try
			{
			  txtFileTypes.Text= System.IO.File.ReadAllText("filetypes.txt");
				Form1_Resize(sender, e);
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

        

		private void bFindNext_Click(object sender, EventArgs e)
		{

			int count1 = FindAndColorTextNext(richTextBox1, tFind.Text.ToString(), Color.Green);
		}

		private void bReplaceThis_Click(object sender, EventArgs e)
		{
			lStatus.Text = richTextBox1.SelectionStart.ToString() + "---" + richTextBox1.SelectionLength + "---" + richTextBox1.SelectedText;
			if (richTextBox1.SelectedText.Equals(tFind.Text))
			{
				int selectedindex = richTextBox1.SelectionStart;
				richTextBox1.SelectedText = tReplace.Text;
				richTextBox1.SelectionStart = selectedindex;
				richTextBox1.SelectionLength = tReplace.TextLength;
				richTextBox1.SelectionBackColor = Color.OrangeRed;
			}

		}

        private void bChange_Click(object sender, EventArgs e)
        {
			string replace = tReplace.Text;
			tReplace.Text = tFind.Text;
			tFind.Text = replace;
        }
    }
}
