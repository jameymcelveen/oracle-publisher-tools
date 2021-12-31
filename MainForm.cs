using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OraclePublisherPrintHelper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            printDialog.ShowDialog();
        }

        private void runCmd(string cmd)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "CMD.exe";
            startInfo.Arguments = "/c dir";
            process.StartInfo = startInfo;
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            richTextBox.Text = output;
            process.WaitForExit();

            /* try
             {
                 using (Process p = new Process())
                 {
                     // set start info
                     p.StartInfo = new ProcessStartInfo("cmd.exe")
                     {
                         RedirectStandardInput = true,
                         RedirectStandardOutput = true,
                         RedirectStandardError = true,
                         UseShellExecute = false,
                         WorkingDirectory = @"c:\"
                     };
                     // event handlers for output & error
                     p.OutputDataReceived += p_OutputDataReceived;
                     p.ErrorDataReceived += p_ErrorDataReceived;

                     // start process
                     p.Start();
                     // send command to its input
                     p.StandardInput.Write("dir" + p.StandardInput.NewLine);
                     //wait
                     p.WaitForExit();
                 }
             }
             catch (Exception ex)
             {
                 Console.WriteLine(ex);
             }*/
        }

        private void p_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            Process p = sender as Process;
            if (p == null)
                return;
            richTextBox.AppendText(e.Data);
            Console.WriteLine(e.Data);
        }

        private void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Process p = sender as Process;
            if (p == null)
                return;
            richTextBox.AppendText(e.Data);
            Console.WriteLine(e.Data);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            runCmd("");
        }

        private void buttonBuild_Click(object sender, EventArgs e)
        {

        }

        /*        private void getSaveActiveWorDoc()
                {
                    object wordAsObject;
                    Microsoft.Office.Interop.Word.Application word;

                    try
                    {
                        wordAsObject = Marshal.GetActiveObject("Word.Application");
                        //If there is a running Word instance, it gets saved into the word variable
                        word = (Microsoft.Office.Interop.Word.Application)wordAsObject;

                        Console.WriteLine("{0}", word.ActiveDocument.FullName);

                        Console.ReadKey();
                    }
                    catch (COMException)
                    {
                        //If there is no running instance, it creates a new one
                        //Type type = Type.GetTypeFromProgID("Word.Application");
                        //wordAsObject = System.Activator.CreateInstance(type);
                    }
                }*/
    }
}
