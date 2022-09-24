using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using RestSharp;
using Tulpep.NotificationWindow;

namespace thirdpage
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            // word
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void slogan_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
        private string getType()
        {
            string _type = "kv";
            if (radioButton1.Checked)
            {
                _type = "expense";
            }
            else if (radioButton2.Checked)
            {
                _type = "kv";
            }
            else if (radioButton4.Checked)
            {
                _type = "text";
            }
            return _type;
        }
        private string getFormat()
        {
            string _format = "json";
            if (radioButton5.Checked)
            {
                _format = "rawtext";
            }
            else if (radioButton6.Checked)
            {
                _format = "json";
            }
            else if (radioButton8.Checked)
            {
                _format = "csv";
            }
            return _format;
        }
        private string getOutput()
        {
            string _output = "single";
            if (radioButton9.Checked)
            {
                _output = "single";
            }
            else if (radioButton10.Checked)
            {
                _output = "multiple";
            }
            return _output;
        }

        private void runPytonScript(string pdfFileName)
        {
            string py_run;
            string _output, _format, _type;
            _type = getType();
            _output = getOutput();
            if (radioButton4.Checked)
            {
                _format = "rawtext";
            }
            else
            {
                _format = getFormat();
            }
            if (keys_str == null)
            {
                keys_str = "None";
            }
            string test_str = "{" + "Type:_" + _type + "_Output:_" + _output + "_Format:_" + _format + "}";
            py_run = string.Format(@"api_call.py {0} {1} {2}", pdfFileName, keys_str, test_str);

            string py_script = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), py_run);

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo("python.exe", py_script)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            if (output.Contains("True"))
            {
                popUp("File was Analyzed and Downloaded in C:\\DocumentAnalyzer\\AnalyzedData");
            }
            else
            {
                popUp(output);
            }
        }
        private void apiCall()
        {
            System.Console.WriteLine("Analyzing PDFs");
            fileNames.ForEach(runPytonScript);
        }
        List<string> fileNames = new List<string>();
        private void button3_Click(object sender, EventArgs e)
        {
            fileNames.Clear();
            // Upload button
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    string file_name = string.Format(@"{0}", fileName);
                    fileNames.Add(file_name);
                }
            }
            if (fileNames.Count == 1)
            {
                radioButton10.Enabled = false;
            }
            else
            {
                radioButton10.Enabled = true;
            }
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button3.Enabled = false;
            Task task = new Task(apiCall);
            task.Start();
            await task;
            button1.Enabled = true;
            button3.Enabled = true;
            popUp("File was Analyzed and Downloaded in C:\\DocumentAnalyzer\\AnalyzedData");
        }
        private void popUp(string msg)
        {
            PopupNotifier notif = new PopupNotifier();
            notif.TitleText = "Document Analyzer";
            notif.ContentText = msg;


            notif.Image = SystemIcons.Information.ToBitmap();
            notif.TitleColor = Color.White;
            notif.BodyColor = Color.Black;
            notif.HeaderColor = Color.Gray;
            notif.ContentColor = Color.White;
            notif.Popup();
        }
        public string keys_str;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            keys_str = textBox1.Text;
            keys_str = keys_str.Replace(" ", "_");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Expenses
            radioButton6.Enabled = true;
            radioButton8.Enabled = true;
            textBox1.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }
        private void HomeScreen_Load_1(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            // Key Value
            radioButton6.Enabled = true;
            radioButton8.Enabled = true;
            textBox1.Enabled = true;
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            // Table
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            // Text
            radioButton6.Enabled = false;
            radioButton8.Enabled = false;
            textBox1.Enabled = false;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            // Single Output
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            // Multiple Output
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            // raw text
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            // json
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            // excel
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
