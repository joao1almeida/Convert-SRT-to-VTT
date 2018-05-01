using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Convert_SRT_to_VTT
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
        }

        private void Main_form_Load(object sender, EventArgs e)
        {
            comboSource.SelectedIndex = 0;
        }

        //global variables
        private bool sourceIsFile = true; //if is a single file or entire folder to be converted
        private bool closeWhenComplete = true; //close program when all files converted

        #region GUI EVENT CONTROLS
        private void button_convert_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(inputPathBox.Text) && !String.IsNullOrEmpty(outputPathBox.Text))
            {
                //convert
                try { 
                        if (sourceIsFile) //if is single file
                        {
                            convertAndWriteFile(inputPathBox.Text);
                        }
                        else //if is folder
                        {
                            getFolderFiles();
                        }

                        if (closeWhenComplete) {
                        //exit when all files converted
                        Application.Exit(); }
                    }
                catch (Exception ex)
                {   //prints error to monitor
                    printToMonitor("A error occurred." + Environment.NewLine +
                    "Exception error:" + Environment.NewLine + ex.ToString() + Environment.NewLine);
                }
            }
            else
            {
                printToMonitor("Input files and output directory must be selected.");
            }
        }

        private void button_output_Click(object sender, EventArgs e)
        {
            outputPathBox.Text = selectFolderDialog();
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            if (sourceIsFile)
            {
                inputPathBox.Text = selectFileDialog();
            }
            else
            {
                inputPathBox.Text = selectFolderDialog();
            }
        }

        private void comboSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            //erase current path to prevent errors
            inputPathBox.Clear();

            if (comboSource.SelectedIndex == 0) //is file
            {
                sourceIsFile = true;
            } else { //then is folder
                sourceIsFile = false;
            }
        }

        private void checkCloseAtComplete_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCloseAtComplete.Checked)
            { closeWhenComplete = true; }
            else
            { closeWhenComplete = false; }
                
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            printToMonitor("Simple application to convert .srt subtitles to .vtt subtitles." + Environment.NewLine +
                           "Convert file: convert a single .srt file." + Environment.NewLine +
                           "Convert folder: convert all .srt filed in a folder." + Environment.NewLine +
                           "Input: input folder/file location." + Environment.NewLine +
                           "Output: output location where the converted files will be written." + Environment.NewLine +
                           "WARNING: the program will overwrite a file that exists in the same location, with the same name and extension." + Environment.NewLine);
        }

        private void button_clean_monitor_Click(object sender, EventArgs e)
        {
            monitorTextBox.Clear();
        }
        #endregion

        #region application functions
        private string selectFileDialog()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\";
            ofd.Title = "Select file";

            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            ofd.DefaultExt = "str";
            ofd.Filter = "STR files (*.str)|*.str|All files (*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;

            ofd.ReadOnlyChecked = true;
            ofd.ShowReadOnly = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                 return ofd.FileName;
            }
            else {
                return null;
            }
        }

        private string selectFolderDialog()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                return fbd.SelectedPath;
            }
            else {
                return null;
            }
        }

        private void printToMonitor(string text) //print info to textbox
        {
            monitorTextBox.AppendText(text + Environment.NewLine); //.AppendText to scroll down while adding text to textbox
        }

        
        private void convertAndWriteFile(string filepath)
        {
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            //string[] lines = System.IO.File.ReadAllLines(@"C:\test\test.srt");
            string[] file_lines = File.ReadAllLines(filepath, Encoding.Default);

            printToMonitor("Converting and creating '.vtt' file from: " + filepath + Environment.NewLine + "Destination folder: " + outputPathBox.Text);

            //write converted file
            //default encoding is UTF8 unless other encoding is especified in the 3rd parameter
            File.WriteAllText(outputPathBox.Text +"\\"+ Path.GetFileNameWithoutExtension(filepath) + ".vtt", convert_to_vtt.convert(file_lines));
            printToMonitor("DONE" + Environment.NewLine);
        }

        private void getFolderFiles()
        {
            DirectoryInfo dinfo = new DirectoryInfo(inputPathBox.Text);
            FileInfo[] Files = dinfo.GetFiles("*.srt");

            foreach (FileInfo file in Files)
            {
                convertAndWriteFile(file.FullName);
            }
        }

        #endregion
    }
}
