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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ImageToPDF
{
    public partial class Main : Form
    {
        string fname;
        public Main()
        {
            this.fname = "output";
            InitializeComponent();
        }

        private void SourceButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            dialog.Title = "Select an Image to convert to PDF";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                sourcePath.Text = dialog.FileName;
                DestinationPath.Text = Path.GetDirectoryName(sourcePath.Text);
                string[] safeNames = (dialog.SafeFileName).Split('.');
                var names = safeNames.Take<string>(safeNames.Length - 1);
                this.fname = String.Join(".", names);
            }
        }

        private void DestinationButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);

                    DestinationPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            sourcePath.Text = "";
            DestinationPath.Text = "";
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            convertButton.Enabled = false;
            if (sourcePath.Text == "" || DestinationPath.Text == "")
            {
                MessageBox.Show("Select paths to create PDF.");
                convertButton.Enabled = true;
                return;
            }

            Document document = new Document();
            using (var stream = new FileStream(DestinationPath.Text + "\\" + this.fname + ".pdf", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                PdfWriter.GetInstance(document, stream);
                document.Open();
                using (FileStream imageStream = new FileStream(sourcePath.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imageStream);
                    image.SetAbsolutePosition(0, 0);
                    
                    if(image.ScaledHeight > document.PageSize.Height)
                    {
                        image.ScaleAbsoluteHeight(document.PageSize.Height);
                    }

                    if(image.ScaledWidth > document.PageSize.Width)
                    {
                        image.ScaleAbsoluteWidth(document.PageSize.Width);
                    }

                    document.Add(image);
                }
                document.Close();
            }
            convertButton.Enabled = true;

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
